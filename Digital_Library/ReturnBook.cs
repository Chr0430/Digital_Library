using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Digital_Library
{
    //归还书籍页面设计
    public partial class ReturnBook : Form
    {
        private Navigation _parentForm;//绑定父页面
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;
        private string thisid = "";//记录所选书的ID
        private string readerid = "";//记录查询的读者ID
        private string thisStatus = "";//记录书籍的借出状态

        public ReturnBook(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";

            _mysqlconnect = new MySQLConnect();

            //绑定表格行点击事件，点击把数据填入文本框
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        #region 搜索按钮，根据用户名查询该用户借出的所有书
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string lendId = txtUsername.Text.Trim();
            
            if (string.IsNullOrEmpty(lendId))
            {
                MessageBox.Show("请输入读者用户名！");
                return;
            }

            string querySql = "SELECT * FROM reader WHERE UserName = @userName";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", lendId));//查询结果为DataTable类型
            if (result.Rows.Count > 0)
            {
                readerid = result.Rows[0]["ID"]?.ToString();
            }
            else
            {
                MessageBox.Show("未查询到您的用户名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 查询Lend_ID = 用户名且Lend_Status不是已归还状态的书
            string sql = @"
                SELECT 
                    ID,
                    Name AS 书名,
                    Author AS 作者,
                    Nationality AS 国籍,
                    Publication_Date AS 出版时间,
                    Type AS 种类,
                    Place AS 存放地点,
                    Lend_Time AS 借出时间,
                    Return_Time AS 归还时间,
                    Lend_Status AS 借出状态
                FROM book
                WHERE Lend_ID = @readerId AND Lend_Status != 'Save'";

            DataTable dt = _mysqlconnect.ExecuteQuery(sql, MySQLConnect.Param("@readerId", readerid));
            LoadBookTable(dt);
        }
        #endregion

        #region 加载表格
        public void LoadBookTable(DataTable dt)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns.Clear();

                // 隐藏ID列
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ID",
                    DataPropertyName = "ID",
                    Visible = false,
                    ReadOnly = true
                });

                // 书名
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "书名",
                    DataPropertyName = "书名",
                    Width = 350,
                    HeaderText = "   书名",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 作者
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "作者",
                    DataPropertyName = "作者",
                    Width = 120,
                    HeaderText = "   作者",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 国籍
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "国籍",
                    DataPropertyName = "国籍",
                    Width = 100,
                    HeaderText = "   国籍",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 出版时间
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "出版时间",
                    DataPropertyName = "出版时间",
                    Width = 140,
                    HeaderText = "   出版时间",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 种类
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "种类",
                    DataPropertyName = "种类",
                    Width = 100,
                    HeaderText = "   种类",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 存放地点
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "存放地点",
                    DataPropertyName = "存放地点",
                    Width = 140,
                    HeaderText = "   存放地点",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 借出时间
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "借出时间",
                    DataPropertyName = "借出时间",
                    Width = 150,
                    HeaderText = "   借出时间",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 归还时间
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "归还时间",
                    DataPropertyName = "归还时间",
                    Width = 150,
                    HeaderText = "   归还时间",
                    ReadOnly = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                // 借出状态
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "借出状态",
                    DataPropertyName = "借出状态",
                    Visible = false, // 不想显示可以设为 false
                    ReadOnly = true
                });

                // 多选框列
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Check";
                checkColumn.HeaderText = "选择";
                checkColumn.Width = 90;
                checkColumn.ReadOnly = false;
                checkColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns.Add(checkColumn);
                dataGridView1.RowTemplate.Height = 70;
                // 绑定数据
                dataGridView1.DataSource = dt;
                
                // 美化配置
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 238, 238);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255);
                

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    DataGridView1_CellClick(this, new DataGridViewCellEventArgs(0, 0));
                }

                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["借出状态"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载失败：" + ex.Message);
            }
        }
        #endregion

        #region 点击表格行数据填入到上方输入框
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                thisid = row.Cells["ID"].Value?.ToString();
                txtBookName.Text = row.Cells["书名"].Value?.ToString();
                txtPublicationDate.Text = row.Cells["出版时间"].Value?.ToString();
                txtType.Text = row.Cells["种类"].Value?.ToString();
                txtAuthor.Text = row.Cells["作者"].Value?.ToString();
                txtNationality.Text = row.Cells["国籍"].Value?.ToString();
                txtPlace.Text = row.Cells["存放地点"].Value?.ToString();
                txtLendTime.Text = row.Cells["借出时间"].Value?.ToString();
                txtReturnTime.Text = row.Cells["归还时间"].Value?.ToString();
                thisStatus = row.Cells["借出状态"].Value?.ToString();
            }
        }
        #endregion

        #region 归还按钮批量归还选中书籍
        private void btnReturn_Click(object sender, EventArgs e)
        {
            List<int> bookIds = new List<int>();
            bool hasCBCBook = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Check"].Value ?? false);
                    if (isChecked)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value);
                        bookIds.Add(id);

                        //判断是否包含云桥连书籍
                        string status = row.Cells["借出状态"].Value?.ToString()?.Trim();
                        if (status == "Lend_CBC")
                        {
                            hasCBCBook = true;
                        }
                    }
                }
                catch { }
            }

            if (bookIds.Count == 0)
            {
                MessageBox.Show("请先勾选要归还的书籍！");
                return;
            }

            //如果包含云桥连书籍，弹出无法恢复警告
            if (hasCBCBook)
            {
                DialogResult dr = MessageBox.Show(
                    "本次归还包含【云桥连借阅书籍】，\n归还后主表数据将永久删除且无法恢复！\n确定继续归还吗？",
                    "高危操作提醒",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dr != DialogResult.Yes)
                {
                    return; //点否直接取消归还
                }
            }
            else
            {
                //普通书籍
                DialogResult normalDr = MessageBox.Show(
                    $"确定要归还选中的 {bookIds.Count} 本书吗？",
                    "归还确认",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (normalDr != DialogResult.Yes)
                {
                    return;
                }
            }

            //遍历每一本选中的书，分别处理
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Check"].Value ?? false);
                    if (isChecked)
                    {
                        int bookId = Convert.ToInt32(row.Cells["ID"].Value);
                        string status = row.Cells["借出状态"].Value.ToString().Trim();

                        //拿到主表带括号的书名，例如 "狼王梦(云桥连借阅)(未到)"
                        string fullName = row.Cells["书名"].Value.ToString().Trim();

                        //自动截取，拿到 "狼王梦" 截取第一个 ( 前面的文字
                        string pureName = fullName.Split('(')[0].Trim();

                        if (status == "Lend")
                        {
                            string sql1 = @"
                                UPDATE book 
                                SET 
                                    Lend_Status = 'Save',
                                    Lend_ID = NULL,
                                    Lend_Time = NULL,
                                    Return_Time = NULL
                                WHERE ID = @bookId";
                            _mysqlconnect.ExecuteNonQuery(sql1, MySQLConnect.Param("@bookId", bookId));
                        }
                        else if (status == "Lend_CBC")
                        {
                            string sql2 = @"
                                UPDATE book_branch
                                SET 
                                    Lend_Status = 'Save',
                                    Lend_ID = NULL,
                                    Lend_Time = NULL,
                                    Return_Time = NULL
                                WHERE Lend_ID = @readerId AND Lend_Status != 'Save' AND Name = @bookName";
                            _mysqlconnect.ExecuteNonQuery(sql2,
                                MySQLConnect.Param("@readerId", readerid),
                                MySQLConnect.Param("@bookName", pureName));

                            string sql3 = "DELETE FROM book WHERE ID = @bookId";
                            _mysqlconnect.ExecuteNonQuery(sql3, MySQLConnect.Param("@bookId", bookId));
                        }
                    }
                }
                catch { }
            }

            //修改reader表中的借书数量
            string _query = "UPDATE reader SET Lend_Number = Lend_Number - @count WHERE ID = @readerId";
            _mysqlconnect.ExecuteNonQuery(_query,
                MySQLConnect.Param("@count", bookIds.Count),
                MySQLConnect.Param("@readerId", readerid));

            MessageBox.Show($"成功归还 {bookIds.Count} 本书！");
            btnSearch_Click(null, null); //刷新表格
        }


        #endregion

        private void btnExtendTime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(thisid))
            {
                MessageBox.Show("请选择一本书！");
                return;
            }

            string newReturnTime = txtReturnTime.Text.Trim();

            if (string.IsNullOrWhiteSpace(newReturnTime))
            {
                MessageBox.Show("归还时间不能为空！");
                return;
            }

            string sql = @"
                UPDATE book 
                SET Return_Time = @returnTime
                WHERE ID = @bookId";

            _mysqlconnect.ExecuteNonQuery(sql,
                MySQLConnect.Param("@returnTime", newReturnTime),
                MySQLConnect.Param("@bookId", thisid));

            if(thisStatus== "Lend_CBC")
            {
                //拿到主表带括号的书名，例如 "狼王梦(云桥连借阅)(未到)"
                string fullName = txtBookName.Text;

                //自动截取，拿到 "狼王梦" 截取第一个 ( 前面的文字
                string pureName = fullName.Split('(')[0].Trim();

                string sqll = @"
                UPDATE book_branch 
                SET Return_Time = @returnTime
                WHERE Name = @bookName";

                _mysqlconnect.ExecuteNonQuery(sqll,
                    MySQLConnect.Param("@returnTime", newReturnTime),
                    MySQLConnect.Param("@bookName", pureName));
            }

            MessageBox.Show($"成功修改归还时间！");
            btnSearch_Click(null, null); //刷新表格
        }
    }
}