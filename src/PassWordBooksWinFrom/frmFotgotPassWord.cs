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
    public partial class frmFotgotPassWord : Form
    {
        public frmFotgotPassWord()
        {
            InitializeComponent();
        }
        private void btnChooleShield_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "数据文件|*.db|所有文件(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                labCurPassWord.Text = PassWordBooks.PassWordBooks.GetInstance().FotgotPassWord(openFile.FileName);
            }
        }

        private void frmFotgotPassWord_Load(object sender, EventArgs e)
        {
            labCurAccount.Text = PassWordBooks.PassWordBooks.GetInstance().CurAccountName;
        }        
    }
}
