namespace Digital_Library
{
    partial class LendBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.username = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1503, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "借阅书籍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1272, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "借阅用户：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1272, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "书籍名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1272, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "借阅时间：";
            // 
            // Date
            // 
            this.Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Date.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Date.FormattingEnabled = true;
            this.Date.Location = new System.Drawing.Point(1513, 507);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(128, 38);
            this.Date.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1272, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "请输入密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1272, 778);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "请再次输入密码：";
            // 
            // password1
            // 
            this.password1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password1.Location = new System.Drawing.Point(1513, 640);
            this.password1.Multiline = true;
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(405, 44);
            this.password1.TabIndex = 9;
            // 
            // password2
            // 
            this.password2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password2.Location = new System.Drawing.Point(1513, 778);
            this.password2.Multiline = true;
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(405, 44);
            this.password2.TabIndex = 10;
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(1240, 1083);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(209, 106);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "取消借阅";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Confirm
            // 
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Location = new System.Drawing.Point(1879, 1083);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(209, 106);
            this.Confirm.TabIndex = 12;
            this.Confirm.Text = "确认借阅";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox.Location = new System.Drawing.Point(1277, 936);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(457, 37);
            this.checkBox.TabIndex = 14;
            this.checkBox.Text = "我承诺于一日内到图书馆取书";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(1508, 280);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 30);
            this.username.TabIndex = 15;
            this.username.Text = "UserName";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookName.Location = new System.Drawing.Point(1508, 397);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(133, 30);
            this.BookName.TabIndex = 16;
            this.BookName.Text = "BookName";
            // 
            // Cover
            // 
            this.Cover.Location = new System.Drawing.Point(121, 50);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(751, 1205);
            this.Cover.TabIndex = 17;
            this.Cover.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1663, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "日";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1277, 67);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(154, 150);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 19;
            this.Logo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1290, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "数字图书馆";
            // 
            // LendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2385, 1395);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LendBook";
            this.Text = "LendBook";
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label8;
    }
}