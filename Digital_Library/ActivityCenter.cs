using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Digital_Library
{
    //活动中心页面设计
    public partial class ActivityCenter : Form
    {
        private Navigation _parentForm;
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径
        bool isWhite = true;
        public ActivityCenter(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            LoadActivityCard();
        }

        /// <summary>
        /// 添加一个活动卡片
        /// </summary>
        private void AddActivityCard(int ID, string actTitle, string time, string place,string content, int x,int y)
        {
            //创建卡片容器
            Panel card = new Panel();
            card.Size = new Size(1000, 150);
            card.Location = new Point(x, y);
            card.BackColor = isWhite ? Color.White : Color.FromArgb(252, 248, 240);//卡片背景白色与米白色交替

            //绘制圆角边框
            card.Paint += (s, e) =>
            {
                Rectangle rect = card.ClientRectangle;
                int r = 16; // 圆角半径

                e.Graphics.Clear(card.BackColor);//边框覆盖为背景色

                //绘制边框
                using (Pen pen = new Pen(Color.LightGray, 1))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    //圆角矩形
                    e.Graphics.DrawArc(pen, rect.X, rect.Y, r, r, 180, 90);
                    e.Graphics.DrawArc(pen, rect.Right - r, rect.Y, r, r, 270, 90);
                    e.Graphics.DrawArc(pen, rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                    e.Graphics.DrawArc(pen, rect.X, rect.Bottom - r, r, r, 90, 90);

                    // 补全四条边
                    e.Graphics.DrawLine(pen, rect.X + r / 2, rect.Y, rect.Right - r / 2, rect.Y);
                    e.Graphics.DrawLine(pen, rect.Right, rect.Y + r / 2, rect.Right, rect.Bottom - r / 2);
                    e.Graphics.DrawLine(pen, rect.X + r / 2, rect.Bottom, rect.Right - r / 2, rect.Bottom);
                    e.Graphics.DrawLine(pen, rect.X, rect.Y + r / 2, rect.X, rect.Bottom - r / 2);
                }
            };

            this.Controls.Add(card);

            //添加标题
            Label Title = new Label();
            Title.Text = actTitle;
            Title.Font = new Font("微软雅黑", 14, FontStyle.Bold);
            Title.Location = new Point(20, 15); // 卡片内部左边距
            Title.AutoSize = true;
            card.Controls.Add(Title);

            //添加时间
            Label Time = new Label();
            Time.Text = time;
            Time.Font = new Font("微软雅黑", 10);
            Time.ForeColor = Color.Gray;
            Time.Location = new Point(20, 45);
            Time.AutoSize = true;
            card.Controls.Add(Time);

            //添加地点
            Label Place = new Label();
            Place.Text = place;
            Place.Font = new Font("微软雅黑", 10);
            Place.ForeColor = Color.Gray;
            Place.Location = new Point(300, 45);
            Place.AutoSize = true;
            card.Controls.Add(Place);

            //添加内容
            Label Content = new Label();
            Content.Text = content;
            Content.Font = new Font("微软雅黑", 10);
            Content.Location = new Point(20, 70);
            Content.Size = new Size(750, 40);
            Content.AutoSize = false;
            card.Controls.Add(Content);

            //添加报名按钮
            Button btn = new Button();
            btn.Text = "我要报名";
            btn.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            btn.Size = new Size(100, 45);
            btn.Location = new Point(850, 35);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(52, 152, 219);
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;

            //按钮点击事件
            btn.Click += (s, e) =>
            {
                Attend(ID);
            };
            card.Controls.Add(btn);
        }

        public void LoadActivityCard()
        {
            //执行查询操作
            string querySql = $"SELECT * FROM activity ORDER BY RAND() LIMIT 4";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql);//查询结果为DataTable类型

            int x = 180;// 卡片起始 X 坐标
            int y = 100;// 卡片起始 Y 坐标

            // 循环读取数据库每一行
            foreach (DataRow row in result.Rows)
            {
                int ID = row["ID"] != DBNull.Value ? Convert.ToInt32(row["ID"]) : 0;
                string Name = row["Name"]?.ToString() ?? "未命名活动";
                string Time = "活动时间：" + (row["Time"]?.ToString() ?? "未设置时间");
                string Place = "活动地点：" + (row["Place"]?.ToString() ?? "未设置时间");
                string Introduction = row["Introduction"]?.ToString() ?? "暂无介绍";

                // 添加卡片
                AddActivityCard(ID, Name, Time, Place, Introduction, x, y);

                // 下一个卡片左右移动
                if (x == 180)
                {
                    x += 300;
                }
                else
                {
                    x -= 300;
                }
                //卡片颜色交替
                isWhite = !isWhite;
                // 下一个卡片往下移 150
                y += 180;
            }
        }

        public void Attend(int ID)
        {
            //执行查询操作
            string querySql = "SELECT * FROM reader WHERE UserName = @userName";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", _parentForm.username));//查询结果为DataTable类型
            int Activity = -1;
            foreach (DataRow row in result.Rows)
            {
                Activity = row["Activity_ID"] != DBNull.Value ? Convert.ToInt32(row["Activity_ID"]) : -1;//提取reader表中Activity_ID数据
            }
            if(Activity == -1)
            {
                MessageBox.Show("您不是读者身份！无法参加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//没有查询到数据
                return;
            }
            else if(Activity != 0)
            {
                MessageBox.Show("您已参加活动了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//已填入数据
                return;
            }

            string query = "UPDATE reader SET Activity_ID = @activityId WHERE UserName = @userName";
            _mysqlconnect.ExecuteNonQuery(query,
                MySQLConnect.Param("@activityId", ID),
                MySQLConnect.Param("@userName", _parentForm.username));
            MessageBox.Show("报名成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void change_Click(object sender, EventArgs e)
        {
            _parentForm.CloseChildForm();//关闭页面
            _parentForm.OpenActivityCenter(); // 调用父窗体的OpenActivityCenter方法打开活动中心页面
        }
    }
}
