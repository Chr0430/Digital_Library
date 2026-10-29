namespace Digital_Library
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reader = new System.Windows.Forms.CheckBox();
            this.administrator = new System.Windows.Forms.CheckBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.sign_up = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.precautions = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Backpanel = new System.Windows.Forms.Panel();
            this.ShowPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Backpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1652, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1448, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1448, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // reader
            // 
            this.reader.AutoSize = true;
            this.reader.Checked = true;
            this.reader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reader.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reader.Location = new System.Drawing.Point(1453, 759);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(265, 37);
            this.reader.TabIndex = 3;
            this.reader.Text = "以读者身份登录";
            this.reader.UseVisualStyleBackColor = true;
            this.reader.Click += new System.EventHandler(this.reader_Click);
            // 
            // administrator
            // 
            this.administrator.AutoSize = true;
            this.administrator.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.administrator.Location = new System.Drawing.Point(1946, 759);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(297, 37);
            this.administrator.TabIndex = 4;
            this.administrator.Text = "以管理员身份登录";
            this.administrator.UseVisualStyleBackColor = true;
            this.administrator.Click += new System.EventHandler(this.administrator_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(1609, 497);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(564, 42);
            this.username.TabIndex = 5;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(1609, 625);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(564, 42);
            this.password.TabIndex = 6;
            // 
            // sign_up
            // 
            this.sign_up.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sign_up.FlatAppearance.BorderSize = 0;
            this.sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_up.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sign_up.Location = new System.Drawing.Point(1453, 945);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(209, 106);
            this.sign_up.TabIndex = 7;
            this.sign_up.Text = "立即注册";
            this.sign_up.UseVisualStyleBackColor = false;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.SystemColors.ControlLight;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log_in.Location = new System.Drawing.Point(1946, 945);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(209, 106);
            this.log_in.TabIndex = 8;
            this.log_in.Text = "登录账号";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1453, 288);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(147, 145);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // precautions
            // 
            this.precautions.AutoSize = true;
            this.precautions.BackColor = System.Drawing.Color.Transparent;
            this.precautions.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.precautions.Location = new System.Drawing.Point(185, 0);
            this.precautions.Name = "precautions";
            this.precautions.Size = new System.Drawing.Size(261, 44);
            this.precautions.TabIndex = 11;
            this.precautions.Text = "Precautions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1461, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "数字图书馆";
            // 
            // Backpanel
            // 
            this.Backpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backpanel.Controls.Add(this.precautions);
            this.Backpanel.Location = new System.Drawing.Point(269, 67);
            this.Backpanel.Name = "Backpanel";
            this.Backpanel.Size = new System.Drawing.Size(910, 1187);
            this.Backpanel.TabIndex = 22;
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowPassword.FlatAppearance.BorderSize = 0;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowPassword.Location = new System.Drawing.Point(2201, 628);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(42, 42);
            this.ShowPassword.TabIndex = 36;
            this.ShowPassword.Text = "👁";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2363, 1339);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.Backpanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.administrator);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Backpanel.ResumeLayout(false);
            this.Backpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox reader;
        private System.Windows.Forms.CheckBox administrator;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label precautions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Backpanel;
        private System.Windows.Forms.Button ShowPassword;
    }
}