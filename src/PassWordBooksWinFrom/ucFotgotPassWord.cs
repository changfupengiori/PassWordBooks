/* * 
 * author:changfupeng
 * createDate:2018-11-26 11:33
 * remark:找回主账号密码。
 * 
 * */
using System.Windows.Forms;
using System;

namespace PassWordBooksWinFrom
{
    public partial class ucFotgotPassWord : UserControl
    {
        public ucFotgotPassWord()
        {
            InitializeComponent();
        }
        private string _curAccountName;
        /// <summary>
        /// 获取或设置当前操作的账号
        /// </summary>
        public string CurAccountName
        {
            get { return _curAccountName; }
            set
            {
                _curAccountName = value;
                labCurAccount.Text = value;
            }
        }
        private void btnChooleShield_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "数据文件|*.db";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                labCurPassWord.Text = PassWordBooks.PassWordBooks.GetInstance().FotgotPassWord(openFile.FileName);
            }
        }
    }
}
