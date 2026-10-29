namespace Digital_Library
{
    partial class ManagementActivities
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManagementPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.activitiesList = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.unstarted = new System.Windows.Forms.TextBox();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.introduction = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.activityName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.time4 = new System.Windows.Forms.TextBox();
            this.time2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ongoing = new System.Windows.Forms.TextBox();
            this.finished = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManagementButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesList)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.ManagementPanel);
            this.panel1.Controls.Add(this.unstarted);
            this.panel1.Controls.Add(this.AddPanel);
            this.panel1.Controls.Add(this.ongoing);
            this.panel1.Controls.Add(this.finished);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ManagementButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(190, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2162, 1024);
            this.panel1.TabIndex = 0;
            // 
            // ManagementPanel
            // 
            this.ManagementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManagementPanel.Controls.Add(this.btnDelete);
            this.ManagementPanel.Controls.Add(this.btnSave);
            this.ManagementPanel.Controls.Add(this.activitiesList);
            this.ManagementPanel.Controls.Add(this.label15);
            this.ManagementPanel.Location = new System.Drawing.Point(0, 3);
            this.ManagementPanel.Name = "ManagementPanel";
            this.ManagementPanel.Size = new System.Drawing.Size(800, 1021);
            this.ManagementPanel.TabIndex = 13;
            this.ManagementPanel.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(487, 838);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 100);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除选中行";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(119, 838);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 100);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // activitiesList
            // 
            this.activitiesList.AllowUserToAddRows = false;
            this.activitiesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesList.Location = new System.Drawing.Point(47, 178);
            this.activitiesList.MultiSelect = false;
            this.activitiesList.Name = "activitiesList";
            this.activitiesList.RowHeadersVisible = false;
            this.activitiesList.RowHeadersWidth = 62;
            this.activitiesList.RowTemplate.Height = 30;
            this.activitiesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activitiesList.Size = new System.Drawing.Size(708, 618);
            this.activitiesList.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("华文中宋", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(310, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 50);
            this.label15.TabIndex = 3;
            this.label15.Text = "活动管理";
            // 
            // unstarted
            // 
            this.unstarted.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.unstarted.Location = new System.Drawing.Point(1080, 675);
            this.unstarted.Name = "unstarted";
            this.unstarted.ReadOnly = true;
            this.unstarted.Size = new System.Drawing.Size(244, 55);
            this.unstarted.TabIndex = 11;
            this.unstarted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddPanel.Controls.Add(this.comboBox);
            this.AddPanel.Controls.Add(this.Submit);
            this.AddPanel.Controls.Add(this.introduction);
            this.AddPanel.Controls.Add(this.label14);
            this.AddPanel.Controls.Add(this.place);
            this.AddPanel.Controls.Add(this.label13);
            this.AddPanel.Controls.Add(this.activityName);
            this.AddPanel.Controls.Add(this.label12);
            this.AddPanel.Controls.Add(this.time3);
            this.AddPanel.Controls.Add(this.label11);
            this.AddPanel.Controls.Add(this.time4);
            this.AddPanel.Controls.Add(this.time2);
            this.AddPanel.Controls.Add(this.label10);
            this.AddPanel.Controls.Add(this.time1);
            this.AddPanel.Controls.Add(this.dateTimePicker);
            this.AddPanel.Controls.Add(this.textBox);
            this.AddPanel.Controls.Add(this.button);
            this.AddPanel.Controls.Add(this.label9);
            this.AddPanel.Controls.Add(this.label8);
            this.AddPanel.Controls.Add(this.label7);
            this.AddPanel.Location = new System.Drawing.Point(1362, 3);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(800, 1021);
            this.AddPanel.TabIndex = 12;
            this.AddPanel.Visible = false;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(76, 908);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(224, 44);
            this.comboBox.TabIndex = 23;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(487, 898);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(190, 100);
            this.Submit.TabIndex = 22;
            this.Submit.Text = "提交活动";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // introduction
            // 
            this.introduction.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.introduction.Location = new System.Drawing.Point(273, 725);
            this.introduction.Multiline = true;
            this.introduction.Name = "introduction";
            this.introduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.introduction.Size = new System.Drawing.Size(404, 141);
            this.introduction.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(69, 728);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 41);
            this.label14.TabIndex = 19;
            this.label14.Text = "活动介绍：";
            // 
            // place
            // 
            this.place.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.place.Location = new System.Drawing.Point(273, 627);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(404, 55);
            this.place.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(69, 630);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 41);
            this.label13.TabIndex = 17;
            this.label13.Text = "活动地点：";
            // 
            // activityName
            // 
            this.activityName.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.activityName.Location = new System.Drawing.Point(273, 255);
            this.activityName.Name = "activityName";
            this.activityName.Size = new System.Drawing.Size(404, 55);
            this.activityName.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(547, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 41);
            this.label12.TabIndex = 15;
            this.label12.Text = ":";
            // 
            // time3
            // 
            this.time3.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time3.Location = new System.Drawing.Point(447, 501);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(80, 55);
            this.time3.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(395, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 41);
            this.label11.TabIndex = 13;
            this.label11.Text = "-";
            // 
            // time4
            // 
            this.time4.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time4.Location = new System.Drawing.Point(597, 501);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(80, 55);
            this.time4.TabIndex = 12;
            // 
            // time2
            // 
            this.time2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time2.Location = new System.Drawing.Point(295, 501);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(80, 55);
            this.time2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(245, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 41);
            this.label10.TabIndex = 10;
            this.label10.Text = ":";
            // 
            // time1
            // 
            this.time1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time1.Location = new System.Drawing.Point(145, 501);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(80, 55);
            this.time1.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Location = new System.Drawing.Point(270, 395);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(407, 55);
            this.dateTimePicker.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(270, 395);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(407, 55);
            this.textBox.TabIndex = 0;
            this.textBox.Visible = false;
            // 
            // button
            // 
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Location = new System.Drawing.Point(698, 395);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(86, 55);
            this.button.TabIndex = 8;
            this.button.Text = "切换";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(69, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 41);
            this.label9.TabIndex = 5;
            this.label9.Text = "活动时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(69, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 41);
            this.label8.TabIndex = 4;
            this.label8.Text = "活动名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(310, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "添加活动";
            // 
            // ongoing
            // 
            this.ongoing.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ongoing.Location = new System.Drawing.Point(1080, 535);
            this.ongoing.Name = "ongoing";
            this.ongoing.ReadOnly = true;
            this.ongoing.Size = new System.Drawing.Size(244, 55);
            this.ongoing.TabIndex = 10;
            this.ongoing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // finished
            // 
            this.finished.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finished.Location = new System.Drawing.Point(1080, 395);
            this.finished.Name = "finished";
            this.finished.ReadOnly = true;
            this.finished.Size = new System.Drawing.Size(244, 55);
            this.finished.TabIndex = 9;
            this.finished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.total.Location = new System.Drawing.Point(1080, 255);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(244, 55);
            this.total.TabIndex = 8;
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(840, 678);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "未开始活动：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(840, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "进行中活动：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(840, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "已结束活动：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(840, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "活动总数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(984, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "图书活动";
            // 
            // ManagementButton
            // 
            this.ManagementButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ManagementButton.FlatAppearance.BorderSize = 0;
            this.ManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagementButton.Font = new System.Drawing.Font("华文中宋", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagementButton.Location = new System.Drawing.Point(1362, 3);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(800, 1021);
            this.ManagementButton.TabIndex = 1;
            this.ManagementButton.Text = "活动管理";
            this.ManagementButton.UseVisualStyleBackColor = false;
            this.ManagementButton.Click += new System.EventHandler(this.ManagementButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("华文中宋", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddButton.Location = new System.Drawing.Point(0, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(800, 1021);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "添加活动";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ManagementActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1277);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementActivities";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ManagementPanel.ResumeLayout(false);
            this.ManagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesList)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManagementButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unstarted;
        private System.Windows.Forms.TextBox ongoing;
        private System.Windows.Forms.TextBox finished;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel ManagementPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox activityName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox time3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox time4;
        private System.Windows.Forms.TextBox time2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.TextBox introduction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView activitiesList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}