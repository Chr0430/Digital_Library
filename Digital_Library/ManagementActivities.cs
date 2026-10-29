using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Digital_Library
{
    //活动管理页面设计
    public partial class ManagementActivities : Form
    {
        private Navigation _parentForm;//绑定父页面
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径

        public ManagementActivities(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";


            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            //活动状态选项
            comboBox.Items.AddRange(new string[] {
                "已结束",
                "进行中",
                "未开始"
            });
            comboBox.SelectedIndex = 2;


            LoadActivities();
            LoadActivitiesList(); // 加载表格数据
            AddPanel.Visible = false;
            ManagementPanel.Visible = false;
            textBox.Visible = false;
        }

        //加载活动信息
        public void LoadActivities()
        {
            if (_parentForm.username == "未登录")
            {
                total.Text = finished.Text = ongoing.Text = unstarted.Text = "未登录";
            }
            else
            {
                try
                {
                    //测试连接是否可用
                    if (!_mysqlconnect.TestConnection())
                    {
                        MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //执行查询activity表，展示结果到对应位置
                    string querySql = $"SELECT COUNT(*) FROM activity;";
                    DataTable result = _mysqlconnect.ExecuteQuery(querySql);//查询结果为DataTable类型
                    if (result.Rows.Count > 0)
                    {
                        int totalCount = Convert.ToInt32(result.Rows[0][0]);
                        total.Text = totalCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    string querySqll = $"SELECT COUNT(*) FROM activity WHERE Status = '已结束'";
                    DataTable resultt = _mysqlconnect.ExecuteQuery(querySqll);//查询结果为DataTable类型
                    if (resultt.Rows.Count > 0)
                    {
                        int finishedCount = Convert.ToInt32(resultt.Rows[0][0]);
                        finished.Text = finishedCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    string querySqlll = $"SELECT COUNT(*) FROM activity WHERE Status = '进行中'";
                    DataTable resulttt = _mysqlconnect.ExecuteQuery(querySqlll);//查询结果为DataTable类型
                    if (resulttt.Rows.Count > 0)
                    {
                        int ongoingCount = Convert.ToInt32(resulttt.Rows[0][0]);
                        ongoing.Text = ongoingCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    string querySqllll = $"SELECT COUNT(*) FROM activity WHERE Status = '未开始'";
                    DataTable resultttt = _mysqlconnect.ExecuteQuery(querySqllll);//查询结果为DataTable类型
                    if (resultttt.Rows.Count > 0)
                    {
                        int unstartedCount = Convert.ToInt32(resultttt.Rows[0][0]);
                        unstarted.Text = unstartedCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)// 捕获所有异常提示操作失败
                {
                    MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region 表格加载
        public void LoadActivitiesList(string filterStatus = "")
        {
            try
            {
                string sql = "SELECT ID, Name AS 活动名称, Time AS 活动时间, Place AS 活动地点, Introduction AS 活动介绍, Status AS 状态 FROM activity";
                DataTable dt;
                if (!string.IsNullOrEmpty(filterStatus))
                {
                    dt = _mysqlconnect.ExecuteQuery(sql + " WHERE Status = @status", MySQLConnect.Param("@status", filterStatus));
                }
                else
                {
                    dt = _mysqlconnect.ExecuteQuery(sql);
                }
                activitiesList.DataSource = dt;

                

                if (activitiesList.Columns["ID"] != null)
                    activitiesList.Columns["ID"].Visible = false;

                activitiesList.Columns[1].Width = 80;
                activitiesList.Columns[2].Width = 150;
                activitiesList.Columns[3].Width = 85;
                activitiesList.Columns[4].Width = 100;
                activitiesList.Columns[5].Width = 54;


                foreach (DataGridViewColumn col in activitiesList.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // 表头居中
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载表格失败：" + ex.Message);
            }
        }
        #endregion

        #region 保存修改按钮，一次性保存表格所有编辑
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(activitiesList.DataSource is DataTable dt))
            {
                MessageBox.Show("表格数据异常，无法保存！");
                return;
            }

            if (MessageBox.Show($"确认保存更改吗？保存后无法恢复", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState == DataRowState.Unchanged)
                        continue;

                    int id = Convert.ToInt32(row["ID"]);
                    string name = row["活动名称"]?.ToString() ?? "";
                    string time = row["活动时间"]?.ToString() ?? "";
                    string place = row["活动地点"]?.ToString() ?? "";
                    string intro = row["活动介绍"]?.ToString() ?? "";
                    string status = row["状态"]?.ToString() ?? "";

                    string sql = @"
                        UPDATE activity 
                        SET Name = @name,
                            Time = @time,
                            Place = @place,
                            Introduction = @introduction,
                            Status = @status
                        WHERE ID = @id";

                    _mysqlconnect.ExecuteNonQuery(sql,
                        MySQLConnect.Param("@name", name),
                        MySQLConnect.Param("@time", time),
                        MySQLConnect.Param("@place", place),
                        MySQLConnect.Param("@introduction", intro),
                        MySQLConnect.Param("@status", status),
                        MySQLConnect.Param("@id", id));
                }

                MessageBox.Show("所有修改已保存！", "成功");
                LoadActivities();
                LoadActivitiesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }
        #endregion

        #region 删除选中行按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (activitiesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要删除的行！");
                return;
            }

            var row = activitiesList.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string name = row.Cells["活动名称"].Value?.ToString() ?? "";

            if (MessageBox.Show($"确定删除活动：{name}？", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                string sql = "DELETE FROM activity WHERE ID = @id";
                _mysqlconnect.ExecuteNonQuery(sql, MySQLConnect.Param("@id", id));
                string sqll = @"
                        UPDATE reader 
                        SET Activity_ID = '0'
                        WHERE Activity_ID = @activityId";
                _mysqlconnect.ExecuteNonQuery(sqll, MySQLConnect.Param("@activityId", id));
                MessageBox.Show("删除成功！");
                LoadActivities();
                LoadActivitiesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败：" + ex.Message);
            }
        }
        #endregion



        public void AddLoad()
        {
            ManagementButton.Visible = false;
            AddPanel.Visible = true;
        }
        public void AddUnLoad()
        {
            ManagementButton.Visible = true;
            AddPanel.Visible = false;
        }
        public void ManagementLoad()
        {
            AddButton.Visible = false;
            ManagementPanel.Visible = true;
        }
        public void ManagementUnLoad()
        {
            AddButton.Visible = true;
            ManagementPanel.Visible = false;
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ManagementButton.Visible == true)
            {
                AddLoad();
            }
            else if (ManagementButton.Visible == false)
            {
                AddUnLoad();
            }
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            if (AddButton.Visible == true)
            {
                ManagementLoad();
            }
            else if (AddButton.Visible == false)
            {
                ManagementUnLoad();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Visible == true)
            {
                dateTimePicker.Visible = false;
                textBox.Visible = true;
            }
            else if (dateTimePicker.Visible == false)
            {
                textBox.Visible = false;
                dateTimePicker.Visible = true;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string Date = "";
            DateTime time = dateTimePicker.Value.Date;
            string activitytime = time.ToString("yyyy-MM-dd");
            if (activityName.Text == "")//没有输入活动名称
            {
                MessageBox.Show("请输入活动名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (place.Text == "")//没有输入活动地点
            {
                MessageBox.Show("请输入活动地点", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (time1.Text == ""|| time2.Text == ""|| time3.Text == ""|| time4.Text == "")//没有输入活动时间
            {
                MessageBox.Show("请输入活动时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (comboBox.Text == "")//没有输入活动类型
            {
                MessageBox.Show("请选择活动类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dateTimePicker.Visible == true)
            {
                Date = dateTimePicker.Text;
            }
            else if (textBox.Visible == true)
            {
                Date = textBox.Text;
            }
            if(Date == "")
            {
                MessageBox.Show("请输入活动时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dateTimePicker.Visible == true)
            {
                Date = activitytime + " " + time1.Text + ":" + time2.Text + "-" + time3.Text + ":" + time4.Text;
            }
            else if (textBox.Visible == true)
            {
                Date = Date + " " + time1.Text + ":" + time2.Text + "-" + time3.Text + ":" + time4.Text;
            }
            string query = "INSERT INTO activity(Name,Time,Place,Introduction,Status) " +
               "VALUES (@name,@time,@place,@introduction,@status)";

            _mysqlconnect.ExecuteNonQuery(query,
                MySQLConnect.Param("@name", activityName.Text),
                MySQLConnect.Param("@time", Date),
                MySQLConnect.Param("@place", place.Text),
                MySQLConnect.Param("@introduction", introduction.Text),
                MySQLConnect.Param("@status", comboBox.Text));
            LoadActivities();
            LoadActivitiesList();
            MessageBox.Show("活动添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
