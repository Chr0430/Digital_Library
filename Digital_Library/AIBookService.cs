using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Digital_Library
{
    //AI连接服务功能
    //接收用户提问，提取关键词，查询数据库图书，调用本地大模型生成友好回复
    internal class AIBookService
    {
        private readonly MySQLConnect _mysqlconnect;
        private readonly HttpClient _httpClient;//HTTP客户端，用于调用本地Ollama大模型接口

        public AIBookService()
        {
            _mysqlconnect = new MySQLConnect();

            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(60); //设置超时时间60秒
        }

        public async Task<string> ChatAsync(string userMessage)
        {
            try
            {
                //从用户问题中提取图书关键词或作者名
                string keyword = await ExtractKeywordOrAuthor(userMessage);
                if (string.IsNullOrWhiteSpace(keyword))
                    return "本图书馆中暂时没有符合您需求的书籍";

                //根据关键词从数据库查询可借阅的图书
                string bookList = SearchFromDB(keyword);
                if (bookList == "无匹配书籍")
                    return "本图书馆中暂时没有符合您需求的书籍";

                // 将查询到的图书信息交给AI
                return await GenerateSafeReply(bookList, userMessage);
            }
            catch
            {
                //出现错误
                return "本图书馆中暂时没有符合您需求的书籍";
            }
        }

        //优先提取作者，无作者则提取分类关键词，都没有返回空
        private async Task<string> ExtractKeywordOrAuthor(string userMessage)
        {
            string prompt = $@"
任务：从用户问题里提取一个关键词。
规则：
1. 如果提到作者名字，直接输出作者名。
2. 如果没提到作者名字，分析用户问题，从下面列表选一个关联度最大的词语输出，比如向学生推荐书的关键词为成长或教育。
3. 都不是，输出：无

【分类列表】
小说,经典,随笔,散文,诗歌,童话,推理,绘本,悬疑,科幻,青春,言情,武侠,历史,心理学,哲学,社会学,传记,艺术,政治,宗教,爱情,成长,教育,励志,心理,旅行,职场,摄影,美食,经济,管理,商业,金融,投资,营销,广告,科普,科学,编程,算法,通信

用户问题：{userMessage}
只输出一个词：
";

            var req = new
            {
                model = "qwen:7b",
                prompt = prompt,
                stream = false,// 关闭流式输出
                options = new { num_predict = 15 } // 限制输出长度
            };
            // 序列化为JSON格式
            string json = JsonConvert.SerializeObject(req);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            // 调用Ollama本地接口
            var resp = await _httpClient.PostAsync(AppConfig.OllamaEndpoint, content);
            dynamic res = JsonConvert.DeserializeObject(await resp.Content.ReadAsStringAsync());
            // 处理AI返回结果
            string output = res.response.ToString().Trim();
            return output == "无" ? "" : output;
        }

        /// <summary>
        /// 根据关键词从MySQL数据库查询图书，匹配书名、作者、分类，只取在馆可借的书（Lend_Status = 'Save'）
        /// </summary>
        private string SearchFromDB(string keyword)
        {
            string sql = @"
SELECT Name, Author, Type, Introduction 
FROM book 
WHERE
    (
    Name LIKE @keyword 
    OR Author LIKE @keyword 
    OR Type LIKE @keyword
    )
    AND Lend_Status = 'Save'
LIMIT 5;
";

            DataTable dt = _mysqlconnect.ExecuteQuery(sql, MySQLConnect.Param("@keyword", "%" + keyword + "%"));
            if (dt.Rows.Count == 0) return "无匹配书籍";
            // 拼接图书信息
            StringBuilder Stringb = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                Stringb.AppendLine($"《{row["Name"]}》");
                Stringb.AppendLine($"作者：{row["Author"]}");
                Stringb.AppendLine($"简介：{row["Introduction"]}\r\n");
            }
            return Stringb.ToString();
        }

        /// 生成AI回复，只能使用数据库真实图书，禁止AI自创书籍
        private async Task<string> GenerateSafeReply(string bookList, string userMsg)
        {
            string prompt = $@"
请你用自然、友好、流畅的语气回复用户。
【注意！以下是铁律，违反会导致严重错误！】
1. 你**只能使用下面已经给出的书籍信息**
2. **绝对不能新增任何书名、任何作者、任何书籍**
3. **不能添加库里没有的书**
4. 只需要把给出的书用自然的话讲一遍
5. 不许自己创作书籍！

=====================
【馆内真实藏书】
{bookList}
=====================

用户需求：{userMsg}

你的回复（只能用上面的书，不许加书）：
";

            var req = new
            {
                model = "qwen:7b",
                prompt = prompt,
                stream = false,
                options = new { num_predict = 500 },
                temperature = 0.1f // 温度设为最低，让AI更严谨、不随意发挥
            };

            string json = JsonConvert.SerializeObject(req);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            // 发送请求并获取回复
            var resp = await _httpClient.PostAsync(AppConfig.OllamaEndpoint, content);
            dynamic res = JsonConvert.DeserializeObject(await resp.Content.ReadAsStringAsync());
            // 返回最终回复给用户界面
            return res.response.ToString();
        }
    }
}