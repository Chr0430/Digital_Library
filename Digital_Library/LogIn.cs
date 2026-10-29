using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Digital_Library
{
    //登录页面设计
    public partial class LogIn : Form
    {
        private Navigation _parentForm;//绑定父页面
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径
        private bool isShowPassword = false;

        public LogIn(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";
            PrecautionsData();//加载注意事项文字
            Load_BackgroundImage();//加载注意事项背景图片
            password.PasswordChar = '*';//输入密码时显示为*
            

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();
        }

        //以读者身份登录和以管理员身份登录不可同时选择
        private void reader_Click(object sender, EventArgs e)
        {
            administrator.Checked = false;
        }

        private void administrator_Click(object sender, EventArgs e)
        {
            reader.Checked = false;
        }


        //加载注意事项文字
        private void PrecautionsData()
        {
            precautions.AutoSize = false;
            precautions.Size = new Size(350, 800); // 宽度固定，高度足够容纳内容

            precautions.Text = "\r\n注意事项：" +
        "\r\n\r\n 1. 该账号仅用于本图书馆程序登录；" +
        "\r\n\r\n 2. 请选择正确的身份类型（读者/管理员），身份不符将无法操作对应功能；" +
        "\r\n\r\n 3. 忘记密码可联系图书馆管理员重置，请勿尝试暴力破解；" +
        "\r\n\r\n 4. 请勿借用他人账号登录；" +
        "\r\n\r\n 5. AI功能仅支持图书检索、借阅咨询，不处理敏感信息；" +
        "\r\n\r\n 6. AI生成内容仅供参考，最终以图书馆实际规则为准。";
        }

        #region 加载注意事项背景图片
        /// <summary>
        /// 加载注意事项背景图片
        /// </summary>
        private void Load_BackgroundImage()
        {
            try
            {
                string imgFileName = "BackgroundImage.jpg";//图片文件名
                //拼接完整图片共享路径
                string fullSharePath = Path.Combine(_shareBasePath, imgFileName);
                // 替换路径分隔符为UNC格式（避免/和\混用）
                fullSharePath = fullSharePath.Replace('/', '\\');

                //检查共享路径是否可访问
                if (!Directory.Exists(_shareBasePath))
                {
                    MessageBox.Show($"图片目录不可用：{_shareBasePath}\n请检查该目录是否存在；如需指定位置，请在 App.config 的 ImageFolder 中填写路径（留空时自动在程序目录上层查找 Digital_Library_Picture）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Backpanel.BackgroundImage = null;
                    return;
                }

                //加载共享路径图片
                LoadImageFromSharePath(fullSharePath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"加载失败：图片文件不存在【{ex.FileName}】", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Backpanel.BackgroundImage = null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("加载失败：无读取图片目录的权限！\n请检查该目录的读取权限。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Backpanel.BackgroundImage = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载图片失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Backpanel.BackgroundImage = null;
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
                Backpanel.BackgroundImage = new Bitmap(bmp);
            }
        }

        #endregion

        //登录按钮点击事件
        private void log_in_Click(object sender, EventArgs e)
        {
            if (username.Text == "")//没有输入用户名
            {
                MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (password.Text == "")//没有输入密码
            {
                MessageBox.Show("请输入用户密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (reader.Checked)//选择以读者身份登录
            {
                string querySql = "SELECT * FROM reader WHERE UserName = @userName";//使用reader表中的用户名搜索
                DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", username.Text));
                if (result.Rows.Count == 0)//用户名有误
                {
                    MessageBox.Show("输入的用户名有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string Password = result.Rows[0]["Password"]?.ToString();
                if (password.Text != Password)//输入的密码有误
                {
                    MessageBox.Show("输入的密码有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string Status = result.Rows[0]["Status"]?.ToString();
                if (Status != "Normal")//读者账号状态冻结
                {
                    MessageBox.Show("您的帐号已被冻结，请联系管理员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _parentForm.username = username.Text;//更新父页面的用户名
                _parentForm.password = password.Text;//更新父页面的密码
                _parentForm.UpdateUsername();//更改主页显示的用户名
                _parentForm.HideLogIN();//把登录按钮替换成退出登录按钮
                MessageBox.Show("成功登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.CloseAllChildForm();//关闭所有打开页面
            }
            else if (administrator.Checked)//选择以管理员身份登录
            {
                string querySql = "SELECT * FROM administrator WHERE UserName = @userName";//使用administrator表中的用户名搜索
                DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@userName", username.Text));
                if (result.Rows.Count == 0)//用户名有误
                {
                    MessageBox.Show("输入的用户名有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string Password = result.Rows[0]["Password"]?.ToString();
                if (password.Text != Password)//输入的密码有误
                {
                    MessageBox.Show("输入的密码有错误，请核对后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _parentForm.username = username.Text;//更新父页面的用户名
                _parentForm.password = password.Text;//更新父页面的密码
                _parentForm.UpdateUsername();//更改主页显示的用户名
                _parentForm.HideLogIN();//把登录按钮替换成退出登录按钮
                _parentForm.ShowAdministratorButton();//显示管理员中心按钮
                MessageBox.Show("成功登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.CloseAllChildForm();//关闭所有打开页面
            }
        }

        //把登录页面关闭，打开注册页面
        private void sign_up_Click(object sender, EventArgs e)
        {
            _parentForm.CloseChildForm();//关闭登录页面
            _parentForm.OpenSignUp(); // 调用父窗体的OpenSignUp方法打开注册页面
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (isShowPassword == false)
            {
                password.PasswordChar = '\0'; // 显示明文
                isShowPassword = true;
            }
            else
            {
                password.PasswordChar = '*';  // 隐藏为*
                isShowPassword = false;
            }
        }

        
    }
}
