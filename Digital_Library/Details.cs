using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Digital_Library
{
    //书籍详情页面设计
    public partial class Details : Form
    {
        private Navigation _parentForm;//绑定父页面
        public string BookID = "";//书籍ID
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径
        private int status = 0;//设置全局变量，状态值为0则该书籍在图书馆中，状态值为1则该书籍被借出

        public Details(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";
            Cover.SizeMode = PictureBoxSizeMode.Zoom;// 初始化自适应图片
            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();
            Search_Administrator();
        }

        /// <summary>
        /// 通过书籍ID查找书籍信息
        /// </summary>
        /// <param name="inputBookID">输入的书籍ID</param>
        public void LoadBookByID(string inputBookID)
        {
            BookID = inputBookID?.Trim() ?? "";//去掉空格，避免匹配失败
            if (string.IsNullOrEmpty(BookID))
            {
                MessageBox.Show("书籍ID不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BookName.Text = "";
                return;
            }
            // 执行查询书籍信息和封面图片
            Load_Book(null, null);
            Load_Cover(null, null);
        }

        /// <summary>
        /// 加载书籍信息
        /// </summary>
        private void Load_Book(object sender, EventArgs e)
        {
            try
            {
                //测试连接是否可用
                if (!_mysqlconnect.TestConnection())
                {
                    MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //执行查询操作，展示结果到对应位置
                string querySql = "SELECT * FROM book WHERE ID = @bookId";
                DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@bookId", BookID));//查询结果为DataTable类型
                if (result.Rows.Count > 0)
                {
                    string bookName = result.Rows[0]["Name"]?.ToString() ?? "未知书名";
                    string bookNameEN = result.Rows[0]["Name_EN"]?.ToString() ?? "未知英文书名";
                    string bookAuthor = result.Rows[0]["Author"]?.ToString() ?? "未知作者";
                    string authorNationality = result.Rows[0]["Nationality"]?.ToString() ?? "未知国籍";
                    string publicationDate = result.Rows[0]["Publication_Date"]?.ToString() ?? "未知出版时间";
                    string bookType = result.Rows[0]["Type"]?.ToString() ?? "未知种类";
                    string bookIntroduction = result.Rows[0]["Introduction"]?.ToString() ?? "未知简介";
                    if (result.Rows[0]["Lend_Status"]?.ToString() == "Lend"|| result.Rows[0]["Lend_Status"]?.ToString() == "Lend_CBC")//如果该书籍借出把状态值变为1
                    {
                        status = 1;
                    }
                    
                    BookName.Text = bookName;
                    BookNameEN.Text = bookNameEN;
                    BookAuthor.Text = bookAuthor;
                    AuthorNationality.Text = authorNationality;
                    PublicationDate.Text = publicationDate;
                    BookType.Text = bookType;
                    Introduction.Text = "    "+bookIntroduction;
                }
                else
                {
                    BookName.Text = BookNameEN.Text = BookAuthor.Text = AuthorNationality.Text = 
                        PublicationDate.Text = BookType.Text = Introduction.Text = "未找到该书籍";
                }
            }
            catch (Exception ex)// 捕获所有异常提示操作失败
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 加载书籍封面图片
        /// </summary>
        private void Load_Cover(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT cover FROM book WHERE ID = @bookId;";//搜索书籍封面图片名
                DataTable dt = _mysqlconnect.ExecuteQuery(sql, MySQLConnect.Param("@bookId", BookID));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"未找到ID为 {BookID} 的图书记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cover.Image = null;
                    return;
                }

                //提取图片文件名
                object coverObj = dt.Rows[0]["cover"];//提取书籍封面图片名
                //数据库中Cover为空时返回
                if (coverObj == DBNull.Value || string.IsNullOrEmpty(coverObj.ToString().Trim()))
                {
                    MessageBox.Show($"ID为 {BookID} 的图书无封面文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cover.Image = null;
                    return;
                }
                string imgFileName = coverObj.ToString().Trim();//转换成String

                //拼接完整图片共享路径
                string fullSharePath = Path.Combine(_shareBasePath, imgFileName);
                // 替换路径分隔符为UNC格式（避免/和\混用）
                fullSharePath = fullSharePath.Replace('/', '\\');

                //检查共享路径是否可访问
                if (!Directory.Exists(_shareBasePath))
                {
                    MessageBox.Show($"图片目录不可用：{_shareBasePath}\n请检查该目录是否存在；如需指定位置，请在 App.config 的 ImageFolder 中填写路径（留空时自动在程序目录上层查找 Digital_Library_Picture）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cover.Image = null;
                    return;
                }

                //加载共享路径图片
                LoadImageFromSharePath(fullSharePath);

                
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"加载失败：图片文件不存在【{ex.FileName}】", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cover.Image = null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("加载失败：无读取图片目录的权限！\n请检查该目录的读取权限。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cover.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cover.Image = null;
            }
        }

        // 共享路径图片加载
        private void LoadImageFromSharePath(string fullSharePath)
        {
            if (string.IsNullOrEmpty(fullSharePath))
                throw new ArgumentNullException("共享图片路径不能为空");

            // UNC路径不使用Path.GetFullPath（避免解析错误）
            if (!File.Exists(fullSharePath))
            {
                throw new FileNotFoundException("共享图片文件不存在", fullSharePath);
            }

            // 加载图片
            using (var bmp = new Bitmap(fullSharePath))
            {
                // 深拷贝避免共享文件被锁定
                Cover.Image = new Bitmap(bmp);
            }
        }

        private void Search_Administrator()
        {
            string querySql = "SELECT * FROM Administrator WHERE UserName = @userName";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", _parentForm.username));//查询结果为DataTable类型
            if (result.Rows.Count > 0)
            {
                Introduction_Change.Visible = true;
                Lend.Visible = false;
                Introduction.ReadOnly = false;
            }
        }

        //查询书籍存放信息
        private void Search_Click(object sender, EventArgs e)
        {
            //执行查询book表操作
            string querySql = "SELECT * FROM book WHERE ID = @bookId";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@bookId", BookID));//查询结果为DataTable类型
            string bookSavePlace = "存放地点未收录";
            string bookLendStatus = "借出状态未收录";
            string bookLendDuration = "归还时间未收录";
            if (result.Rows.Count > 0)
            {
                //如果数据库字段为空则显示默认值，非空则转大写统一判断
                bookLendStatus = result.Rows[0]["Lend_Status"] == DBNull.Value
                    ? bookLendStatus
                    : result.Rows[0]["Lend_Status"].ToString().Trim().ToUpper();

                //如果数据库字段为空则显示默认值
                bookLendDuration = result.Rows[0]["Return_Time"] == DBNull.Value
                    ? bookLendDuration
                    : result.Rows[0]["Return_Time"].ToString().Trim();

                //如果数据库字段为空则显示默认值
                bookSavePlace = result.Rows[0]["Place"] == DBNull.Value
                    ? bookSavePlace
                    : result.Rows[0]["Place"].ToString().Trim();
            }

            if(bookLendStatus == "LEND"|| bookLendStatus == "LEND_CBC")
            {
                MessageBox.Show("该书籍已被借出，预计于" + bookLendDuration + "归还", "查找结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("该书籍存放于图书馆" + bookSavePlace, "查找结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Lend_Click(object sender, EventArgs e)
        {
            if(_parentForm.username== "未登录")
            {
                MessageBox.Show("请先登录自己的账号！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //执行查询reader表
            string querySql = "SELECT * FROM reader WHERE UserName = @userName";
            int number = 0;
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", _parentForm.username));//查询结果为DataTable类型
            if (result.Rows.Count > 0)
            {
                int.TryParse(result.Rows[0]["Lend_Number"].ToString(), out number);
            }
            else
            {
                MessageBox.Show("您不是读者身份！无法借阅！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //借阅上限 3 本，用 >= 判断，避免 Lend_Number 异常大于 3 时绕过限制
            if (number >= 3)
            {
                MessageBox.Show("您的借书数量已达到上限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (status == 0)
            {
                _parentForm.OpenLendBook(BookID); // 调用父窗体的OpenLendBook方法打开借阅书籍页面
            }
            else if(status == 1)
            {
                MessageBox.Show("该书籍已被借出，正在打开云桥连页面！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.OpenCloudBridgeConnect(BookName.Text); // 调用父窗体的OpenCloudBridgeConnect方法打开云桥连页面
            }
        }

        private void Introduction_Change_Click(object sender, EventArgs e)
        {
            string intro = Introduction.Text.Trim();
            string sql = @"
                        UPDATE book 
                        SET Introduction = @introduction
                        WHERE ID = @bookId";

            _mysqlconnect.ExecuteNonQuery(sql,
                MySQLConnect.Param("@introduction", intro),
                MySQLConnect.Param("@bookId", BookID));
            MessageBox.Show("所有修改已保存！", "成功");
        }
    }
}
