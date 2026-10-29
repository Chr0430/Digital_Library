using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Digital_Library
{
    //管理员中心页面设计
    public partial class AdministratorCenter : Form
    {
        private Navigation _parentForm;
        private MySQLConnect _mysqlconnect;
        private readonly string _shareBasePath = AppConfig.ImageFolder;

        // 用成员变量保存3个饼图
        private Chart chartBook;
        private Chart chartActivity;
        private Chart chartBorrow;
        private ToolTip chartToolTip;

        public AdministratorCenter(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";

            _mysqlconnect = new MySQLConnect();
            // 初始化提示框
            chartToolTip = new ToolTip();        // 创建提示框
            chartToolTip.AutoPopDelay = 5000;    // 提示框停留多久
            chartToolTip.InitialDelay = 100;     // 鼠标放上去多久后弹出
            chartToolTip.ReshowDelay = 100;      // 连续切换时多久再弹出


            LoadAdministrator();//加载读者基本账号信息

            // 等窗体加载完成再创建图表
            this.Load += AdministratorCenter_Load;

            // 绑定删除按钮事件
            suggestion.CellContentClick += suggestion_CellContentClick;
        }

        //加载读者信息
        public void LoadAdministrator()
        {
            if (_parentForm.username == "未登录")
            {
                logout.Visible = false;//如果是未登录状态，显示前往登录按钮，退出登录按钮隐藏
                username.Text = booknumber.Text = administratorid.Text = lendnumber.Text = "未登录";
            }
            else
            {
                login.Visible = false;//如果是登录状态，显示退出登录按钮，前往登录按钮隐藏
                try
                {
                    //测试连接是否可用
                    if (!_mysqlconnect.TestConnection())
                    {
                        MessageBox.Show("数据库连接失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //执行查询administrator表，展示结果到对应位置
                    string querySql = "SELECT * FROM administrator WHERE UserName = @userName";
                    DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", _parentForm.username));//查询结果为DataTable类型
                    if (result.Rows.Count > 0)
                    {
                        string id = result.Rows[0]["ID"]?.ToString();
                        administratorid.Text = id;
                        username.Text = _parentForm.username;
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    string querySqll = $"SELECT COUNT(*) FROM book;";
                    DataTable resultt = _mysqlconnect.ExecuteQuery(querySqll);//查询结果为DataTable类型
                    if (resultt.Rows.Count > 0)
                    {
                        int bookCount = Convert.ToInt32(resultt.Rows[0][0]);
                        booknumber.Text = bookCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    string querySqlll = $"SELECT COUNT(*) FROM book WHERE Lend_Status = 'Lend' OR Lend_Status = 'Lend_CBC';";
                    DataTable resulttt = _mysqlconnect.ExecuteQuery(querySqlll);//查询结果为DataTable类型
                    if (resulttt.Rows.Count > 0)
                    {
                        int bookCount = Convert.ToInt32(resulttt.Rows[0][0]);
                        lendnumber.Text = bookCount.ToString();
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



        private void AdministratorCenter_Load(object sender, EventArgs e)
        {
            CreateLeftCharts();
            // 图表创建完成后，直接用成员变量加载测试数据
            LoadBookStatusChart();   // 图书状态
            LoadActivityChart();     // 活动参与人数
            LoadBorrowCountChart(); // 借书数量统计

            LoadSuggestionTable();

            label.Text = GetRandomEncourageText();
        }

        #region 绘制左侧三个饼图
        private void CreateLeftCharts()
        {
            // 创建饼图并赋值给成员变量
            chartBook = CreatePieChart("图书借出状态占比", 30, panel);
            chartActivity = CreatePieChart("活动参与人数占比", 300, panel);
            chartBorrow = CreatePieChart("读者借书数量分布", 570, panel);
        }

        /// <summary>
        /// 创建一个饼图
        /// </summary>
        private Chart CreatePieChart(string title, int y, Control parent)
        {
            Chart chart = new Chart();
            chart.Size = new Size(480, 240);
            chart.Location = new Point(10, y);
            chart.BackColor = SystemColors.Control;

            ChartArea area = new ChartArea();
            area.BackColor = SystemColors.Control;
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

                // 根据图表标题判断单位
                string unit = title.Contains("图书") ? "本" : "人";

                string text = $"{point.AxisLabel}：{point.YValues[0]} {unit}";
                chartToolTip.SetToolTip(chart, text);
            }
            else
            {
                chartToolTip.SetToolTip(chart, "");
            }
        }


        #endregion

        #region 数据库加载
        // 图书借出/在馆占比
        private void LoadBookStatusChart()
        {
            try
            {
                DataTable dt = _mysqlconnect.ExecuteQuery(@"
                    SELECT 
                        SUM(CASE WHEN Lend_Status = 'Lend' OR Lend_Status = 'Lend_CBC' THEN 1 ELSE 0 END) AS 已借出,
                        SUM(CASE WHEN Lend_Status = 'Save' THEN 1 ELSE 0 END) AS 在馆
                    FROM book");

                chartBook.Series[0].Points.Clear();
                chartBook.Series[0].Points.AddXY("已借出", Convert.ToDouble(dt.Rows[0]["已借出"]));
                chartBook.Series[0].Points.AddXY("在馆", Convert.ToDouble(dt.Rows[0]["在馆"]));
            }
            catch { }
        }

        // 各活动参与人数占比
        private void LoadActivityChart()
        {
            try
            {
                DataTable dt = _mysqlconnect.ExecuteQuery(@"
                    SELECT 
                        a.ID,
                        a.Name, 
                        COUNT(r.ID) AS 参与人数
                    FROM activity a
                    LEFT JOIN reader r ON a.ID = r.Activity_ID
                    GROUP BY a.ID, a.Name");

                chartActivity.Series[0].Points.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["Name"].ToString();
                    int count = Convert.ToInt32(row["参与人数"]);
                    chartActivity.Series[0].Points.AddXY(name, count);
                }
            }
            catch { }
        }

        // 借书数量0/1/2/3本及以上
        private void LoadBorrowCountChart()
        {
            try
            {
                DataTable dt = _mysqlconnect.ExecuteQuery(@"
                    SELECT 
                        SUM(CASE WHEN Lend_Number = 0 THEN 1 ELSE 0 END) AS c0,
                        SUM(CASE WHEN Lend_Number = 1 THEN 1 ELSE 0 END) AS c1,
                        SUM(CASE WHEN Lend_Number = 2 THEN 1 ELSE 0 END) AS c2,
                        SUM(CASE WHEN Lend_Number >=3 THEN 1 ELSE 0 END) AS c3
                    FROM reader");

                chartBorrow.Series[0].Points.Clear();
                chartBorrow.Series[0].Points.AddXY("0本", Convert.ToDouble(dt.Rows[0]["c0"]));
                chartBorrow.Series[0].Points.AddXY("1本", Convert.ToDouble(dt.Rows[0]["c1"]));
                chartBorrow.Series[0].Points.AddXY("2本", Convert.ToDouble(dt.Rows[0]["c2"]));
                chartBorrow.Series[0].Points.AddXY("3本及以上", Convert.ToDouble(dt.Rows[0]["c3"]));
            }
            catch { }
        }
        #endregion

        // 加载suggestion表数据到表格
        private void LoadSuggestionTable()
        {
            try
            {
                DataTable dt = _mysqlconnect.ExecuteQuery("SELECT ID, Name, Author, Reader FROM suggestion");
                dt.Columns["ID"].ColumnName = "  编号";      // 把ID改成编号
                dt.Columns["Name"].ColumnName = "  书名";    // 把Name改成书名
                dt.Columns["Author"].ColumnName = "  作者";  // 把Author改成作者
                dt.Columns["Reader"].ColumnName = "  用户名";

                suggestion.DataSource = dt;

                // 删除按钮永远显示在最右边
                suggestion.Columns["ColumnDelete"].DisplayIndex = suggestion.Columns.Count - 1;
            }
            catch { }
        }

        // 表格删除按钮点击事件
        private void suggestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 处理点击按钮的情况
            if (e.RowIndex < 0 || e.ColumnIndex != suggestion.Columns["ColumnDelete"].Index)
                return;

            // 获取当前行的 ID
            int id = Convert.ToInt32(suggestion.Rows[e.RowIndex].Cells["  编号"].Value);
            string name = suggestion.Rows[e.RowIndex].Cells["  书名"].Value.ToString();
            if(name == "/")
            {
                name = suggestion.Rows[e.RowIndex].Cells["  作者"].Value.ToString();
            }
            // 确认删除
            if (MessageBox.Show($"确定要删除 建议 {id}：{name} 吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // 执行数据库删除
                    _mysqlconnect.ExecuteNonQuery("DELETE FROM suggestion WHERE ID = @id", MySQLConnect.Param("@id", id));

                    // 刷新表格
                    LoadSuggestionTable();

                    MessageBox.Show("删除成功！");
                }
                catch
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        // 随机鼓励语句
        private string GetRandomEncourageText()
        {
            List<string> list = new List<string>
            {
                "今天也要加油呀！",
                "你超棒的，继续保持！",
                "慢慢来，一切都会越来越好。",
                "努力不会白费，时间会给答案。",
                "保持热爱，奔赴山海。",
                "别放弃，你离成功很近了。",
                "每天进步一点点，就是最大的收获。",
                "相信自己，你远比想象中强大。",
                "生活明朗，万物可爱，未来可期。",
                "认真生活的人，都会被温柔以待。"
            };

            Random rnd = new Random();
            return list[rnd.Next(list.Count)];
        }

        private void login_Click(object sender, EventArgs e)
        {
            _parentForm.OpenLogIn();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            _parentForm.LogOut();
        }

        private void enterBooks_Click(object sender, EventArgs e)
        {
            _parentForm.OpenEnterBooks();
        }
    }
}