namespace Digital_Library
{
    partial class EnterBooks
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.nameEN = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.nationality = new System.Windows.Forms.TextBox();
            this.publication = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.TextBox();
            this.introduction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(164, 107);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(769, 870);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(327, 1038);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(230, 140);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "上传封面图片";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1127, 1038);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 140);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "取消录入";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(1927, 1038);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(230, 140);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "录入书籍";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1098, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "书籍名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1098, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "英文名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1098, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "书籍作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1838, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "作者国籍：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1838, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "出版日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1098, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "书籍种类：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1098, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 41);
            this.label7.TabIndex = 18;
            this.label7.Text = "书籍简介：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1838, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 41);
            this.label8.TabIndex = 19;
            this.label8.Text = "存放地点：";
            // 
            // bookName
            // 
            this.bookName.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookName.Location = new System.Drawing.Point(1333, 138);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(391, 55);
            this.bookName.TabIndex = 20;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.Control;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Location = new System.Drawing.Point(164, 107);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(769, 870);
            this.button.TabIndex = 21;
            this.button.Text = "+";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(1333, 498);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(210, 49);
            this.type.TabIndex = 22;
            // 
            // nameEN
            // 
            this.nameEN.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameEN.Location = new System.Drawing.Point(1333, 258);
            this.nameEN.Name = "nameEN";
            this.nameEN.Size = new System.Drawing.Size(391, 55);
            this.nameEN.TabIndex = 23;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.author.Location = new System.Drawing.Point(1333, 378);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(391, 55);
            this.author.TabIndex = 24;
            // 
            // nationality
            // 
            this.nationality.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nationality.Location = new System.Drawing.Point(2055, 138);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(391, 55);
            this.nationality.TabIndex = 25;
            // 
            // publication
            // 
            this.publication.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publication.Location = new System.Drawing.Point(2055, 258);
            this.publication.Name = "publication";
            this.publication.Size = new System.Drawing.Size(391, 55);
            this.publication.TabIndex = 26;
            // 
            // place
            // 
            this.place.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.place.Location = new System.Drawing.Point(2055, 378);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(391, 55);
            this.place.TabIndex = 27;
            // 
            // introduction
            // 
            this.introduction.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.introduction.Location = new System.Drawing.Point(1177, 741);
            this.introduction.Multiline = true;
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(1185, 200);
            this.introduction.TabIndex = 28;
            // 
            // EnterBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2564, 1277);
            this.Controls.Add(this.introduction);
            this.Controls.Add(this.place);
            this.Controls.Add(this.publication);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.author);
            this.Controls.Add(this.nameEN);
            this.Controls.Add(this.type);
            this.Controls.Add(this.button);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.picPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterBooks";
            this.Text = "EnterBooks";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox nameEN;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.TextBox publication;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.TextBox introduction;
    }
}