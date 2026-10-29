using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Digital_Library
{
    //主页页面设计
    public partial class HomePage : Form
    {
        public string BookID = "";//书籍ID
        private Navigation _parentForm;
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径


        public HomePage(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;//绑定父页面，便于调用父页面函数
            this.FormBorderStyle = FormBorderStyle.None; // 设置无边框
            this.ControlBox = false;
            this.Text = "";
            Cover.SizeMode = PictureBoxSizeMode.Zoom;// 初始化自适应图片

            // 绑定文本框回车键事件
            searchbox.KeyDown += SearchBox_KeyDown;

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            LoadBookCard1();//加载新书速递书籍卡片
            LoadBookCard2();//加载经典名著书籍卡片

            SetGradientBackground(pictureBox3);//设置标题栏渐变效果
            SetGradientBackground(pictureBox4);//设置标题栏渐变效果
            label2.Paint += label_Paint;//设置标题渐变效果
            label3.Paint += label_Paint;//设置标题渐变效果

            GetARandomBook();//随机加载一本书
        }

        //点击搜索栏时清除提示内容
        private void Searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == " 输入书籍名/作者/国籍进行搜索")
            {
                searchbox.Text = "";
                searchbox.ForeColor = Color.Black;
            }
        }

        //点击搜索按钮跳转搜索界面
        private void Search_Click(object sender, EventArgs e)
        {
            _parentForm.OpenSearch(searchbox.Text); // 调用父窗体的OpenSearch方法打开搜索页面
        }

        //在文本框输入时点击回车触发搜索效果
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            // 判断是否按下回车键
            if (e.KeyCode == Keys.Enter)
            {
                // 手动触发搜索按钮
                Search_Click(sender, e);
                // 阻止回车键的默认行为
                e.SuppressKeyPress = true;
            }
        }

        #region 加载新书速递
        /// <summary>
        /// 加载书籍卡片
        /// </summary>
        private void LoadBookCard1()
        {
            try
            {
                if (!_mysqlconnect.TestConnection())
                {
                    MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //查询书籍数据（新书速递：取出版日期最晚的 10 本，再从中随机挑 4 本展示）
                //Publication_Date 是 varchar 且长度不统一（有的只记到月、有的含日），
                //直接按字符串排序会出现「同月内 1 月排在 10 月之后」这类错误，因此先转成日期再排序
                string bookSql = @"
                    SELECT ID, Name, Author, Cover FROM (
                        SELECT ID, Name, Author, Cover, STR_TO_DATE(Publication_Date, '%Y-%c-%e') AS PubDate
                        FROM book
                        WHERE Lend_Status = 'Save'
                        ORDER BY PubDate DESC
                        LIMIT 10
                    ) AS Newest
                    ORDER BY RAND() LIMIT 4; ";
                DataTable bookDt = _mysqlconnect.ExecuteQuery(bookSql);
                //加载渲染书籍卡片
                RenderBookCards1(ConvertToBookList1(bookDt));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //加载书籍卡片
        private List<Book> ConvertToBookList1(DataTable dt)
        {
            List<Book> books = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                books.Add(new Book
                {
                    ID = Convert.ToInt32(row["ID"]),
                    BookName = row["Name"]?.ToString() ?? "未知书名",
                    Author = row["Author"]?.ToString() ?? "未知作者",
                    CoverImage = row["cover"]?.ToString() ?? "",
                });
            }
            return books;
        }

        //渲染书籍卡片
        private void RenderBookCards1(List<Book> books)
        {
            flpBooks.Controls.Clear();
            foreach (var book in books)
            {
                BookCard card = new BookCard();
                card.BindBookData(book);
                card.Margin = new Padding(20, 0, 20, 0);

                card.BookClicked += (s, BookID) =>
                {
                    _parentForm.OpenDetails(BookID.ToString());
                };
                flpBooks.Controls.Add(card);
            }
            flpBooks.AutoScrollPosition = new Point(0, 0);
        }
        #endregion


        #region 加载经典名著
        /// <summary>
        /// 加载借出书籍卡片
        /// </summary>
        private void LoadBookCard2()
        {
            try
            {
                if (!_mysqlconnect.TestConnection())
                {
                    MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //查询书籍数据（经典名著：只取在馆可借的书，保证卡片点进去都能借）
                string bookSql = @"
                    SELECT ID, Name, Author, Cover FROM book 
                    WHERE (Type = '经典' OR Type = '小说' OR Type = '散文') AND Lend_Status = 'Save'
                    ORDER BY RAND()  LIMIT 4; ";
                DataTable bookDt = _mysqlconnect.ExecuteQuery(bookSql);
                //加载渲染书籍卡片
                RenderBookCards2(ConvertToBookList2(bookDt));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //加载书籍卡片
        private List<Book> ConvertToBookList2(DataTable dt)
        {
            List<Book> books = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                books.Add(new Book
                {
                    ID = Convert.ToInt32(row["ID"]),
                    BookName = row["Name"]?.ToString() ?? "未知书名",
                    Author = row["Author"]?.ToString() ?? "未知作者",
                    CoverImage = row["cover"]?.ToString() ?? "",
                });
            }
            return books;
        }

        //渲染书籍卡片
        private void RenderBookCards2(List<Book> books)
        {
            flpBookss.Controls.Clear();
            foreach (var book in books)
            {
                BookCard card = new BookCard();
                card.BindBookData(book);
                card.Margin = new Padding(20, 0, 20, 0);

                card.BookClicked += (s, BookID) =>
                {
                    _parentForm.OpenDetails(BookID.ToString());
                };
                flpBookss.Controls.Add(card);
            }
            flpBookss.AutoScrollPosition = new Point(0, 0);
        }
        #endregion


        #region 标题栏美化渐变效果
        //设置标题栏PictureBox渐变效果
        private void SetGradientBackground(PictureBox pb)
        {
            pb.Paint += (sender, e) =>
            {
                Rectangle rect = pb.ClientRectangle;

                Color startColor = SystemColors.ActiveCaption;
                //Color endColor = Colors.ActiveBorder;//深灰
                //Color startColor = Color.FromName("Linen");Highlight
                Color endColor = SystemColors.GradientInactiveCaption;

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    startColor,
                    endColor,
                    LinearGradientMode.Horizontal)) // 水平渐变
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            };
        }

        //设置标题渐变效果
        private void label_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;

            //背景渐变颜色
            Color start = SystemColors.ActiveCaption;
            Color end = SystemColors.GradientInactiveCaption;

            //整个大背景的区域
            Rectangle fullBgRect = new Rectangle(0, 745, 1566, 64);
            //Label自己的区域
            Rectangle labelRect = lbl.ClientRectangle;

            //计算在大背景上的偏移比例
            float ratioStart = (float)lbl.Left / fullBgRect.Width;
            float ratioEnd = (float)(lbl.Left + lbl.Width) / fullBgRect.Width;

            //计算Label应该使用的起始结束颜色
            Color labelStart = InterpolateColor(start, end, ratioStart);
            Color labelEnd = InterpolateColor(start, end, ratioEnd);

            //绘制内部渐变
            using (LinearGradientBrush brush = new LinearGradientBrush(
                labelRect, labelStart, labelEnd, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, labelRect);
            }

            //重新绘制文字
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, labelRect, lbl.ForeColor);
        }

        //颜色插值工具（计算两个颜色之间的过渡色）
        private Color InterpolateColor(Color a, Color b, float p)
        {
            int r = (int)(a.R + (b.R - a.R) * p);
            int g = (int)(a.G + (b.G - a.G) * p);
            int bv = (int)(a.B + (b.B - a.B) * p);
            return Color.FromArgb(r, g, bv);
        }

        #endregion

        //随机加载一本书（只从在馆可借的书里挑）
        public void GetARandomBook()
        {
            string querySql = "SELECT ID FROM book WHERE Lend_Status = 'Save' ORDER BY RAND() LIMIT 1";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql);//查询结果为DataTable类型
            if (result.Rows.Count == 0)//全部借出时不做展示，避免取空崩溃
            {
                BookName.Text = "";
                return;
            }
            string bookID = result.Rows[0]["ID"]?.ToString();
            LoadBookByID(bookID);
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
                    string bookAuthor = result.Rows[0]["Author"]?.ToString() ?? "未知作者";
                    string authorNationality = result.Rows[0]["Nationality"]?.ToString() ?? "未知国籍";
                    string bookType = result.Rows[0]["Type"]?.ToString() ?? "未知种类";
                    string bookIntroduction = result.Rows[0]["Introduction"]?.ToString() ?? "未知简介";

                    BookName.Text = bookName;
                    BookAuthor.Text = bookAuthor;
                    AuthorNationality.Text = authorNationality;
                    BookType.Text = bookType;
                    Introduction.Text = "    " + bookIntroduction;
                }
                else
                {
                    BookName.Text = BookAuthor.Text = AuthorNationality.Text = BookType.Text = Introduction.Text = "未找到该书籍";
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

        //查看详情按钮，跳转到书籍详情页面
        private void Detail_Click(object sender, EventArgs e)
        {
            _parentForm.OpenDetails(BookID);
        }

        //换一本书按钮，重新随机加载一本书
        private void Change_Click(object sender, EventArgs e)
        {
            GetARandomBook();
        }

        //切换功能面板按钮
        private void FunctionPanel_Click(object sender, EventArgs e)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
            }
            else if (panel.Visible == true)
            {
                panel.Visible = false;
            }
        }

        //功能面板个人中心按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if(_parentForm.Adm == 0)
            {
                _parentForm.OpenReaderCenter();
            }
            if (_parentForm.Adm == 1)
            {
                _parentForm.OpenAdministratorCenter();
            }
        }

        //功能面板活动中心按钮
        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.OpenActivityCenter();
        }

        //功能面板AI推荐数据按钮
        private void button3_Click(object sender, EventArgs e)
        {
            _parentForm.OpenAIBook();
        }

        //功能面板云桥连功能按钮
        private void button4_Click(object sender, EventArgs e)
        {
            _parentForm.OpenCloudBridgeConnect("");
        }
    }
}
