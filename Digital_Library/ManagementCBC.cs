using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Digital_Library
{
    //云桥连管理页面设计
    public partial class ManagementCBC : Form
    {
        private Navigation _parentForm;//绑定父页面
        public string BookID = "";//书籍ID
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径

        public ManagementCBC(Navigation parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            LoadBooksList(noArrivedList,"(云桥连借阅)(未到)");
            LoadBooksList(ArrivedList, "(云桥连借阅)(已到)");
        }

        #region 表格加载
        public void LoadBooksList(DataGridView List,string Status)
        {
            try
            {
                string sql = "SELECT ID, Name AS 书名, Author AS 作者, Nationality AS 国籍, Type AS 种类 FROM book";

                DataTable dt;
                if (string.IsNullOrEmpty(Status))
                {
                    dt = _mysqlconnect.ExecuteQuery(sql);
                }
                else
                {
                    dt = _mysqlconnect.ExecuteQuery(sql + " WHERE Name LIKE @status",
                        MySQLConnect.Param("@status", "%" + Status + "%"));
                }

                List.AutoGenerateColumns = false;
                List.ReadOnly = false;
                List.Columns.Clear();

                List.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ID",
                    DataPropertyName = "ID",
                    Visible = false, // 隐藏ID列
                    ReadOnly = true
                });

                // 书名
                List.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "  书名",
                    DataPropertyName = "书名",
                    Width = 250,
                    HeaderText = "书名",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 作者
                List.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "  作者",
                    DataPropertyName = "作者",
                    Width = 90,
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 国籍
                List.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "  国籍",
                    DataPropertyName = "国籍",
                    Width = 90,
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 种类
                List.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "  种类",
                    DataPropertyName = "种类",
                    Width = 90,
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 最右侧加多选框
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Check";
                checkColumn.HeaderText = "选择";
                checkColumn.Width = 60;
                checkColumn.ReadOnly = false;
                checkColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                List.Columns.Add(checkColumn);

                // 绑定数据
                List.DataSource = dt;

                List.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 点击任意单元格选中整行
                List.MultiSelect = true; // 禁止多选，一次只选一行
                List.RowHeadersVisible = false;

                List.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 235, 250);


                foreach (DataGridViewColumn col in List.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // 表头居中
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // 内容居中
                }

                List.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载表格失败：" + ex.Message);
            }
        }
        #endregion

        #region  一键获取未到书籍中所有勾选的书籍ID
        public List<int> GetCheckedBookIDs()
        {
            List<int> ids = new List<int>();

            foreach (DataGridViewRow row in noArrivedList.Rows)
            {
                // 判断是否勾选
                if (row.Cells["Check"] != null && Convert.ToBoolean(row.Cells["Check"].Value) == true)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    ids.Add(id);
                }
            }
            return ids;
        }
        #endregion

        #region  一键获取已到书籍中所有勾选的书籍ID
        public List<int> _GetCheckedBookIDs()
        {
            List<int> ids = new List<int>();

            foreach (DataGridViewRow row in ArrivedList.Rows)
            {
                // 判断是否勾选
                if (row.Cells["Check"] != null && Convert.ToBoolean(row.Cells["Check"].Value) == true)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    ids.Add(id);
                }
            }
            return ids;
        }
        #endregion

        #region 切换为已到达
        private void btnArrived_Click(object sender, EventArgs e)
        {
            var ids = GetCheckedBookIDs();
            if (ids.Count == 0)
            {
                MessageBox.Show("请先勾选书籍！");
                return;
            }

            // 批量更新书籍状态为已到达（使用参数化占位符，避免拼接 ID 带来的注入风险）
            string[] parameterNames = new string[ids.Count];
            MySqlConnector.MySqlParameter[] parameters = new MySqlConnector.MySqlParameter[ids.Count];
            for (int i = 0; i < ids.Count; i++)
            {
                parameterNames[i] = "@id" + i;
                parameters[i] = MySQLConnect.Param(parameterNames[i], ids[i]);
            }

            string sql = $"UPDATE book SET Name = REPLACE(Name, '未到', '已到') WHERE ID IN ({string.Join(",", parameterNames)})";
            _mysqlconnect.ExecuteNonQuery(sql, parameters);

            MessageBox.Show($"已处理 {ids.Count} 本书！书名已自动更新");
            LoadBooksList(noArrivedList, "(云桥连借阅)(未到)");
            LoadBooksList(ArrivedList, "(云桥连借阅)(已到)");
        }

        #endregion

        private void btnNOArrived_Click(object sender, EventArgs e)
        {
            var ids = _GetCheckedBookIDs();
            if (ids.Count == 0)
            {
                MessageBox.Show("请先勾选书籍！");
                return;
            }

            // 批量更新书籍状态为未到达（使用参数化占位符，避免拼接 ID 带来的注入风险）
            string[] parameterNames = new string[ids.Count];
            MySqlConnector.MySqlParameter[] parameters = new MySqlConnector.MySqlParameter[ids.Count];
            for (int i = 0; i < ids.Count; i++)
            {
                parameterNames[i] = "@id" + i;
                parameters[i] = MySQLConnect.Param(parameterNames[i], ids[i]);
            }

            string sql = $"UPDATE book SET Name = REPLACE(Name, '已到', '未到') WHERE ID IN ({string.Join(",", parameterNames)})";
            _mysqlconnect.ExecuteNonQuery(sql, parameters);

            MessageBox.Show($"已处理 {ids.Count} 本书！书名已自动更新");
            LoadBooksList(noArrivedList, "(云桥连借阅)(未到)");
            LoadBooksList(ArrivedList, "(云桥连借阅)(已到)");
        }
    }
}
