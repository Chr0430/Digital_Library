namespace Digital_Library
{
    partial class ReaderCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderCenter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.readerid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lendnumber = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.flpBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.NoBook = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 1323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(103, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "数字图书馆";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(95, 100);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(147, 145);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 22;
            this.Logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "用户名：";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.Enabled = false;
            this.username.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(54, 359);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(249, 39);
            this.username.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "读者ID：";
            // 
            // readerid
            // 
            this.readerid.Enabled = false;
            this.readerid.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readerid.Location = new System.Drawing.Point(54, 517);
            this.readerid.Name = "readerid";
            this.readerid.ReadOnly = true;
            this.readerid.Size = new System.Drawing.Size(249, 39);
            this.readerid.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "账号状态：";
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.status.Location = new System.Drawing.Point(54, 684);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(249, 39);
            this.status.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 782);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "在借数量：";
            // 
            // lendnumber
            // 
            this.lendnumber.Enabled = false;
            this.lendnumber.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lendnumber.Location = new System.Drawing.Point(54, 861);
            this.lendnumber.Name = "lendnumber";
            this.lendnumber.ReadOnly = true;
            this.lendnumber.Size = new System.Drawing.Size(249, 39);
            this.lendnumber.TabIndex = 31;
            // 
            // login
            // 
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(28, 997);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(148, 85);
            this.login.TabIndex = 32;
            this.login.Text = "前往登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // search
            // 
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(155, 1131);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(148, 85);
            this.search.TabIndex = 33;
            this.search.Text = "前往借书";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logout.Location = new System.Drawing.Point(28, 997);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(148, 85);
            this.logout.TabIndex = 34;
            this.logout.Text = "退出登录";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // flpBooks
            // 
            this.flpBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBooks.AutoScroll = true;
            this.flpBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBooks.Location = new System.Drawing.Point(384, 130);
            this.flpBooks.Margin = new System.Windows.Forms.Padding(0);
            this.flpBooks.Name = "flpBooks";
            this.flpBooks.Padding = new System.Windows.Forms.Padding(50, 50, 50, 20);
            this.flpBooks.Size = new System.Drawing.Size(1173, 800);
            this.flpBooks.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(365, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 41);
            this.label6.TabIndex = 36;
            this.label6.Text = "在借书籍";
            // 
            // NoBook
            // 
            this.NoBook.AutoSize = true;
            this.NoBook.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoBook.Location = new System.Drawing.Point(600, 300);
            this.NoBook.Name = "NoBook";
            this.NoBook.Size = new System.Drawing.Size(234, 41);
            this.NoBook.TabIndex = 0;
            this.NoBook.Text = "暂无借阅记录";
            this.NoBook.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1557, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 41);
            this.label7.TabIndex = 37;
            this.label7.Text = "提出建议";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1749, 996);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(702, 41);
            this.label8.TabIndex = 38;
            this.label8.Text = "如果您希望看到任何本图书馆未收录的书籍";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1915, 1050);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 41);
            this.label9.TabIndex = 39;
            this.label9.Text = "可以向管理员提出建议";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(1929, 1109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 41);
            this.label10.TabIndex = 40;
            this.label10.Text = "我们将竭诚为您服务";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1695, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 33);
            this.label11.TabIndex = 41;
            this.label11.Text = "书名：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(1695, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 33);
            this.label12.TabIndex = 42;
            this.label12.Text = "作者：";
            // 
            // bookName
            // 
            this.bookName.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookName.Location = new System.Drawing.Point(1829, 243);
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(573, 50);
            this.bookName.TabIndex = 43;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.author.Location = new System.Drawing.Point(1829, 466);
            this.author.Multiline = true;
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(573, 54);
            this.author.TabIndex = 44;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(2012, 664);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(179, 89);
            this.submit.TabIndex = 45;
            this.submit.Text = "提交建议";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ReaderCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2586, 1333);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NoBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flpBooks);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.search);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lendnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.readerid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReaderCenter";
            this.Text = "ReaderCenter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox readerid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lendnumber;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.FlowLayoutPanel flpBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NoBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Button submit;
    }
}