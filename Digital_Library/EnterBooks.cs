using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Digital_Library
{
    //录入书籍页面设计
    public partial class EnterBooks : Form
    {
        private Navigation _parentForm;//绑定父页面
        public string BookID = "";//书籍ID
        private MySQLConnect _mysqlconnect;//连接数据库
        private readonly string _shareBasePath = AppConfig.ImageFolder;// 共享服务器路径

        // 上传功能专用变量
        private string _localImgPath = string.Empty;       // 本地图片路径
        private string _uploadedSharePath = string.Empty;  // 已上传到共享的图片路径

        public EnterBooks(Navigation parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;
            this.FormBorderStyle = FormBorderStyle.None; // 无边框
            this.ControlBox = false;
            this.Text = "";

            //初始化MySQL连接
            _mysqlconnect = new MySQLConnect();

            type.Items.AddRange(new string[] {
                "小说","经典","随笔","散文","诗歌","童话","推理","绘本",
                "悬疑","科幻","青春","言情","武侠","历史","心理学","哲学",
                "社会学","传记","艺术","政治","宗教","爱情","成长","教育",
                "励志","心理","旅行","职场","摄影","美食","经济","管理",
                "商业","金融","投资","营销","广告","科普","科学","编程","算法","通信",

            });
            type.SelectedIndex = 0;

            // 图片预览框自动缩放
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 选择图片预览上传
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // 先清空删除共享图片
            ClearAll();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "选择书籍封面图片";

                if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                _localImgPath = ofd.FileName;

                // 加载预览
                try
                {
                    picPreview.Image = Image.FromFile(_localImgPath);
                    button.Visible = false;
                }
                catch
                {
                    MessageBox.Show("图片加载失败！");
                    _localImgPath = string.Empty;
                }

 
            }
        }

        // 上传到共享目录
        private void UploadImage()
        {
            if (string.IsNullOrEmpty(_localImgPath))
            {
                MessageBox.Show("请先选择图片！");
                return;
            }

            string ext = Path.GetExtension(_localImgPath);
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + new Random().Next(1000, 9999) + ext;
            // 存文件名到数据库
            _uploadedSharePath = newFileName;

            // 上传的完整路径，拼接文件夹、文件名
            string fullPath = Path.Combine(_shareBasePath, newFileName);

            try
            {
                if (!Directory.Exists(_shareBasePath))
                {
                    MessageBox.Show("图片目录不可用！");
                    _uploadedSharePath = string.Empty;
                    return;
                }

                File.Copy(_localImgPath, fullPath, true);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传失败：" + ex.Message);
                _uploadedSharePath = string.Empty;
            }
        }

        // 清空预览图片
        private void ClearAll()
        {
            

            // 清空预览
            if (picPreview.Image != null)
            {
                picPreview.Image.Dispose();
                picPreview.Image = null;
            }

            _localImgPath = string.Empty;


            button.Visible = true;
        }

        // 关闭页面
        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearAll();
            _parentForm.CloseChildForm();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            

            if (bookName.Text == "")//没有输入书籍名称
            {
                MessageBox.Show("请输入书籍名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nameEN.Text == "")//没有输入书籍英文名
            {
                MessageBox.Show("请输入书籍英文名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (author.Text == "")//没有输入作者
            {
                MessageBox.Show("请输入作者", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nationality.Text == "")//没有输入作者国籍
            {
                MessageBox.Show("请输入作者国籍", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (place.Text == "")//没有输入存放地点
            {
                MessageBox.Show("请输入存放地点", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 上传到共享文件夹
            UploadImage();

            // 如果图片上传失败，停止录入
            if (string.IsNullOrEmpty(_uploadedSharePath))
                return;

            try
            {

                string query = "INSERT INTO book(Cover,Name,Name_EN,Author,Nationality,Publication_Date,Type,Introduction,Place,Lend_Status) " +
                    "VALUES (@cover,@name,@nameEn,@author,@nationality,@publicationDate,@type,@introduction,@place,'Save')";

                _mysqlconnect.ExecuteNonQuery(query,
                    MySQLConnect.Param("@cover", _uploadedSharePath),
                    MySQLConnect.Param("@name", bookName.Text),
                    MySQLConnect.Param("@nameEn", nameEN.Text),
                    MySQLConnect.Param("@author", author.Text),
                    MySQLConnect.Param("@nationality", nationality.Text),
                    MySQLConnect.Param("@publicationDate", publication.Text),
                    MySQLConnect.Param("@type", type.Text),
                    MySQLConnect.Param("@introduction", introduction.Text),
                    MySQLConnect.Param("@place", place.Text));

                MessageBox.Show("书籍录入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string querySql = "SELECT * FROM suggestion WHERE Name = @name";//搜索建议中是否有同名书籍
                DataTable result = _mysqlconnect.ExecuteQuery(querySql, MySQLConnect.Param("@name", bookName.Text));
                if (result.Rows.Count != 0)//包含同名书籍
                {
                    string sql = "DELETE FROM suggestion WHERE Name = @name";
                    _mysqlconnect.ExecuteNonQuery(sql, MySQLConnect.Param("@name", bookName.Text));

                    MessageBox.Show("已完成相关建议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("录入失败：" + ex.Message);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            btnSelect_Click(null, null);
        }
    }
}