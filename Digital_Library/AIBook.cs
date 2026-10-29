using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Digital_Library
{
    //AI智能推荐页面设计
    public partial class AIBook : Form
    {
        private readonly AIBookService _aiService = new AIBookService();
        private Navigation _parentForm;

        public AIBook(Navigation parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;

            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("微软雅黑", 10F);

            // 做圆角处理
            SetRoundControl(rtbChat, 12);
            SetRoundControl(pnlInput, 20);
            SetRoundControl(btnSend, 20);

            // 输入框放进面板
            txtMsg.Parent = pnlInput;

            // 绑定按钮悬停事件
            btnSend.MouseEnter += btnSend_MouseEnter;
            btnSend.MouseLeave += btnSend_MouseLeave;

            // 绑定文本框回车键事件
            txtMsg.KeyDown += txtMsg_KeyDown;
        }

        //在文本框输入时点击回车触发效果
        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            // 判断是否按下回车键
            if (e.KeyCode == Keys.Enter)
            {
                // 手动触发按钮
                btnSend_Click(sender, e);
                // 阻止回车键的默认行为
                e.SuppressKeyPress = true;
                txtMsg.Text = "";
            }
        }


        // 圆角函数
        private void SetRoundControl(Control control, int radius)
        {
            if (control is TextBox) return;

            GraphicsPath path = new GraphicsPath();
            int w = control.Width - 1;
            int h = control.Height - 1;
            int r = radius;

            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(w - r, 0, r, r, 270, 90);
            path.AddArc(w - r, h - r, r, r, 0, 90);
            path.AddArc(0, h - r, r, r, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private void btnSend_MouseEnter(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.FromArgb(20, 110, 210);
        }

        private void btnSend_MouseLeave(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.FromArgb(45, 140, 240);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userMsg = txtMsg.Text.Trim();
            if (string.IsNullOrEmpty(userMsg)) return;

            AppendChat("我：" + userMsg, Color.FromArgb(30, 120, 210), true);
            txtMsg.Clear();

            try
            {
                AppendChat("AI 正在思考中...", Color.FromArgb(100, 100, 100));
                btnSend.Enabled = false;
                await Task.Delay(10);
                string aiReply = await _aiService.ChatAsync(userMsg);
                rtbChat.Text = rtbChat.Text.Replace("AI 正在思考中...\n\n", "");
                AppendChat("AI推荐：" + aiReply, Color.FromArgb(60, 60, 60));
            }
            catch (Exception ex)
            {
                AppendChat("AI出错：" + ex.Message, Color.Red);
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void AppendChat(string text, Color color, bool isUser = false)
        {
            rtbChat.SelectionColor = color;
            rtbChat.SelectionFont = new Font("微软雅黑", 10.5F, FontStyle.Regular);

            if (isUser)
            {
                rtbChat.SelectionBackColor = Color.FromArgb(230, 245, 255);
                rtbChat.AppendText("  " + text + "  ");
                rtbChat.SelectionBackColor = Color.Transparent;
            }
            else
            {
                rtbChat.AppendText(text);
            }

            rtbChat.AppendText("\n\n");
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.ScrollToCaret();
        }
    }
}