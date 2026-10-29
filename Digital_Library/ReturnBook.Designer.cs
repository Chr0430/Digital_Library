namespace Digital_Library
{
    partial class ReturnBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtLendTime = new System.Windows.Forms.TextBox();
            this.txtReturnTime = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtPublicationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtendTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("微软雅黑 Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView1.Location = new System.Drawing.Point(269, 865);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2015, 365);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1737, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 55);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(2006, 703);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(216, 109);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "归还选中书籍";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUsername.Location = new System.Drawing.Point(1115, 174);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(599, 55);
            this.txtUsername.TabIndex = 19;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookName.Location = new System.Drawing.Point(419, 351);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(404, 55);
            this.txtBookName.TabIndex = 20;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAuthor.Location = new System.Drawing.Point(419, 541);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(404, 55);
            this.txtAuthor.TabIndex = 21;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNationality.Location = new System.Drawing.Point(1139, 541);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.ReadOnly = true;
            this.txtNationality.Size = new System.Drawing.Size(404, 55);
            this.txtNationality.TabIndex = 22;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.Location = new System.Drawing.Point(1838, 351);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(404, 55);
            this.txtType.TabIndex = 23;
            // 
            // txtLendTime
            // 
            this.txtLendTime.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLendTime.Location = new System.Drawing.Point(419, 731);
            this.txtLendTime.Name = "txtLendTime";
            this.txtLendTime.ReadOnly = true;
            this.txtLendTime.Size = new System.Drawing.Size(404, 55);
            this.txtLendTime.TabIndex = 24;
            // 
            // txtReturnTime
            // 
            this.txtReturnTime.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReturnTime.Location = new System.Drawing.Point(1139, 731);
            this.txtReturnTime.Name = "txtReturnTime";
            this.txtReturnTime.Size = new System.Drawing.Size(404, 55);
            this.txtReturnTime.TabIndex = 25;
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlace.Location = new System.Drawing.Point(1838, 541);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.ReadOnly = true;
            this.txtPlace.Size = new System.Drawing.Size(404, 55);
            this.txtPlace.TabIndex = 26;
            // 
            // txtPublicationDate
            // 
            this.txtPublicationDate.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPublicationDate.Location = new System.Drawing.Point(1139, 351);
            this.txtPublicationDate.Name = "txtPublicationDate";
            this.txtPublicationDate.ReadOnly = true;
            this.txtPublicationDate.Size = new System.Drawing.Size(404, 55);
            this.txtPublicationDate.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(579, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "输入读者用户名查询借书记录";
            // 
            // btnExtendTime
            // 
            this.btnExtendTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnExtendTime.FlatAppearance.BorderSize = 0;
            this.btnExtendTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendTime.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExtendTime.ForeColor = System.Drawing.Color.White;
            this.btnExtendTime.Location = new System.Drawing.Point(1696, 703);
            this.btnExtendTime.Name = "btnExtendTime";
            this.btnExtendTime.Size = new System.Drawing.Size(216, 109);
            this.btnExtendTime.TabIndex = 29;
            this.btnExtendTime.Text = "延长借阅时间";
            this.btnExtendTime.UseVisualStyleBackColor = false;
            this.btnExtendTime.Click += new System.EventHandler(this.btnExtendTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1071, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 59);
            this.label2.TabIndex = 30;
            this.label2.Text = "归还书籍管理";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(289, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 41);
            this.label3.TabIndex = 31;
            this.label3.Text = "书名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(949, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 32;
            this.label4.Text = "出版日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1648, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 41);
            this.label5.TabIndex = 33;
            this.label5.Text = "书籍种类";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(289, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 41);
            this.label6.TabIndex = 34;
            this.label6.Text = "作者";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1009, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 41);
            this.label7.TabIndex = 35;
            this.label7.Text = "国籍";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1648, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 41);
            this.label8.TabIndex = 36;
            this.label8.Text = "存放地点";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(229, 734);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 41);
            this.label9.TabIndex = 37;
            this.label9.Text = "借出时间";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(949, 734);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 41);
            this.label10.TabIndex = 38;
            this.label10.Text = "归还时间";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1277);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExtendTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPublicationDate);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtReturnTime);
            this.Controls.Add(this.txtLendTime);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtLendTime;
        private System.Windows.Forms.TextBox txtReturnTime;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtPublicationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtendTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}