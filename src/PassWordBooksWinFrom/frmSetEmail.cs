using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PassWordBooksWinFrom
{
    public partial class frmSetEmail : Form
    {
        public frmSetEmail()
        {
            InitializeComponent();
        }
        private string _codeKey = string.Empty;
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                _codeKey = PassWordBooks.PassWordBooks.GetInstance().SendVerifyCodeByEmail(tbxEmail.Text);

                MessageBox.Show("验证码发送成功", "验证码发送状态提醒");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        /// <summary>
        /// 提交变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string result = PassWordBooks.PassWordBooks.GetInstance().SetAccountEmail(tbxOldEmail.Text, tbxEmail.Text, tbxVerifyCode.Text, _codeKey);
                if (string.IsNullOrEmpty(result))//保存成功
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    labError.Text = result;
                    labError.Visible = true;
                }
            }
            catch (PassWordBooks.ExceptionSecurityTimeout ee)
            {
                MessageBox.Show(ee.Message, "身份认证异常");
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message, "程序异常");
            }
        } 
        /// <summary>
        /// 验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxVerifyCode_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = tbxVerifyCode.Text.Length >= 6;
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[A-Za-z\d]+([-_.][A-Za-z\d]+)*@([A-Za-z\d]+[-.])+[A-Za-z\d]{2,4}$");
            btnSendCode.Enabled = regex.IsMatch(tbxEmail.Text);
        }

        private void frmSetEmail_Load(object sender, EventArgs e)
        {
            string oldEmail = PassWordBooks.PassWordBooks.GetInstance().CurPassWordBookModel.Email;
            if (string.IsNullOrEmpty(oldEmail))//无旧邮箱
            {
                tbxOldEmail.Enabled = false;
                labOldEmailTip.Text = "无旧邮箱，请绑定新邮箱";
            }
            else
            {
                tbxOldEmail.Enabled = true;
                var emailSplit = oldEmail.Split('@');
                emailSplit[0] = emailSplit[0].Substring(0, emailSplit[0].Length - 16) + "****";
                labOldEmailTip.Text = string.Format("{0}@{1}", emailSplit[0], emailSplit[1]);
            }
        }

        private void tbxOldEmail_Leave(object sender, EventArgs e)
        {
            if (!PassWordBooks.PassWordBooks.GetInstance().CheckEmail(tbxOldEmail.Text))
            {
                labOldEmailTip.ForeColor = Color.Red;
            }
            else
            {
                labOldEmailTip.ForeColor = Color.Gray;
            }
        }
    }
}
