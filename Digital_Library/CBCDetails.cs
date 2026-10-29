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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Digital_Library
{
    //云桥连书籍详情页面设计
    public partial class CBCDetails : Form
    {
        private Navigation _parentForm;//绑定父页面
        public string BookID = "";//书籍ID
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径
        public string cover = "";//存放书籍封面图片名称
        public string bookIntroduction;//存放书籍简介

        public CBCDetails(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";
            Cover.SizeMode = PictureBoxSizeMode.Zoom;// 初始化自适应图片

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            Introduction.ReadOnly = true;    //简介文本框只读
            Introduction.TabStop = false;    //文本框得不到焦点

            // 禁止选择过去的日期
            LendTime.MinDate = DateTime.Now.Date;
            // 默认显示今天日期
            LendTime.Value = DateTime.Now.Date;
            // 设置显示格式
            LendTime.Format = DateTimePickerFormat.Custom;
            LendTime.CustomFormat = "yyyy-MM-dd";
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
                string querySql = "SELECT * FROM book_branch WHERE ID = @bookId";
                DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@bookId", BookID));//查询结果为DataTable类型
                if (result.Rows.Count > 0)
                {
                    string bookName = result.Rows[0]["Name"]?.ToString() ?? "未知书名";
                    string bookNameEN = result.Rows[0]["Name_EN"]?.ToString() ?? "未知英文书名";
                    string bookAuthor = result.Rows[0]["Author"]?.ToString() ?? "未知作者";
                    string authorNationality = result.Rows[0]["Nationality"]?.ToString() ?? "未知国籍";
                    string publicationDate = result.Rows[0]["Publication_Date"]?.ToString() ?? "未知出版时间";
                    string bookType = result.Rows[0]["Type"]?.ToString() ?? "未知种类";
                    bookIntroduction = result.Rows[0]["Introduction"]?.ToString() ?? "未知简介";
                    cover= result.Rows[0]["Cover"]?.ToString();

                    BookName.Text = bookName;
                    BookNameEN.Text = bookNameEN;
                    BookAuthor.Text = bookAuthor;
                    AuthorNationality.Text = authorNationality;
                    PublicationDate.Text = publicationDate;
                    BookType.Text = bookType;
                    Introduction.Text = "    " + bookIntroduction;
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
                string sql = "SELECT cover FROM book_branch WHERE ID = @bookId;";//搜索书籍封面图片名
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

        /// <summary>
        /// 点击借阅按钮
        /// </summary>
        private void Lend_Click(object sender, EventArgs e)
        {
            if (_parentForm.username == "未登录")//确保登录账号
            {
                MessageBox.Show("请先登录自己的账号！", "未登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //执行查询reader表
            string querySql = "SELECT * FROM reader WHERE UserName = @userName";
            int number = 0;
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", _parentForm.username));//查询结果为DataTable类型
            if (result.Rows.Count > 0)//查询借阅书籍数量
            {
                int.TryParse(result.Rows[0]["Lend_Number"].ToString(), out number);
            }
            else//登录完成但reader表中查询不到，即为管理员身份
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
            
            string ID = result.Rows[0]["ID"]?.ToString();//保存查询出的读者ID
            DateTime lendDate = LendTime.Value.Date;
            string lendTime = lendDate.ToString("yyyy-MM-dd");

            if (lendTime == "")//没有选择借阅时间
            {
                MessageBox.Show("请输入借阅时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //修改book_branch表中的数据
            string query = "UPDATE book_branch SET Lend_Status = 'Lend_CBC', Lend_ID = @lendId, " +
                           "Lend_Time = @lendTime, Return_Time = @returnTime WHERE ID = @bookId";
            _mysqlconnect.ExecuteNonQuery(query,
                MySQLConnect.Param("@lendId", ID),
                MySQLConnect.Param("@lendTime", DateTime.Now.ToString("yyyy-MM-dd")),
                MySQLConnect.Param("@returnTime", lendTime),
                MySQLConnect.Param("@bookId", BookID));

            string Name = BookName.Text + "(云桥连借阅)(未到)";
            //在book表中添加数据
            string queryy = "INSERT INTO book(Cover,Name,Name_EN,Author,Nationality,Publication_Date,Type,Introduction,Place,Lend_Status,Lend_ID,Lend_Time,Return_Time) " +
               "VALUES (@cover,@name,@nameEn,@author,@nationality,@publicationDate,@type,@introduction,'云桥连','Lend_CBC',@lendId,@lendTime,@returnTime)";
            _mysqlconnect.ExecuteNonQuery(queryy,
                MySQLConnect.Param("@cover", cover),
                MySQLConnect.Param("@name", Name),
                MySQLConnect.Param("@nameEn", BookNameEN.Text),
                MySQLConnect.Param("@author", BookAuthor.Text),
                MySQLConnect.Param("@nationality", AuthorNationality.Text),
                MySQLConnect.Param("@publicationDate", PublicationDate.Text),
                MySQLConnect.Param("@type", BookType.Text),
                MySQLConnect.Param("@introduction", bookIntroduction),
                MySQLConnect.Param("@lendId", ID),
                MySQLConnect.Param("@lendTime", DateTime.Now.ToString("yyyy-MM-dd")),
                MySQLConnect.Param("@returnTime", lendTime));

            //修改reader表中的借书数量
            string _query = "UPDATE reader SET Lend_Number = Lend_Number + 1 WHERE ID = @readerId";
            _mysqlconnect.ExecuteNonQuery(_query, MySQLConnect.Param("@readerId", ID));

            MessageBox.Show("借阅成功！将由管理员进行统一运送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _parentForm.CloseChildForm();//关闭借书页面
        }
    }
}
