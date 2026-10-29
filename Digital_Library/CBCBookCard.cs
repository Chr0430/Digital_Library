using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Digital_Library
{
    //云桥连搜索页面的图书卡片
    public partial class CBCBookCard : UserControl
    {
        private PictureBox Cover;
        private Label Type;
        private Label Author;
        private Label BookName;
        private Label PublicationDate;
        private Label label1;

        public int BookID { get; private set; }// 书籍ID
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享图片路径
        public event EventHandler<int> BookClicked;//点击事件

        public CBCBookCard()
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
            Type.Text = $"种类：{book.Type}";
            PublicationDate.Text = $"出版时间：{book.PublicationDate}";

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

            //让卡片内所有子控件点击都触发跳转
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click -= Book_Click;//避免重复绑定，先解除绑定
                ctrl.Click += Book_Click;
                ctrl.Cursor = Cursors.Hand;
            }
        }

        //卡片点击触发跳转事件
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

        private void InitializeComponent()
        {
            this.Cover = new System.Windows.Forms.PictureBox();
            this.Type = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.PublicationDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // Cover
            // 
            this.Cover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cover.Location = new System.Drawing.Point(33, 4);
            this.Cover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(112, 153);
            this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cover.TabIndex = 5;
            this.Cover.TabStop = false;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type.Location = new System.Drawing.Point(179, 126);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(70, 31);
            this.Type.TabIndex = 8;
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Author.Location = new System.Drawing.Point(179, 78);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(94, 31);
            this.Author.TabIndex = 6;
            this.Author.Text = "Author";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Cursor = System.Windows.Forms.Cursors.Default;
            this.BookName.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(179, 19);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(181, 34);
            this.BookName.TabIndex = 7;
            this.BookName.Text = "BookName";
            this.BookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PublicationDate
            // 
            this.PublicationDate.AutoSize = true;
            this.PublicationDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublicationDate.Location = new System.Drawing.Point(403, 126);
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.Size = new System.Drawing.Size(195, 31);
            this.PublicationDate.TabIndex = 9;
            this.PublicationDate.Text = "PublicationDate";
            this.PublicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(403, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "云桥连借阅";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBCBookCard
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PublicationDate);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Cover);
            this.Name = "CBCBookCard";
            this.Size = new System.Drawing.Size(734, 177);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}