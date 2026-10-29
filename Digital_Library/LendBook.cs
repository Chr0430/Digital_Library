using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Digital_Library
{
    //借阅书籍页面设计
    public partial class LendBook : Form
    {
        private Navigation _parentForm;//绑定父页面
        public string BookID = "";//书籍ID
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径

        public LendBook(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";
            Cover.SizeMode = PictureBoxSizeMode.Zoom;// 初始化自适应图片
            password1.PasswordChar = '*';//输入密码时显示为*
            password2.PasswordChar = '*';//输入密码时显示为*

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();
            //借阅时间选项
            Date.Items.AddRange(new string[] {
                "3",
                "5",
                "7",
                "15",
                "30"
            });
        }

        /// <summary>
        /// 通过书籍ID查找书籍信息
        /// </summary>
        /// <param name="inputBookId">输入的书籍ID</param>
        public void LoadBookByID(string inputBookId)
        {
            BookID = inputBookId?.Trim() ?? "";//去掉空格，避免匹配失败
            Load_Cover(null, null);
            Load_Book(null, null);
            username.Text = _parentForm.username;
        }

        //加载书名
        private void Load_Book(object sender, EventArgs e)
        {
            //执行查询操作，展示结果到对应位置
            string querySql = "SELECT * FROM book WHERE ID = @bookId";
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@bookId", BookID));//查询结果为DataTable类型
            if (result.Rows.Count > 0)
            {
                string bookName = result.Rows[0]["Name"]?.ToString() ?? "未知书名";
                BookName.Text = bookName;
            }
        }

        #region 加载书籍封面图片
        /// <summary>
        /// 加载书籍封面图片
        /// </summary>
        private void Load_Cover(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT cover FROM book WHERE ID = @bookId;";//搜索书籍封面图片名
                DataTable dt = _mysqlconnect.ExecuteQuery(sql, MySQLConnect.Param("@bookId", BookID));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"未找到ID为 {BookID} 的图书记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cover.Image = null;
                    return;
                }

                //提取图片文件名
                object coverObj = dt.Rows[0]["cover"];//提取书籍封面图片名
                //数据库中Cover为空时返回
                if (coverObj == DBNull.Value || string.IsNullOrEmpty(coverObj.ToString().Trim()))
                {
                    MessageBox.Show($"ID为 {BookID} 的图书无封面文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cover.Image = null;
                    return;
                }
                string imgFileName = coverObj.ToString().Trim();//转换成String

                //拼接完整图片共享路径
                string fullSharePath = Path.Combine(_shareBasePath, imgFileName);
                // 替换路径分隔符为UNC格式（避免/和\混用）
                fullSharePath = fullSharePath.Replace('/', '\\');

                //检查共享路径是否可访问
                if (!Directory.Exists(_shareBasePath))
                {
                    MessageBox.Show($"图片目录不可用：{_shareBasePath}\n请检查该目录是否存在；如需指定位置，请在 App.config 的 ImageFolder 中填写路径（留空时自动在程序目录上层查找 Digital_Library_Picture）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cover.Image = null;
                    return;
                }

                //加载共享路径图片
                LoadImageFromSharePath(fullSharePath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"加载失败：图片文件不存在【{ex.FileName}】", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cover.Image = null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("加载失败：无读取图片目录的权限！\n请检查该目录的读取权限。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cover.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cover.Image = null;
            }
        }

        // 共享路径图片加载
        private void LoadImageFromSharePath(string fullSharePath)
        {
            if (string.IsNullOrEmpty(fullSharePath))
                throw new ArgumentNullException("共享图片路径不能为空");

            // UNC路径不使用Path.GetFullPath（避免解析错误）
            if (!File.Exists(fullSharePath))
            {
                throw new FileNotFoundException("共享图片文件不存在", fullSharePath);
            }

            // 加载图片
            using (var bmp = new Bitmap(fullSharePath))
            {
                // 深拷贝避免共享文件被锁定
                Cover.Image = new Bitmap(bmp);
            }
        }

        #endregion

        //取消借阅按钮返回上一页面
        private void cancel_Click(object sender, EventArgs e)
        {
            _parentForm.CloseChildForm();
        }

        //确认借阅按钮
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Date.Text == "")//没有选择借阅时间
            {
                MessageBox.Show("请输入借阅时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (password1.Text == "")//没有输入密码
            {
                MessageBox.Show("请输入用户密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (password2.Text == "")//没有重复输入密码
            {
                MessageBox.Show("请再次输入用户密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (password1.Text != password2.Text)//重复输入密码与第一遍不同
            {
                MessageBox.Show("用户密码有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string querySql = "SELECT * FROM reader WHERE UserName = @userName";//使用reader表中的用户名搜索
            DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", username.Text));
            if (result.Rows.Count == 0)//用户名有误
            {
                MessageBox.Show("用户名有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string password = result.Rows[0]["Password"]?.ToString();
            string userID= result.Rows[0]["ID"]?.ToString();
            if (password1.Text != password)//输入的密码有误
            {
                MessageBox.Show("用户密码有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!checkBox.Checked)//没有勾选同意
            {
                MessageBox.Show("请勾选同意", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            DateTime lendDate = DateTime.Now; //当前的时间
            int.TryParse(Date.Text, out int borrowDays);
            DateTime returnDate = lendDate.AddDays(borrowDays); //归还的时间

            //修改book表中的数据
            string query = "UPDATE book SET Lend_Status = 'Lend', Lend_ID = @lendId, " +
                           "Lend_Time = @lendTime, Return_Time = @returnTime WHERE ID = @bookId";
            _mysqlconnect.ExecuteNonQuery(query,
                MySQLConnect.Param("@lendId", userID),
                MySQLConnect.Param("@lendTime", lendDate.ToString("yyyy-MM-dd")),
                MySQLConnect.Param("@returnTime", returnDate.ToString("yyyy-MM-dd")),
                MySQLConnect.Param("@bookId", BookID));

            //修改reader表中的借书数量
            string _query = "UPDATE reader SET Lend_Number = Lend_Number + 1 WHERE ID = @readerId";
            _mysqlconnect.ExecuteNonQuery(_query, MySQLConnect.Param("@readerId", userID));

            MessageBox.Show("借阅成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _parentForm.CloseChildForm();//关闭借书页面
            _parentForm.CloseChildForm();//关闭详情页面
        }
    }
}
