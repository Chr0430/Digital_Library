namespace Digital_Library
{
    partial class ManagementAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementAccount));
            this.readernumber = new System.Windows.Forms.Button();
            this.normalnumber = new System.Windows.Forms.Button();
            this.freezenumber = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDefrost = new System.Windows.Forms.Button();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.accountsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.management = new System.Windows.Forms.Button();
            this.freeze = new System.Windows.Forms.Button();
            this.defrost = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // readernumber
            // 
            this.readernumber.FlatAppearance.BorderSize = 0;
            this.readernumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readernumber.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readernumber.Location = new System.Drawing.Point(444, 80);
            this.readernumber.Name = "readernumber";
            this.readernumber.Size = new System.Drawing.Size(354, 124);
            this.readernumber.TabIndex = 0;
            this.readernumber.Text = "读者账号数";
            this.readernumber.UseVisualStyleBackColor = true;
            this.readernumber.Click += new System.EventHandler(this.readernumber_Click);
            // 
            // normalnumber
            // 
            this.normalnumber.FlatAppearance.BorderSize = 0;
            this.normalnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalnumber.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.normalnumber.Location = new System.Drawing.Point(1044, 80);
            this.normalnumber.Name = "normalnumber";
            this.normalnumber.Size = new System.Drawing.Size(354, 124);
            this.normalnumber.TabIndex = 1;
            this.normalnumber.Text = "正常账号数";
            this.normalnumber.UseVisualStyleBackColor = true;
            this.normalnumber.Click += new System.EventHandler(this.normalnumber_Click);
            // 
            // freezenumber
            // 
            this.freezenumber.FlatAppearance.BorderSize = 0;
            this.freezenumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezenumber.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.freezenumber.Location = new System.Drawing.Point(1644, 80);
            this.freezenumber.Name = "freezenumber";
            this.freezenumber.Size = new System.Drawing.Size(354, 124);
            this.freezenumber.TabIndex = 2;
            this.freezenumber.Text = "冻结账号数";
            this.freezenumber.UseVisualStyleBackColor = true;
            this.freezenumber.Click += new System.EventHandler(this.freezenumber_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnDefrost);
            this.panel1.Controls.Add(this.btnFreeze);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.accountsList);
            this.panel1.Location = new System.Drawing.Point(253, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2310, 1058);
            this.panel1.TabIndex = 3;
            // 
            // btnDefrost
            // 
            this.btnDefrost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDefrost.FlatAppearance.BorderSize = 0;
            this.btnDefrost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefrost.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDefrost.ForeColor = System.Drawing.Color.White;
            this.btnDefrost.Location = new System.Drawing.Point(1665, 760);
            this.btnDefrost.Name = "btnDefrost";
            this.btnDefrost.Size = new System.Drawing.Size(210, 120);
            this.btnDefrost.TabIndex = 11;
            this.btnDefrost.Text = "解冻该账号";
            this.btnDefrost.UseVisualStyleBackColor = false;
            this.btnDefrost.Visible = false;
            this.btnDefrost.Click += new System.EventHandler(this.btnDefrost_Click);
            // 
            // btnFreeze
            // 
            this.btnFreeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFreeze.FlatAppearance.BorderSize = 0;
            this.btnFreeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreeze.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFreeze.ForeColor = System.Drawing.Color.White;
            this.btnFreeze.Location = new System.Drawing.Point(1665, 760);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(210, 120);
            this.btnFreeze.TabIndex = 10;
            this.btnFreeze.Text = "冻结该账号";
            this.btnFreeze.UseVisualStyleBackColor = false;
            this.btnFreeze.Visible = false;
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1943, 760);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 120);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除账号";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1391, 760);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 120);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加新账号";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1665, 760);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 120);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(1391, 74);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(876, 514);
            this.panel.TabIndex = 6;
            // 
            // accountsList
            // 
            this.accountsList.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.accountsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑 Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountsList.DefaultCellStyle = dataGridViewCellStyle4;
            this.accountsList.Location = new System.Drawing.Point(127, 74);
            this.accountsList.MultiSelect = false;
            this.accountsList.Name = "accountsList";
            this.accountsList.ReadOnly = true;
            this.accountsList.RowHeadersVisible = false;
            this.accountsList.RowHeadersWidth = 62;
            this.accountsList.RowTemplate.Height = 30;
            this.accountsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountsList.Size = new System.Drawing.Size(1130, 918);
            this.accountsList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "数字图书馆";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // management
            // 
            this.management.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.management.Enabled = false;
            this.management.FlatAppearance.BorderSize = 0;
            this.management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.management.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.management.Location = new System.Drawing.Point(0, 220);
            this.management.Name = "management";
            this.management.Size = new System.Drawing.Size(260, 220);
            this.management.TabIndex = 0;
            this.management.Text = "账号管理";
            this.management.UseVisualStyleBackColor = false;
            this.management.Click += new System.EventHandler(this.management_Click);
            // 
            // freeze
            // 
            this.freeze.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.freeze.FlatAppearance.BorderSize = 0;
            this.freeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeze.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.freeze.Location = new System.Drawing.Point(0, 440);
            this.freeze.Name = "freeze";
            this.freeze.Size = new System.Drawing.Size(260, 220);
            this.freeze.TabIndex = 40;
            this.freeze.Text = "账号冻结";
            this.freeze.UseVisualStyleBackColor = false;
            this.freeze.Click += new System.EventHandler(this.freeze_Click);
            // 
            // defrost
            // 
            this.defrost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.defrost.FlatAppearance.BorderSize = 0;
            this.defrost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defrost.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.defrost.Location = new System.Drawing.Point(0, 660);
            this.defrost.Name = "defrost";
            this.defrost.Size = new System.Drawing.Size(260, 220);
            this.defrost.TabIndex = 41;
            this.defrost.Text = "账号解冻";
            this.defrost.UseVisualStyleBackColor = false;
            this.defrost.Click += new System.EventHandler(this.defrost_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modify.FlatAppearance.BorderSize = 0;
            this.modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modify.Location = new System.Drawing.Point(0, 880);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(260, 220);
            this.modify.TabIndex = 42;
            this.modify.Text = "修改账号";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // ManagementAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2564, 1277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.defrost);
            this.Controls.Add(this.freeze);
            this.Controls.Add(this.management);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.freezenumber);
            this.Controls.Add(this.normalnumber);
            this.Controls.Add(this.readernumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementAccount";
            this.Text = "ManagementAccount";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readernumber;
        private System.Windows.Forms.Button normalnumber;
        private System.Windows.Forms.Button freezenumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button management;
        private System.Windows.Forms.Button freeze;
        private System.Windows.Forms.Button defrost;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.DataGridView accountsList;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDefrost;
        private System.Windows.Forms.Button btnFreeze;
    }
}