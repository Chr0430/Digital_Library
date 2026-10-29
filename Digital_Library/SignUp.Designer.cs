namespace Digital_Library
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.Backpanel = new System.Windows.Forms.Panel();
            this.precautions = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.sign_up = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.administrator = new System.Windows.Forms.CheckBox();
            this.reader = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Backpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Backpanel
            // 
            this.Backpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backpanel.Controls.Add(this.precautions);
            this.Backpanel.Location = new System.Drawing.Point(269, 67);
            this.Backpanel.Name = "Backpanel";
            this.Backpanel.Size = new System.Drawing.Size(910, 1187);
            this.Backpanel.TabIndex = 23;
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
            this.label8.TabIndex = 34;
            this.label8.Text = "数字图书馆";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1453, 288);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(147, 145);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 33;
            this.Logo.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(1453, 945);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(209, 106);
            this.cancel.TabIndex = 32;
            this.cancel.Text = "取消注册";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // sign_up
            // 
            this.sign_up.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sign_up.FlatAppearance.BorderSize = 0;
            this.sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_up.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sign_up.Location = new System.Drawing.Point(1946, 945);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(209, 106);
            this.sign_up.TabIndex = 31;
            this.sign_up.Text = "确认注册";
            this.sign_up.UseVisualStyleBackColor = false;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(1609, 625);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(564, 42);
            this.password.TabIndex = 30;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(1609, 497);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(564, 42);
            this.username.TabIndex = 29;
            // 
            // administrator
            // 
            this.administrator.AutoSize = true;
            this.administrator.Enabled = false;
            this.administrator.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.administrator.Location = new System.Drawing.Point(1946, 759);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(265, 37);
            this.administrator.TabIndex = 28;
            this.administrator.Text = "注册管理员账号";
            this.administrator.UseVisualStyleBackColor = true;
            // 
            // reader
            // 
            this.reader.AutoSize = true;
            this.reader.Checked = true;
            this.reader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reader.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reader.Location = new System.Drawing.Point(1453, 759);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(233, 37);
            this.reader.TabIndex = 27;
            this.reader.Text = "注册读者账号";
            this.reader.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1448, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1448, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1652, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 59);
            this.label1.TabIndex = 24;
            this.label1.Text = "注册账号";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2363, 1339);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.administrator);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Backpanel.ResumeLayout(false);
            this.Backpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Backpanel;
        private System.Windows.Forms.Label precautions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.CheckBox administrator;
        private System.Windows.Forms.CheckBox reader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}