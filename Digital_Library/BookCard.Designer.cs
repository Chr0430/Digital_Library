namespace Digital_Library
{
    partial class BookCard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 声明控件变量（和BookCard.cs中的定义对应）
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label Author;

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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Cover = new System.Windows.Forms.PictureBox();
            this.BookName = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // Cover
            // 
            this.Cover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cover.Location = new System.Drawing.Point(33, 23);
            this.Cover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(197, 271);
            this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cover.TabIndex = 2;
            this.Cover.TabStop = false;
            this.Cover.Click += new System.EventHandler(this.Book_Click);
            // 
            // BookName
            // 
            this.BookName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(-18, 309);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(297, 58);
            this.BookName.TabIndex = 1;
            this.BookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BookName.Click += new System.EventHandler(this.Book_Click);
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Author.Location = new System.Drawing.Point(33, 386);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(197, 22);
            this.Author.TabIndex = 0;
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Cover);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookCard";
            this.Size = new System.Drawing.Size(265, 439);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}