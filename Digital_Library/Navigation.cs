using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library
{
    //导航栏页面设计
    public partial class Navigation : Form
    {
        //显示在页面下方的登录状态
        public string username = "未登录";//"001";
        public string password = "未登录";//"001";
        public int Adm = 0;
        //建立栈用于存放页面，便于返回上一页操作
        private readonly Stack<Form> _childFormStack = new Stack<Form>();
        private Panel _mainPanel; //添加一个Panel面板，把子页面放在面板上，防止向右下偏移

        public Navigation()
        {
            InitializeComponent();

            _mainPanel = new Panel();
            _mainPanel.Dock = DockStyle.Fill;//把面板全屏铺满窗口
            this.Controls.Add(_mainPanel);//把面板加入主页
            _mainPanel.BringToFront();//面板显示在最上层

            //初始加载打开主页
            OpenHomepage();
            UpdateUsername();
        }

        //更新用户名
        public void UpdateUsername()
        {
            user.Text = username;
        }

        //把登录按钮更替为退出登录
        public void HideLogIN()
        {
            登录ToolStripMenuItem.Visible = false;
            退出登录ToolStripMenuItem.Visible = true;
        }

        //显示管理员中心按钮
        public void ShowAdministratorButton()
        {
            读者中心ToolStripMenuItem.Visible = false;
            管理员中心ToolStripMenuItem.Visible = true;
            系统管理ToolStripMenuItem.Visible = true;
            Adm = 1;
        }

        /// <summary>
        /// 关闭最后打开的子页面
        /// </summary>
        public void CloseChildForm()
        {
            if (_childFormStack.Count > 0)//判断是否有子页面
            {
                var closingForm = _childFormStack.Pop();//出栈
                closingForm.Close();//关闭出栈页面
                closingForm.Dispose();//释放资源

                if (_childFormStack.Count > 0)
                {
                    var prevForm = _childFormStack.Peek();//查看栈顶页面
                    _mainPanel.Controls.Clear();//清空面板内容
                    _mainPanel.Controls.Add(prevForm);//栈顶页面显示在面板中
                    prevForm.Show();//显示栈顶页面
                }
            }
        }

        /// <summary>
        /// 关闭所有打开的子页面
        /// </summary>
        public void CloseAllChildForm()
        {
            //栈内页面依次出栈，只保留栈底的主页页面
            while (_childFormStack.Count > 1)
            {
                CloseChildForm();
            }
        }

        /// <summary>
        /// 打开子页面并入栈
        /// </summary>
        /// <param name="newForm">需要入栈的页面</param>
        private void OpenChildForm(Form newForm)
        {
            newForm.TopLevel = false;//把页面设置成非顶级控件，便于放入面板
            newForm.Dock = DockStyle.Fill;//全屏显示
            newForm.FormBorderStyle = FormBorderStyle.None;//去掉边框

            _mainPanel.Controls.Clear();//清空面板上的内容
            _mainPanel.Controls.Add(newForm);//添加新页面到面板

            newForm.Show();//显示新页面
            _childFormStack.Push(newForm);//把新页面入栈
        }

        /// <summary>
        /// 创建主页子窗体
        /// </summary>
        public void OpenHomepage()
        {
            // 清空所有已打开的子窗体
            while (_childFormStack.Count > 0)
            {
                CloseChildForm();
            }
            // 打开主页并入栈
            var home = new HomePage(this);
            OpenChildForm(home);

            ///！
            var homePage = _childFormStack.Peek();
            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(homePage);
            homePage.Show();
        }

        /// <summary>
        /// 创建搜索子窗体
        /// </summary>
        /// <param name="searchdata">搜索的内容</param>
        public void OpenSearch(string SearchData)
        {
            // 打开搜索页面并初始化
            var search = new Search(this);
            search.SearchData = SearchData;
            search.ChangeSearchBox();
            OpenChildForm(search);
        }

        // 打开书籍详情窗体并加载数据
        public void OpenDetails(string BookID)
        {
            var details = new Details(this);
            details.LoadBookByID(BookID);
            OpenChildForm(details);
        }

        // 打开借阅书籍窗体并加载数据
        public void OpenLendBook(string BookID)
        {
            var lendBook = new LendBook(this);
            lendBook.LoadBookByID(BookID);
            OpenChildForm(lendBook);
        }

        // 打开登录窗体并加载数据
        public void OpenLogIn()
        {
            var logIn = new LogIn(this);
            OpenChildForm(logIn);
        }

        // 打开注册窗体并加载数据
        public void OpenSignUp()
        {
            var signUp = new SignUp(this);
            OpenChildForm(signUp);
        }

        //打开管理员中心并加载数据
        public void OpenAdministratorCenter()
        {
            var administratorcenter = new AdministratorCenter(this);
            OpenChildForm(administratorcenter);
        }

        //打开读者中心并加载数据
        public void OpenReaderCenter()
        {
            var readercenter = new ReaderCenter(this);
            OpenChildForm(readercenter);
        }

        //打开AI推荐页面
        public void OpenAIBook()
        {
            var aiBook = new AIBook(this);
            OpenChildForm(aiBook);
        }
        
        //打开活动中心页面
        public void OpenActivityCenter()
        {
            var activityCenter = new ActivityCenter(this);
            OpenChildForm(activityCenter);
        }

        //打开云桥连搜索页面
        public void OpenCloudBridgeConnect(string SearchData)
        {
            var cloudBridgeConnect = new CloudBridgeConnect(this);
            cloudBridgeConnect.SearchData = SearchData;
            cloudBridgeConnect.ChangeSearchBox();
            OpenChildForm(cloudBridgeConnect);
        }

        // 打开云桥连书籍详情窗体并加载数据
        public void OpenCBCDetails(string BookID)
        {
            var CBCdetails = new CBCDetails(this);
            CBCdetails.LoadBookByID(BookID);
            OpenChildForm(CBCdetails);
        }

        // 打开活动管理窗体并加载数据
        public void OpenManagementActivities()
        {
            var managementActivities = new ManagementActivities(this);
            OpenChildForm(managementActivities);
        }
  
        // 打开账号管理窗体并加载数据
        public void OpenManagementAccount()
        {
            var managementAccount = new ManagementAccount(this);
            OpenChildForm(managementAccount);
        }

        // 打开录入书籍窗体并加载数据
        public void OpenEnterBooks()
        {
            var enterBooks = new EnterBooks(this);
            OpenChildForm(enterBooks);
        }

        // 打开云桥连管理窗体并加载数据
        public void OpenManagementCBC()
        {
            var managementCBC = new ManagementCBC(this);
            OpenChildForm(managementCBC);
        }

        // 打开归还书籍窗体并加载数据
        public void OpenReturnBook()
        {
            var returnBook = new ReturnBook(this);
            OpenChildForm(returnBook);
        }

        //退出登录模块化代码
        public void LogOut()
        {
            username = "未登录";
            password = "未登录";
            UpdateUsername();
            退出登录ToolStripMenuItem.Visible = false;
            管理员中心ToolStripMenuItem.Visible = false;
            读者中心ToolStripMenuItem.Visible = true;
            登录ToolStripMenuItem.Visible = true;
            系统管理ToolStripMenuItem.Visible = false;
            MessageBox.Show("成功退出登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Adm = 0;
            //栈内页面依次出栈，只保留栈底的主页页面
            while (_childFormStack.Count > 1)
            {
                CloseChildForm();
            }
        }

        private void 返回主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_childFormStack.Count <= 1)
            {
                MessageBox.Show("已经是主页了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CloseAllChildForm();
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLogIn();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_childFormStack.Count <= 1)
            {
                MessageBox.Show("已经是主页了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CloseChildForm();
        }

        private void 管理员中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAdministratorCenter();
        }

        private void 读者中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(username == "未登录")
            {
                MessageBox.Show("请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenReaderCenter();
        }

        private void AI推荐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAIBook();
        }

        private void 活动中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenActivityCenter();
        }

        private void 云桥连ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCloudBridgeConnect("");
        }

        private void 活动管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenManagementActivities();
        }

        private void 账号管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenManagementAccount();
        }

        private void 录入书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEnterBooks();
        }

        private void 云桥连管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenManagementCBC();
        }

        private void 归还书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReturnBook();
        }

        //根据点击的书籍类型，执行不同的跳转搜索页面并搜索
        #region 书籍类型点击跳转
        private void 小说ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("小说");
        }

        private void 经典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("经典");
        }

        private void 随笔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("随笔");
        }

        private void 散文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("散文");
        }

        private void 诗歌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("诗歌");
        }

        private void 童话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("童话");
        }

        private void 推理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("推理");
        }

        private void 绘本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("绘本");
        }

        private void 悬疑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("悬疑");
        }

        private void 科幻ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("科幻");
        }

        private void 青春ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("青春");
        }

        private void 言情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("言情");
        }

        private void 武侠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("武侠");
        }

        private void 历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("历史");
        }

        private void 心理学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("心理学");
        }

        private void 哲学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("哲学");
        }

        private void 社会学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("社会学");
        }

        private void 传记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("传记");
        }

        private void 艺术ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("艺术");
        }

        private void 政治ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("政治");
        }

        private void 宗教ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("宗教");
        }

        private void 爱情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("爱情");
        }

        private void 成长ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("成长");
        }

        private void 教育ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("教育");
        }

        private void 励志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("励志");
        }

        private void 心理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("心理");
        }

        private void 旅行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("旅行");
        }

        private void 职场ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("职场");
        }

        private void 摄影ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("摄影");
        }

        private void 美食ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("美食");
        }

        private void 经济ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("经济");
        }

        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("管理");
        }

        private void 商业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("商业");
        }

        private void 金融ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("金融");
        }

        private void 投资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("投资");
        }

        private void 营销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("营销");
        }

        private void 广告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("广告");
        }

        private void 科普ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("科普");
        }

        private void 科学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("科学");
        }

        private void 编程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("编程");
        }

        private void 算法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("算法");
        }

        private void 通信ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearch("通信");
        }











        #endregion

        
    }
}