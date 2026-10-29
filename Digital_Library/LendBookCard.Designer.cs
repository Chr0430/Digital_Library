namespace Digital_Library
{
    partial class LendBookCard
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
            this.Type = new System.Windows.Forms.Label();
            this.ReturnTime = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // Cover
            // 
            this.Cover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cover.Location = new System.Drawing.Point(36, 21);
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
            this.BookName.AutoSize = true;
            this.BookName.Cursor = System.Windows.Forms.Cursors.Default;
            this.BookName.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(265, 21);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(216, 41);
            this.BookName.TabIndex = 1;
            this.BookName.Text = "BookName";
            this.BookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookName.Click += new System.EventHandler(this.Book_Click);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Author.Location = new System.Drawing.Point(266, 137);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(108, 36);
            this.Author.TabIndex = 0;
            this.Author.Text = "Author";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type.Location = new System.Drawing.Point(266, 219);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(80, 36);
            this.Type.TabIndex = 3;
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReturnTime
            // 
            this.ReturnTime.AutoSize = true;
            this.ReturnTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReturnTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnTime.Location = new System.Drawing.Point(694, 137);
            this.ReturnTime.Name = "ReturnTime";
            this.ReturnTime.Size = new System.Drawing.Size(182, 39);
            this.ReturnTime.TabIndex = 4;
            this.ReturnTime.Text = "ReturnTime";
            this.ReturnTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.RemainingTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RemainingTime.Location = new System.Drawing.Point(694, 219);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(240, 39);
            this.RemainingTime.TabIndex = 5;
            this.RemainingTime.Text = "RemainingTime";
            this.RemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LendBookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.ReturnTime);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Cover);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LendBookCard";
            this.Size = new System.Drawing.Size(1108, 324);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label ReturnTime;
        private System.Windows.Forms.Label RemainingTime;
    }
}