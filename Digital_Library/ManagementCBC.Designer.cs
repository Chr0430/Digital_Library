namespace Digital_Library
{
    partial class ManagementCBC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noArrivedList = new System.Windows.Forms.DataGridView();
            this.btnArrived = new System.Windows.Forms.Button();
            this.btnNOArrived = new System.Windows.Forms.Button();
            this.ArrivedList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.noArrivedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivedList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(463, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "云桥连未到书籍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1793, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 41);
            this.label2.TabIndex = 14;
            this.label2.Text = "云桥连已到书籍";
            // 
            // noArrivedList
            // 
            this.noArrivedList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.noArrivedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.noArrivedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑 Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.noArrivedList.DefaultCellStyle = dataGridViewCellStyle2;
            this.noArrivedList.Location = new System.Drawing.Point(174, 137);
            this.noArrivedList.MultiSelect = false;
            this.noArrivedList.Name = "noArrivedList";
            this.noArrivedList.RowHeadersVisible = false;
            this.noArrivedList.RowHeadersWidth = 62;
            this.noArrivedList.RowTemplate.Height = 30;
            this.noArrivedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.noArrivedList.Size = new System.Drawing.Size(875, 1009);
            this.noArrivedList.TabIndex = 15;
            // 
            // btnArrived
            // 
            this.btnArrived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnArrived.FlatAppearance.BorderSize = 0;
            this.btnArrived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrived.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnArrived.ForeColor = System.Drawing.Color.White;
            this.btnArrived.Location = new System.Drawing.Point(1093, 356);
            this.btnArrived.Name = "btnArrived";
            this.btnArrived.Size = new System.Drawing.Size(369, 109);
            this.btnArrived.TabIndex = 16;
            this.btnArrived.Text = "选中书籍切换为已到达\r\n==>";
            this.btnArrived.UseVisualStyleBackColor = false;
            this.btnArrived.Click += new System.EventHandler(this.btnArrived_Click);
            // 
            // btnNOArrived
            // 
            this.btnNOArrived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNOArrived.FlatAppearance.BorderSize = 0;
            this.btnNOArrived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNOArrived.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNOArrived.ForeColor = System.Drawing.Color.White;
            this.btnNOArrived.Location = new System.Drawing.Point(1093, 853);
            this.btnNOArrived.Name = "btnNOArrived";
            this.btnNOArrived.Size = new System.Drawing.Size(369, 109);
            this.btnNOArrived.TabIndex = 17;
            this.btnNOArrived.Text = "选中书籍切换为未到达\r\n<==";
            this.btnNOArrived.UseVisualStyleBackColor = false;
            this.btnNOArrived.Click += new System.EventHandler(this.btnNOArrived_Click);
            // 
            // ArrivedList
            // 
            this.ArrivedList.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArrivedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ArrivedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑 Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrivedList.DefaultCellStyle = dataGridViewCellStyle4;
            this.ArrivedList.Location = new System.Drawing.Point(1504, 137);
            this.ArrivedList.MultiSelect = false;
            this.ArrivedList.Name = "ArrivedList";
            this.ArrivedList.RowHeadersVisible = false;
            this.ArrivedList.RowHeadersWidth = 62;
            this.ArrivedList.RowTemplate.Height = 30;
            this.ArrivedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArrivedList.Size = new System.Drawing.Size(875, 1009);
            this.ArrivedList.TabIndex = 18;
            // 
            // ManagementCBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2564, 1277);
            this.Controls.Add(this.ArrivedList);
            this.Controls.Add(this.btnNOArrived);
            this.Controls.Add(this.btnArrived);
            this.Controls.Add(this.noArrivedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementCBC";
            this.Text = "ManagementCBC";
            ((System.ComponentModel.ISupportInitialize)(this.noArrivedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView noArrivedList;
        private System.Windows.Forms.Button btnArrived;
        private System.Windows.Forms.Button btnNOArrived;
        private System.Windows.Forms.DataGridView ArrivedList;
    }
}