namespace Digital_Library
{
    partial class Details
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
            this.Search = new System.Windows.Forms.Button();
            this.Lend = new System.Windows.Forms.Button();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.BookName = new System.Windows.Forms.Label();
            this.Introduction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorNationality = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookNameEN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PublicationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Introduction_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(1162, 1120);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(209, 106);
            this.Search.TabIndex = 1;
            this.Search.Text = "查找该书籍";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Lend
            // 
            this.Lend.FlatAppearance.BorderSize = 0;
            this.Lend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lend.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lend.Location = new System.Drawing.Point(1914, 1120);
            this.Lend.Name = "Lend";
            this.Lend.Size = new System.Drawing.Size(209, 106);
            this.Lend.TabIndex = 2;
            this.Lend.Text = "借阅该书籍";
            this.Lend.UseVisualStyleBackColor = true;
            this.Lend.Click += new System.EventHandler(this.Lend_Click);
            // 
            // Cover
            // 
            this.Cover.Location = new System.Drawing.Point(121, 50);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(751, 1205);
            this.Cover.TabIndex = 3;
            this.Cover.TabStop = false;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Font = new System.Drawing.Font("华文中宋", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(1059, 84);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(297, 59);
            this.BookName.TabIndex = 6;
            this.BookName.Text = "BookName";
            // 
            // Introduction
            // 
            this.Introduction.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Introduction.Location = new System.Drawing.Point(981, 785);
            this.Introduction.Multiline = true;
            this.Introduction.Name = "Introduction";
            this.Introduction.ReadOnly = true;
            this.Introduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Introduction.Size = new System.Drawing.Size(1360, 277);
            this.Introduction.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(973, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "作者：";
            // 
            // BookAuthor
            // 
            this.BookAuthor.AutoSize = true;
            this.BookAuthor.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookAuthor.Location = new System.Drawing.Point(1130, 288);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(239, 44);
            this.BookAuthor.TabIndex = 9;
            this.BookAuthor.Text = "BookAuthor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(973, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "作者国籍：";
            // 
            // AuthorNationality
            // 
            this.AuthorNationality.AutoSize = true;
            this.AuthorNationality.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorNationality.Location = new System.Drawing.Point(1218, 380);
            this.AuthorNationality.Name = "AuthorNationality";
            this.AuthorNationality.Size = new System.Drawing.Size(393, 44);
            this.AuthorNationality.TabIndex = 11;
            this.AuthorNationality.Text = "AuthorNationality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(973, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "英文名称：";
            // 
            // BookNameEN
            // 
            this.BookNameEN.AutoSize = true;
            this.BookNameEN.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameEN.Location = new System.Drawing.Point(1215, 191);
            this.BookNameEN.Name = "BookNameEN";
            this.BookNameEN.Size = new System.Drawing.Size(239, 44);
            this.BookNameEN.TabIndex = 13;
            this.BookNameEN.Text = "BookNameEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(973, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 44);
            this.label4.TabIndex = 14;
            this.label4.Text = "出版时间：";
            // 
            // PublicationDate
            // 
            this.PublicationDate.AutoSize = true;
            this.PublicationDate.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublicationDate.Location = new System.Drawing.Point(1215, 482);
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.Size = new System.Drawing.Size(349, 44);
            this.PublicationDate.TabIndex = 15;
            this.PublicationDate.Text = "PublicationDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(973, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 44);
            this.label5.TabIndex = 16;
            this.label5.Text = "书籍种类：";
            // 
            // BookType
            // 
            this.BookType.AutoSize = true;
            this.BookType.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookType.Location = new System.Drawing.Point(1215, 583);
            this.BookType.Name = "BookType";
            this.BookType.Size = new System.Drawing.Size(195, 44);
            this.BookType.TabIndex = 17;
            this.BookType.Text = "BookType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(973, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 44);
            this.label6.TabIndex = 18;
            this.label6.Text = "书籍简介：";
            // 
            // Introduction_Change
            // 
            this.Introduction_Change.FlatAppearance.BorderSize = 0;
            this.Introduction_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Introduction_Change.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Introduction_Change.Location = new System.Drawing.Point(1914, 1120);
            this.Introduction_Change.Name = "Introduction_Change";
            this.Introduction_Change.Size = new System.Drawing.Size(209, 106);
            this.Introduction_Change.TabIndex = 19;
            this.Introduction_Change.Text = "修改书籍简介";
            this.Introduction_Change.UseVisualStyleBackColor = true;
            this.Introduction_Change.Visible = false;
            this.Introduction_Change.Click += new System.EventHandler(this.Introduction_Change_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2385, 1395);
            this.Controls.Add(this.Introduction_Change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BookType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PublicationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookNameEN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorNationality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.Lend);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Lend;
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.TextBox Introduction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AuthorNationality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BookNameEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PublicationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BookType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Introduction_Change;
    }
}