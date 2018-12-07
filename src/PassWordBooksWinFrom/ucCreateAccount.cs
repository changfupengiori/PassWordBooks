/* * 
 * author:changfupeng
 * createDate:2018-11-27 10:00
 * remark:创建主账号页面
 * 
 * */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PassWordBooksWinFrom
{
    public partial class ucCreateAccount : UserControl
    {
        public ucCreateAccount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面加载初次加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucCreateAccount_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 360);
        }
        /// <summary>
        /// 第一步跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextStep1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(3, 3);
        }
        /// <summary>
        /// 第二步跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextStep2_Click(object sender, EventArgs e)
        {
            if (label6.ForeColor == Color.Gray
                && label7.ForeColor == Color.Gray
                && label9.ForeColor == Color.Gray)
            {
                panel2.Visible = false;
                panel3.Visible = true;
                panel3.Location = new Point(3, 3);
            }
            else
            {
                MessageBox.Show("请检查红色部分的错误");
            }
        }
        /// <summary>
        /// 第三步跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveShield_Click(object sender, EventArgs e)
        {
            PassWordBooks.PassWordBooks.GetInstance().InitAccount(tbxAccount.Text, tbxPassWord.Text, tbxPassWordHelp.Text, tbxRemark.Text, cbkIsComputer.Checked);

            SaveFileDialog f = new SaveFileDialog();
            f.FileName = string.Format("{0}_Shield_{1}.db", tbxAccount.Text, DateTime.Now.ToString("yyyyMMddHHmmss"));
            if (f.ShowDialog() == DialogResult.OK)
            {
                PassWordBooks.PassWordBooks.GetInstance().SaveShield(f.FileName, tbxPassWord.Text);
            }
        }
        /// <summary>
        /// 用户输入账户后，检查账号是否符合标准和去重检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxAccount_Leave(object sender, EventArgs e)
        {
            var names = PassWordBooks.PassWordBooks.GetInstance().GetAccountNames();
            if (names == null)//判断是否第一次初始账户
                names = new string[0];

            string match = "[a-zA-Z0-9_/-]{4,15}$";
            if (!Regex.IsMatch(tbxAccount.Text, match) || tbxAccount.Text.Length > 15 || names.Contains(tbxAccount.Text))
            {
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// 验证密码格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPassWord_Leave(object sender, EventArgs e)
        {
            string match = "[a-zA-Z0-9_/-]{8,}$";
            string matchUpper = "[A-Z]";
            string matchLower = "[a-z]";
            string matchNumber = "[0-9]";
            if (!Regex.IsMatch(tbxPassWord.Text, match)
                || !Regex.IsMatch(tbxPassWord.Text, matchUpper)
                || !Regex.IsMatch(tbxPassWord.Text, matchLower)
                || !Regex.IsMatch(tbxPassWord.Text, matchNumber))
            {
                label7.ForeColor = Color.Red;
            }
            else
            {
                label7.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// 确定密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPassWordConfirm_Leave(object sender, EventArgs e)
        {
            if (tbxPassWord.Text == tbxPassWordConfirm.Text)
            {
                label7.ForeColor = Color.Gray;
            }
            else
            {
                label7.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// 提示码验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPassWordHelp_Leave(object sender, EventArgs e)
        {
            if (tbxPassWord.Text == tbxPassWordHelp.Text)
            {
                label9.ForeColor = Color.Red;
            }
            else
            {
                label9.ForeColor = Color.Gray;
            }
        }
    }
}
