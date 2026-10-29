using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Digital_Library
{
    //账号管理页面设计
    public partial class ManagementAccount : Form
    {
        private Navigation _parentForm;//绑定父页面
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径

        // 用成员变量保存饼图
        private Chart chart;
        private System.Windows.Forms.ToolTip chartToolTip;

        public ManagementAccount(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";


            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            // 初始化提示框
            chartToolTip = new System.Windows.Forms.ToolTip();        // 创建提示框
            chartToolTip.AutoPopDelay = 5000;    //提示框停留多久
            chartToolTip.InitialDelay = 100;     //鼠标放上去多久后弹出
            chartToolTip.ReshowDelay = 100;      //连续切换时多久再弹出

            accountsList.EditingControlShowing += AccountsList_EditingControlShowing;

            LoadAccountsList();
            LoadNumber();

            // 等窗体加载完成再创建图表
            this.Load += Chart_Load;
        }

        #region 表格加载
        public void LoadAccountsList(string filterStatus = "")
        {
            try
            {
                string sql = "SELECT ID, UserName AS 用户名, Password AS 密码, Status AS 帐号状态, Lend_Number AS 借阅数量, Activity_ID AS 参加活动 FROM reader";
                DataTable dt;
                if (!string.IsNullOrEmpty(filterStatus))
                {
                    dt = _mysqlconnect.ExecuteQuery(sql + " WHERE Status = @status", MySQLConnect.Param("@status", filterStatus));
                }
                else
                {
                    dt = _mysqlconnect.ExecuteQuery(sql);
                }
                accountsList.DataSource = dt;



                if (accountsList.Columns["ID"] != null)
                    accountsList.Columns["ID"].Visible = false;

                accountsList.Columns["用户名"].HeaderText = "  用户名";
                accountsList.Columns["密码"].HeaderText = "  密码";
                accountsList.Columns["帐号状态"].HeaderText = "  帐号状态";
                accountsList.Columns["借阅数量"].HeaderText = "  借阅数量";
                accountsList.Columns["参加活动"].HeaderText = "  参加活动";

                accountsList.Columns[1].Width = 180;
                accountsList.Columns[2].Width = 180;
                accountsList.Columns[3].Width = 130;
                accountsList.Columns[4].Width = 130;
                accountsList.Columns[5].Width = 130;

                accountsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 点击任意单元格选中整行
                accountsList.MultiSelect = false; // 禁止多选，一次只选一行

                foreach (DataGridViewColumn col in accountsList.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // 表头居中
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // 内容居中
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("加载表格失败：" + ex.Message);
            }
        }
        #endregion

        public void LoadNumber()
        {
            try
            {
                //测试连接是否可用
                if (!_mysqlconnect.TestConnection())
                {
                    MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //执行查询reader表，展示结果到对应位置
                string querySql = $"SELECT COUNT(*) FROM reader;";
                DataTable result = _mysqlconnect.ExecuteQuery(querySql);//查询结果为DataTable类型
                if (result.Rows.Count > 0)
                {
                    int Count = Convert.ToInt32(result.Rows[0][0]);
                    readernumber.Text = "读者账号数：" + Count.ToString();
                }
                querySql = $"SELECT COUNT(*) FROM reader WHERE Status = 'Normal';";
                result = _mysqlconnect.ExecuteQuery(querySql);//查询结果为DataTable类型
                if (result.Rows.Count > 0)
                {
                    int Count = Convert.ToInt32(result.Rows[0][0]);
                    normalnumber.Text = "正常账号数：" + Count.ToString();
                }
                querySql = $"SELECT COUNT(*) FROM reader WHERE Status = 'Freeze';";
                result = _mysqlconnect.ExecuteQuery(querySql);//查询结果为DataTable类型
                if (result.Rows.Count > 0)
                {
                    int Count = Convert.ToInt32(result.Rows[0][0]);
                    freezenumber.Text = "冻结账号数：" + Count.ToString();
                }

            }
            catch (Exception ex)// 捕获所有异常提示操作失败
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //重置按钮
        public void ButtonRecovery()
        {
            management.BackColor = freeze.BackColor = defrost.BackColor = modify.BackColor = SystemColors.ActiveCaption;
            management.Font = freeze.Font = defrost.Font = modify.Font = new Font("华文中宋", 14f, FontStyle.Regular);
            management.Enabled = freeze.Enabled = defrost.Enabled = modify.Enabled = true;
            LoadNumber();
            LoadChart();
        }

        private void management_Click(object sender, EventArgs e)
        {
            ButtonRecovery();//重置按钮颜色
            management.BackColor = SystemColors.GradientInactiveCaption;//选中的栏切换颜色
            management.Font = new Font(management.Font, FontStyle.Bold);
            management.Enabled = false;//选中的栏不能再点击
            accountsList.ReadOnly = true;//根据选中的内容切换表格是否只读
            btnHide();//隐藏所有按钮
            btnAdd.Visible = btnDelete.Visible = true;//只显示这个栏需要的按钮
            LoadAccountsList();//加载表格
        }

        private void freeze_Click(object sender, EventArgs e)
        {
            ButtonRecovery();
            freeze.BackColor = SystemColors.GradientInactiveCaption;
            freeze.Font = new Font(freeze.Font, FontStyle.Bold);
            freeze.Enabled = false;
            accountsList.ReadOnly = true;
            btnHide();
            btnFreeze.Visible = true;
            LoadAccountsList("Normal");
        }

        private void defrost_Click(object sender, EventArgs e)
        {
            ButtonRecovery();
            defrost.BackColor = SystemColors.GradientInactiveCaption;
            defrost.Font = new Font(defrost.Font, FontStyle.Bold);
            defrost.Enabled = false;
            accountsList.ReadOnly = true;
            btnHide();
            btnDefrost.Visible = true;
            LoadAccountsList("Freeze");
        }

        private void modify_Click(object sender, EventArgs e)
        {
            ButtonRecovery();
            modify.BackColor = SystemColors.GradientInactiveCaption;
            modify.Font = new Font(modify.Font, FontStyle.Bold);
            modify.Enabled = false;
            accountsList.ReadOnly = false;
            accountsList.Columns["帐号状态"].ReadOnly = true;
            btnHide();
            btnSave.Visible = true;
            LoadAccountsList();
        }

        private void readernumber_Click(object sender, EventArgs e)
        {
            management_Click(null, null);
        }

        private void normalnumber_Click(object sender, EventArgs e)
        {
            freeze_Click(null, null);
        }

        private void freezenumber_Click(object sender, EventArgs e)
        {
            defrost_Click(null, null);
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            CreateCharts(); //创建图表
            LoadChart();   // 加载图表
        }

        private void AccountsList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (accountsList.CurrentCell == null) return;

            int colIndex = accountsList.CurrentCell.ColumnIndex;

            if (e.Control is TextBox tb)
            {
                // 先移除之前绑定的事件，避免影响其他列
                tb.KeyPress -= TbNumber_KeyPress;

                // 只给借阅数量(索引4)和活动ID(索引5)绑定数字限制
                if (colIndex == 4 || colIndex == 5)
                {
                    tb.KeyPress += TbNumber_KeyPress;
                }
            }
        }

        // 数字输入限制，只能输 0-9 和退格
        private void TbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 阻止输入字母、符号、空格
            }
        }

        #region 绘制左侧三个饼图
        private void CreateCharts()
        {
            // 创建饼图并赋值给成员变量
            chart = CreatePieChart("读者账号状态占比", 30, panel);

        }

        /// <summary>
        /// 创建一个饼图
        /// </summary>
        private Chart CreatePieChart(string title, int y, Control parent)
        {
            Chart chart = new Chart();
            chart.Size = new Size(480, 240);
            chart.Location = new Point(10, y);
            chart.BackColor = SystemColors.GradientInactiveCaption;

            ChartArea area = new ChartArea();
            area.BackColor = SystemColors.GradientInactiveCaption;
            chart.ChartAreas.Add(area);

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX (#PERCENT{P0})";
            series.Font = new Font("微软雅黑", 9);
            chart.Series.Add(series);

            Title chartTitle = new Title(title, Docking.Top, new Font("微软雅黑", 12, FontStyle.Bold), Color.Black);
            chart.Titles.Add(chartTitle);

            parent.Controls.Add(chart);

            // 绑定鼠标悬浮显示数量
            chart.MouseMove += Chart_MouseMove;

            return chart;
        }

        // 鼠标移动时显示饼图详情
        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = sender as Chart;
            HitTestResult result = chart.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint point = (DataPoint)result.Object;
                string title = chart.Titles[0].Text;

                // 图表单位
                string unit = "人";

                string text = $"{point.AxisLabel}：{point.YValues[0]} {unit}";
                chartToolTip.SetToolTip(chart, text);
            }
            else
            {
                chartToolTip.SetToolTip(chart, "");
            }
        }


        #endregion

        // 图表加载数据
        private void LoadChart()
        {
            try
            {
                DataTable dt = _mysqlconnect.ExecuteQuery(@"
                    SELECT 
                        SUM(CASE WHEN Status = 'Normal' THEN 1 ELSE 0 END) AS 正常账号,
                        SUM(CASE WHEN Status = 'Freeze' THEN 1 ELSE 0 END) AS 冻结账号
                    FROM reader");

                chart.Series[0].Points.Clear();
                chart.Series[0].Points.AddXY("正常账号", Convert.ToDouble(dt.Rows[0]["正常账号"]));
                chart.Series[0].Points.AddXY("冻结账号", Convert.ToDouble(dt.Rows[0]["冻结账号"]));
            }
            catch { }
        }

        private void btnHide()//隐藏所有按钮
        {
            btnSave.Visible = btnAdd.Visible = btnDelete.Visible = btnFreeze.Visible = btnDefrost.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(accountsList.DataSource is DataTable dt))
            {
                MessageBox.Show("表格数据异常，无法保存！");
                return;
            }

            if (MessageBox.Show($"确认保存更改吗？保存后无法恢复(状态信息无法修改)", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState == DataRowState.Unchanged)
                        continue;

                    int id = Convert.ToInt32(row["ID"]);
                    string name = row["用户名"]?.ToString() ?? "";
                    string password = row["密码"]?.ToString() ?? "";
                    string number = row["借阅数量"]?.ToString() ?? "";
                    string activity = row["参加活动"]?.ToString() ?? "";

                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("用户名不能为空！", "提示");
                        return;
                    }

                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("密码不能为空！", "提示");
                        return;
                    }

                    if (string.IsNullOrEmpty(number))
                    {
                        MessageBox.Show("借阅数量不能为空！", "提示");
                        return;
                    }
                    if (string.IsNullOrEmpty(activity))
                    {
                        MessageBox.Show("活动ID不能为空！", "提示");
                        return;
                    }

                    // 检查用户名是否重复（排除自己）
                    string checkSql = "SELECT COUNT(*) FROM reader WHERE UserName = @userName AND ID != @id";
                    DataTable checkDt = _mysqlconnect.ExecuteQuery(checkSql,
                        MySQLConnect.Param("@userName", name),
                        MySQLConnect.Param("@id", id));
                    if (Convert.ToInt32(checkDt.Rows[0][0]) > 0)
                    {
                        MessageBox.Show($"用户名【{name}】已存在，请更换！", "提示");
                        return;
                    }

                    string sql = @"
                        UPDATE reader 
                        SET UserName = @userName,
                            Password = @password,
                            Lend_Number = @lendNumber,
                            Activity_ID = @activityId
                        WHERE ID = @id";

                    _mysqlconnect.ExecuteNonQuery(sql,
                        MySQLConnect.Param("@userName", name),
                        MySQLConnect.Param("@password", password),
                        MySQLConnect.Param("@lendNumber", number),
                        MySQLConnect.Param("@activityId", activity),
                        MySQLConnect.Param("@id", id));
                }

                MessageBox.Show("所有修改已保存！", "成功");
                LoadAccountsList();
                LoadNumber();
                LoadChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(accountsList.DataSource is DataTable dt))
            {
                MessageBox.Show("表格数据异常，无法保存！");
                return;
            }

            if (MessageBox.Show($"确认新增账号吗？", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {

                string newUserName = "user" + DateTime.Now.ToString("HHmmss");
                string newPassword = "123456";

                string sql = @"
                    INSERT INTO reader (UserName, Password, Status, Lend_Number, Activity_ID)
                    VALUES (@userName, @password, 'Normal', 0, 0)";

                _mysqlconnect.ExecuteNonQuery(sql,
                    MySQLConnect.Param("@userName", newUserName),
                    MySQLConnect.Param("@password", newPassword));


                MessageBox.Show("新增成功！", "成功");
                LoadAccountsList();//加载表格
                LoadNumber();//加载页面上方数字统计
                LoadChart();//加载图表
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失败：" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要删除的账号！");
                return;
            }

            var row = accountsList.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string name = row.Cells["用户名"].Value?.ToString() ?? "";

            if (MessageBox.Show($"确定删除账号：{name}？", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                string sql = "DELETE FROM reader WHERE ID = @id";
                _mysqlconnect.ExecuteNonQuery(sql, MySQLConnect.Param("@id", id));
                MessageBox.Show("删除成功！");
                LoadAccountsList();
                LoadNumber();
                LoadChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败：" + ex.Message);
            }
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要冻结的账号！");
                return;
            }

            var row = accountsList.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string name = row.Cells["用户名"].Value?.ToString() ?? "";

            if (MessageBox.Show($"确定冻结账号：{name}？", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                string sql = @"
                        UPDATE reader 
                        SET Status = 'Freeze'
                        WHERE ID = @id";
                _mysqlconnect.ExecuteNonQuery(sql, MySQLConnect.Param("@id", id));
                MessageBox.Show("冻结成功！");
                LoadAccountsList("Normal");
                LoadNumber();
                LoadChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("冻结失败：" + ex.Message);
            }
        }

        private void btnDefrost_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要解冻的账号！");
                return;
            }

            var row = accountsList.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string name = row.Cells["用户名"].Value?.ToString() ?? "";

            if (MessageBox.Show($"确定解冻账号：{name}？", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                string sql = @"
                        UPDATE reader 
                        SET Status = 'Normal'
                        WHERE ID = @id";
                _mysqlconnect.ExecuteNonQuery(sql, MySQLConnect.Param("@id", id));
                MessageBox.Show("解冻成功！");
                LoadAccountsList("Freeze");
                LoadNumber();
                LoadChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("解冻失败：" + ex.Message);
            }
        }
    }
}
