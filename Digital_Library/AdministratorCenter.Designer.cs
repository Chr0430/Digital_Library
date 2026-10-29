namespace Digital_Library
{
    partial class AdministratorCenter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorCenter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.suggestion = new System.Windows.Forms.DataGridView();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label = new System.Windows.Forms.Label();
            this.lendnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.booknumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.administratorid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.enterBooks = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 1333);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "读者建议";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(335, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(523, 1333);
            this.panel.TabIndex = 3;
            // 
            // suggestion
            // 
            this.suggestion.AllowUserToAddRows = false;
            this.suggestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suggestion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.suggestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suggestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.suggestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suggestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suggestion.DefaultCellStyle = dataGridViewCellStyle3;
            this.suggestion.EnableHeadersVisualStyles = false;
            this.suggestion.GridColor = System.Drawing.SystemColors.ControlLight;
            this.suggestion.Location = new System.Drawing.Point(1197, 107);
            this.suggestion.Name = "suggestion";
            this.suggestion.ReadOnly = true;
            this.suggestion.RowHeadersWidth = 62;
            this.suggestion.RowTemplate.Height = 30;
            this.suggestion.Size = new System.Drawing.Size(1243, 882);
            this.suggestion.TabIndex = 4;
            // 
            // ColumnDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDelete.HeaderText = "操作";
            this.ColumnDelete.MinimumWidth = 8;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(1638, 1107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(206, 41);
            this.label.TabIndex = 5;
            this.label.Text = "Encourage";
            // 
            // lendnumber
            // 
            this.lendnumber.Enabled = false;
            this.lendnumber.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lendnumber.Location = new System.Drawing.Point(54, 861);
            this.lendnumber.Name = "lendnumber";
            this.lendnumber.ReadOnly = true;
            this.lendnumber.Size = new System.Drawing.Size(249, 39);
            this.lendnumber.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 782);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 32);
            this.label5.TabIndex = 41;
            this.label5.Text = "借出数量：";
            // 
            // booknumber
            // 
            this.booknumber.Enabled = false;
            this.booknumber.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknumber.Location = new System.Drawing.Point(54, 684);
            this.booknumber.Name = "booknumber";
            this.booknumber.ReadOnly = true;
            this.booknumber.Size = new System.Drawing.Size(249, 39);
            this.booknumber.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "书籍数量：";
            // 
            // administratorid
            // 
            this.administratorid.Enabled = false;
            this.administratorid.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.administratorid.Location = new System.Drawing.Point(54, 517);
            this.administratorid.Name = "administratorid";
            this.administratorid.ReadOnly = true;
            this.administratorid.Size = new System.Drawing.Size(249, 39);
            this.administratorid.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "管理员ID：";
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
            this.username.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "用户名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(103, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "数字图书馆";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(95, 100);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(147, 145);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 33;
            this.Logo.TabStop = false;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logout.Location = new System.Drawing.Point(28, 997);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(148, 85);
            this.logout.TabIndex = 43;
            this.logout.Text = "退出登录";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // enterBooks
            // 
            this.enterBooks.FlatAppearance.BorderSize = 0;
            this.enterBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBooks.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterBooks.Location = new System.Drawing.Point(155, 1131);
            this.enterBooks.Name = "enterBooks";
            this.enterBooks.Size = new System.Drawing.Size(148, 85);
            this.enterBooks.TabIndex = 44;
            this.enterBooks.Text = "录入书籍";
            this.enterBooks.UseVisualStyleBackColor = true;
            this.enterBooks.Click += new System.EventHandler(this.enterBooks_Click);
            // 
            // login
            // 
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(28, 997);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(148, 85);
            this.login.TabIndex = 45;
            this.login.Text = "前往登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // AdministratorCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2586, 1333);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.login);
            this.Controls.Add(this.enterBooks);
            this.Controls.Add(this.lendnumber);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.booknumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.administratorid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.suggestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorCenter";
            this.Text = "AdministratorCenter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView suggestion;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox lendnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox booknumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox administratorid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button enterBooks;
        private System.Windows.Forms.Button login;
    }
}