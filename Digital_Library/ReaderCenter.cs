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

namespace Digital_Library
{
    //读者中心页面设计
    public partial class ReaderCenter : Form
    {
        private Navigation _parentForm;//绑定父页面
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;//共享服务器路径

        public ReaderCenter(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";
            

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            LoadReader();//加载读者基本账号信息
            LoadBookCard();//加载书籍卡片
        }

        //加载读者信息
        public void LoadReader()
        {
            if (_parentForm.username == "未登录")
            {
                logout.Visible = false;//如果是未登录状态，显示前往登录按钮，退出登录按钮隐藏
                username.Text = status.Text = readerid.Text = lendnumber.Text = "未登录";
            }
            else
            {
                login.Visible = false;//如果是登录状态，显示退出登录按钮，前往登录按钮隐藏
                try
                {
                    //测试连接是否可用
                    if (!_mysqlconnect.TestConnection())
                    {
                        MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //执行查询reader表，展示结果到对应位置
                    string querySql = "SELECT * FROM reader WHERE UserName = @userName";
                    DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", _parentForm.username));//查询结果为DataTable类型
                    if (result.Rows.Count > 0)
                    {
                        string id = result.Rows[0]["ID"]?.ToString();
                        string number = result.Rows[0]["Lend_Number"]?.ToString();
                        readerid.Text = id;
                        username.Text = _parentForm.username;
                        status.Text = "正常登录";
                        lendnumber.Text = number;
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)// 捕获所有异常提示操作失败
                {
                    MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(lendnumber.Text == "未登录" || lendnumber.Text == "0")
            {
                NoBook.Visible = true;
            }
        }

        /// <summary>
        /// 加载借出书籍卡片
        /// </summary>
        private void LoadBookCard()
        {
            try
            {
                if (!_mysqlconnect.TestConnection())
                {
                    MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //查询书籍数据
                string bookSql = @"
                    SELECT ID, Name, Author, Cover, Type, Return_Time FROM book 
                    WHERE Lend_ID = @readerId";
                DataTable bookDt = _mysqlconnect.ExecuteQuery(bookSql, MySQLConnect.Param("@readerId", readerid.Text));
                //加载渲染书籍卡片
                RenderBookCards(ConvertToBookList(bookDt));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //加载书籍卡片
        private List<Book> ConvertToBookList(DataTable dt)
        {
            List<Book> books = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                //获取归还时间并转换为DateTime
                DateTime returnDate = DateTime.MinValue;
                if (row["Return_Time"] != DBNull.Value)
                {
                    //解析数据库中的归还时间
                    DateTime.TryParse(row["Return_Time"].ToString(), out returnDate);
                }

                //计算剩余天数
                int remainingDays = 0;
                if (returnDate != DateTime.MinValue)
                {
                    //计算归还日期 - 当前日期的天数差
                    TimeSpan diff = returnDate - DateTime.Now;
                    remainingDays = (int)Math.Ceiling(diff.TotalDays); //向上取整
                }

                books.Add(new Book
                {
                    ID = Convert.ToInt32(row["ID"]),
                    BookName = row["Name"]?.ToString() ?? "未知书名",
                    Author = row["Author"]?.ToString() ?? "未知作者",
                    CoverImage = row["cover"]?.ToString() ?? "",
                    Type = row["Type"]?.ToString() ?? "未知种类",
                    ReturnTime = returnDate != DateTime.MinValue
                        ? returnDate.ToString("yyyy-MM-dd") //归还日期
                        : "暂无归还时间",
                    RemainingTime = remainingDays
                });
            }
            return books;
        }

        //渲染书籍卡片
        private void RenderBookCards(List<Book> books)
        {
            flpBooks.Controls.Clear();
            foreach (var book in books)
            {
                LendBookCard card = new LendBookCard();
                card.BindBookData(book);
                card.Margin = new Padding(30, 10, 30, 10);

                card.BookClicked += (s, BookID) =>
                {
                    _parentForm.OpenDetails(BookID.ToString());
                };
                flpBooks.Controls.Add(card);
            }
            flpBooks.AutoScrollPosition = new Point(0, 0);
        }


        private void logout_Click(object sender, EventArgs e)//退出登录按钮
        {
            _parentForm.LogOut();
        }

        private void login_Click(object sender, EventArgs e)//前往登录按钮
        {
            _parentForm.OpenLogIn();
        }

        private void search_Click(object sender, EventArgs e)//前往借书按钮，跳转搜索页面
        {
            _parentForm.OpenSearch("");
        }

        private void submit_Click(object sender, EventArgs e)//提交建议功能
        {
            if (bookName.Text == ""&& author.Text == "")//都为空
            {
                MessageBox.Show("请输入建议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string Name = bookName.Text;
                string Author = author.Text;
                string Reader = username.Text;

                if (bookName.Text == "")//书名为空
                {
                    Name = "/";
                }
                if (author.Text == "")//作者为空
                {
                    Author = "/";
                }

                string sql = "INSERT INTO suggestion(Name, Author, Reader) VALUES (@name, @author, @reader)";

                _mysqlconnect.ExecuteNonQuery(sql,
                    MySQLConnect.Param("@name", Name),
                    MySQLConnect.Param("@author", Author),
                    MySQLConnect.Param("@reader", Reader));

                MessageBox.Show("提交成功！感谢你的建议", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookName.Clear();
                author.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"提交失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
