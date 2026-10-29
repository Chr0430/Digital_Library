using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Digital_Library
{
    //搜索页面的图书卡片
    public partial class BookCard : UserControl
    {
        public int BookID { get; private set; }// 书籍ID
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享图片路径
        public event EventHandler<int> BookClicked;//点击事件

        public BookCard()
        {
            InitializeComponent();
            this.Margin = new Padding(0, 0, 0, 0); // 卡片间距

            //给两个卡片之间添加分割线
            Divider();
        }

        /// <summary>
        /// 绑定书籍数据到卡片
        /// </summary>
        public void BindBookData(Book book)
        {
            if (book == null) return;
            BookID = book.ID;
            BookName.Text = book.BookName;
            Author.Text = $"作者：{book.Author}";

            // 加载书籍封面图片
            if (!string.IsNullOrEmpty(book.CoverImage))
            {
                try
                {
                    string fullCoverPath = Path.Combine(_shareBasePath, book.CoverImage);//拼接共享路径和图片名
                    fullCoverPath = fullCoverPath.Replace('/', '\\'); // 统一路径分隔符
                    if (File.Exists(fullCoverPath))//检查图片是否存在
                    {
                        // 深拷贝图片避免锁定文件
                        using (var bmp = new Bitmap(fullCoverPath))
                        {
                            Cover.Image = new Bitmap(bmp);
                        }
                    }
                    else
                    {
                        Cover.Image = null; // 无图片时置空
                    }
                }
                catch
                {
                    Cover.Image = null; // 加载失败置空
                }
            }
        }

        // 封面、书名点击触发跳转事件
        private void Book_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, BookID);
        }

        //给两个卡片之间添加分割线
        private void Divider()
        {
            Label divider = new Label();
            divider.Name = "cardDivider";
            divider.Height = 1; //线的高度
            divider.BackColor = Color.LightGray; //线的颜色
            divider.Width = this.Width - 20; // 宽度适配卡片
            divider.Location = new Point(10, this.Height - 10); //位置卡片底部偏上10px
            divider.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom; //自适应宽度
            this.Controls.Add(divider);
        }
    }
}