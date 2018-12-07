
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassWordBooksWinFrom
{
    public partial class frmSencondVerifyPassWord : Form
    {
        public frmSencondVerifyPassWord()
        {
            InitializeComponent();
        }

        private void frmVerifyPassWord_Load(object sender, EventArgs e)
        {
            labHelp.Text = PassWordBooks.PassWordBooks.GetInstance().CurPassWordBookModel.PassWordHelp;
        }

        private void tbxPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (PassWordBooks.PassWordBooks.GetInstance().VerifyAccountPwd(tbxPassWord.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                labError.Visible = true;
            }
        }

        private void tbxPassWord_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = !string.IsNullOrEmpty(tbxPassWord.Text);
        }
    }
}
