namespace Digital_Library
{
    partial class CloudBridgeConnect
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1607, 83);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(157, 77);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "云桥连搜索";
            this.SearchButton.UseVisualStyleBackColor = false;
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
            this.searchbox.TabIndex = 10;
            this.searchbox.Text = " 输入书籍名/作者/国籍进行搜索";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2600, 220);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // flpBooks
            // 
            this.flpBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBooks.AutoScroll = true;
            this.flpBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBooks.Location = new System.Drawing.Point(596, 223);
            this.flpBooks.Margin = new System.Windows.Forms.Padding(0);
            this.flpBooks.Name = "flpBooks";
            this.flpBooks.Padding = new System.Windows.Forms.Padding(50, 50, 50, 20);
            this.flpBooks.Size = new System.Drawing.Size(1491, 704);
            this.flpBooks.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(1452, 1106);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(222, 117);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnCurrent
            // 
            this.btnCurrent.FlatAppearance.BorderSize = 0;
            this.btnCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrent.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCurrent.Location = new System.Drawing.Point(1171, 1106);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(222, 117);
            this.btnCurrent.TabIndex = 13;
            this.btnCurrent.Text = "当前页码";
            this.btnCurrent.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Location = new System.Drawing.Point(882, 1106);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(222, 117);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // CloudBridgeConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2586, 1267);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloudBridgeConnect";
            this.Text = "CloudBridgeConnect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpBooks;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnPrev;
    }
}