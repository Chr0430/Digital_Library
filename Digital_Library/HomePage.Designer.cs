using System.Windows.Forms;

namespace Digital_Library
{
    partial class HomePage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.search = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpBookss = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Detail = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AuthorNationality = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Introduction = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.Label();
            this.BookType = new System.Windows.Forms.Label();
            this.FunctionPanel = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(1607, 96);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(113, 48);
            this.search.TabIndex = 0;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchbox
            // 
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.searchbox.Location = new System.Drawing.Point(873, 96);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(693, 48);
            this.searchbox.TabIndex = 1;
            this.searchbox.Text = " 输入书籍名/作者/国籍进行搜索";
            this.searchbox.Click += new System.EventHandler(this.Searchbox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2586, 220);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(717, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "数字图书馆";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(709, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(0, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1566, 94);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "新书速递";
            // 
            // flpBooks
            // 
            this.flpBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBooks.AutoScroll = true;
            this.flpBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBooks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpBooks.Location = new System.Drawing.Point(92, 229);
            this.flpBooks.Margin = new System.Windows.Forms.Padding(0);
            this.flpBooks.Name = "flpBooks";
            this.flpBooks.Padding = new System.Windows.Forms.Padding(50, 50, 50, 20);
            this.flpBooks.Size = new System.Drawing.Size(1474, 549);
            this.flpBooks.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 739);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 41;
            this.label3.Text = "经典名著";
            // 
            // flpBookss
            // 
            this.flpBookss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBookss.AutoScroll = true;
            this.flpBookss.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBookss.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpBookss.Location = new System.Drawing.Point(92, 758);
            this.flpBookss.Margin = new System.Windows.Forms.Padding(0);
            this.flpBookss.Name = "flpBookss";
            this.flpBookss.Padding = new System.Windows.Forms.Padding(50, 50, 50, 20);
            this.flpBookss.Size = new System.Drawing.Size(1474, 543);
            this.flpBookss.TabIndex = 42;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(0, 725);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1566, 64);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(1559, 215);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 1106);
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // Detail
            // 
            this.Detail.FlatAppearance.BorderSize = 0;
            this.Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detail.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Detail.Location = new System.Drawing.Point(1790, 961);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(187, 110);
            this.Detail.TabIndex = 45;
            this.Detail.Text = "查看详情";
            this.Detail.UseVisualStyleBackColor = true;
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // Change
            // 
            this.Change.FlatAppearance.BorderSize = 0;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Change.Location = new System.Drawing.Point(2223, 961);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(187, 110);
            this.Change.TabIndex = 46;
            this.Change.Text = "换一本书";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Cover
            // 
            this.Cover.Location = new System.Drawing.Point(1684, 294);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(251, 329);
            this.Cover.TabIndex = 4;
            this.Cover.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1659, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 47;
            this.label4.Text = "今日推荐";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1678, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 36);
            this.label6.TabIndex = 60;
            this.label6.Text = "书籍简介：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(609, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 44);
            this.label7.TabIndex = 56;
            // 
            // AuthorNationality
            // 
            this.AuthorNationality.AutoSize = true;
            this.AuthorNationality.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorNationality.Location = new System.Drawing.Point(2077, 520);
            this.AuthorNationality.Name = "AuthorNationality";
            this.AuthorNationality.Size = new System.Drawing.Size(287, 33);
            this.AuthorNationality.TabIndex = 53;
            this.AuthorNationality.Text = "AuthorNationality";
            // 
            // BookAuthor
            // 
            this.BookAuthor.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookAuthor.Location = new System.Drawing.Point(2077, 396);
            this.BookAuthor.MaximumSize = new System.Drawing.Size(300, 1000);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(300, 90);
            this.BookAuthor.TabIndex = 51;
            this.BookAuthor.Text = "BookAuthor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(1964, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 33);
            this.label10.TabIndex = 50;
            this.label10.Text = "作者：";
            // 
            // Introduction
            // 
            this.Introduction.BackColor = System.Drawing.SystemColors.Window;
            this.Introduction.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Introduction.Location = new System.Drawing.Point(1684, 692);
            this.Introduction.Multiline = true;
            this.Introduction.Name = "Introduction";
            this.Introduction.ReadOnly = true;
            this.Introduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Introduction.Size = new System.Drawing.Size(840, 230);
            this.Introduction.TabIndex = 49;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(1963, 306);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(193, 36);
            this.BookName.TabIndex = 48;
            this.BookName.Text = "BookName";
            // 
            // BookType
            // 
            this.BookType.AutoSize = true;
            this.BookType.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookType.Location = new System.Drawing.Point(2252, 520);
            this.BookType.Name = "BookType";
            this.BookType.Size = new System.Drawing.Size(143, 33);
            this.BookType.TabIndex = 62;
            this.BookType.Text = "BookType";
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.FlatAppearance.BorderSize = 0;
            this.FunctionPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunctionPanel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FunctionPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FunctionPanel.Location = new System.Drawing.Point(2002, 1107);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(187, 110);
            this.FunctionPanel.TabIndex = 63;
            this.FunctionPanel.Text = "功能面板";
            this.FunctionPanel.UseVisualStyleBackColor = true;
            this.FunctionPanel.Click += new System.EventHandler(this.FunctionPanel_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureBox7);
            this.panel.Controls.Add(this.pictureBox6);
            this.panel.Controls.Add(this.button4);
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.button1);
            this.panel.Location = new System.Drawing.Point(1778, 692);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(644, 391);
            this.panel.TabIndex = 0;
            this.panel.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox7.Location = new System.Drawing.Point(317, 25);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 329);
            this.pictureBox7.TabIndex = 66;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox6.Location = new System.Drawing.Point(52, 187);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(537, 10);
            this.pictureBox6.TabIndex = 65;
            this.pictureBox6.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.Location = new System.Drawing.Point(368, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 110);
            this.button4.TabIndex = 64;
            this.button4.Text = "云桥连服务";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.Location = new System.Drawing.Point(90, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 110);
            this.button3.TabIndex = 64;
            this.button3.Text = "AI推荐书籍";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.Location = new System.Drawing.Point(368, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 110);
            this.button2.TabIndex = 64;
            this.button2.Text = "活动中心";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Location = new System.Drawing.Point(90, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 110);
            this.button1.TabIndex = 64;
            this.button1.Text = "个人中心";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1964, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 64;
            this.label5.Text = "标签：";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2586, 1341);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FunctionPanel);
            this.Controls.Add(this.BookType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AuthorNationality);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.flpBookss);
            this.Controls.Add(this.flpBooks);
            this.Controls.Add(this.pictureBox5);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private FlowLayoutPanel flpBooks;
        private Label label3;
        private FlowLayoutPanel flpBookss;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button Detail;
        private Button Change;
        private PictureBox Cover;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label AuthorNationality;
        private Label BookAuthor;
        private Label label10;
        private TextBox Introduction;
        private Label BookName;
        private Label BookType;
        private Panel panel;
        private Button FunctionPanel;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}

