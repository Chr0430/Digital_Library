using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library
{
    //搜索页面设计
    public partial class Search : Form
    {
        private Navigation _parentForm;//绑定父页面
        public string SearchData = "";//搜索内容
        private int _currentPage = 1; //当前页码
        private int _pageSize = 4;    //每页显示4本书
        private int _totalPages = 0;  //总页数
        private MySQLConnect _mysqlconnect;
        private readonly string _shareBasePath = AppConfig.ImageFolder;

        public Search(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None;//无边框
            this.ControlBox = false;
            this.Text = "";

            //初始化MySQL数据库连接
            _mysqlconnect = new MySQLConnect();


            // 绑定分页按钮点击事件
            BindPaginationButtonEvents();
            // 绑定文本框回车键事件
            searchbox.KeyDown += SearchBox_KeyDown;
        }

        /// <summary>
        /// 加载搜索内容到搜索框
        /// </summary>
        public void ChangeSearchBox()
        {
            string defaultTip = " 输入书籍名/作者/国籍进行搜索";
            if (SearchData == defaultTip)//清除提示语
            {
                SearchData = "";
            }
            searchbox.ForeColor = Color.Black;
            searchbox.Text = SearchData;
            LoadBooksByCategory(SearchData, _currentPage);
        }

        /// <summary>
        /// 模糊搜索，支持书名、作者、类型任意匹配
        /// </summary>
        /// <param name="searchKey">搜索关键词（书名/作者/类型）</param>
        /// <param name="pageIndex">当前页码</param>
        private void LoadBooksByCategory(string searchKey, int pageIndex)
        {
            try
            {
                if (!_mysqlconnect.TestConnection())
                {
                    MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //处理搜索关键词，去除空格
                string safeSearchKey = searchKey?.Trim() ?? "";
                //模糊搜索的通配符，% 匹配任意字符
                string searchPattern = $"%{safeSearchKey}%";

                //计算总页数
                string countSql = @"
                    SELECT COUNT(*) FROM book 
                    WHERE (Name LIKE @keyword 
                    OR Author LIKE @keyword 
                    OR Type LIKE @keyword
                    OR Nationality LIKE @keyword)
                    AND Lend_Status != 'Lend_CBC'
                ";
                //调试输出SQL语句，方便排查
                System.Diagnostics.Debug.WriteLine($"统计总数的SQL：{countSql}");
                int totalCount = Convert.ToInt32(_mysqlconnect.ExecuteQuery(countSql, MySQLConnect.Param("@keyword", searchPattern)).Rows[0][0]);
                _totalPages = (int)Math.Ceiling((double)totalCount / _pageSize);//总页数

                //分页查询当前页数据
                int offset = (pageIndex - 1) * _pageSize;//偏移量
                string bookSql = @"
                    SELECT ID, Name, Author, cover FROM book 
                    WHERE (Name LIKE @keyword 
                    OR Author LIKE @keyword 
                    OR Type LIKE @keyword
                    OR Nationality LIKE @keyword)
                    AND Lend_Status != 'Lend_CBC'
                    LIMIT @offset, @pageSize
                ";
                System.Diagnostics.Debug.WriteLine($"分页查询的SQL：{bookSql}");
                DataTable bookDt = _mysqlconnect.ExecuteQuery(bookSql,
                    MySQLConnect.Param("@keyword", searchPattern),
                    MySQLConnect.Param("@offset", offset),
                    MySQLConnect.Param("@pageSize", _pageSize));

                //加载渲染书籍卡片
                RenderBookCards(ConvertToBookList(bookDt));

                //更新分页按钮状态
                UpdatePaginationButtonState();
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
                books.Add(new Book
                {
                    ID = Convert.ToInt32(row["ID"]),
                    BookName = row["Name"]?.ToString() ?? "未知书名",
                    Author = row["Author"]?.ToString() ?? "未知作者",
                    CoverImage = row["Cover"]?.ToString() ?? ""
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
                BookCard card = new BookCard();
                card.BindBookData(book);
                card.Margin = new Padding(30, 20, 30, 20);

                card.BookClicked += (s, BookID) =>
                {
                    _parentForm.OpenDetails(BookID.ToString());
                };
                flpBooks.Controls.Add(card);
            }
            flpBooks.AutoScrollPosition = new Point(0, 0);
        }


        //设置分页按钮
        private void BindPaginationButtonEvents()
        {
            //上一页点击
            btnPrev.Click += (s, e) =>
            {
                _currentPage--;
                LoadBooksByCategory(SearchData, _currentPage);
            };

            //下一页点击
            btnNext.Click += (s, e) =>
            {
                _currentPage++;
                LoadBooksByCategory(SearchData, _currentPage);
            };

            //当前页码不可点击
            btnCurrent.Enabled = false;
        }

        //随着换页更新按钮
        private void UpdatePaginationButtonState()
        {
            //更新页码文本
            btnCurrent.Text = _currentPage.ToString();
            //上一页：当前页>1才启用
            btnPrev.Enabled = _currentPage > 1;
            //下一页：当前页<总页数才启用
            btnNext.Enabled = _currentPage < _totalPages;
        }

        //点击搜索按钮触发搜索效果
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //SearchData = searchbox.Text;
            //_currentPage = 1;//搜索后页面重置回第一页
            //ChangeSearchBox();
            _parentForm.OpenSearch(searchbox.Text);
        }

        //在文本框输入时点击回车触发搜索效果
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            //判断是否按下回车键
            if (e.KeyCode == Keys.Enter)
            {
                //手动触发搜索按钮
                SearchButton_Click(sender, e);
                //阻止回车键的默认行为
                e.SuppressKeyPress = true;
            }
        }

    }
}