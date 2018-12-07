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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!PassWordBooks.PassWordBooks.GetInstance().CheckAccount())//账号配置不存在
            {
                ucCreateAccount account = new PassWordBooksWinFrom.ucCreateAccount();
                AddUserControl(account);                
            }
            else//数据存在加载默认账号账本
            {
                ucPassWordBooksList passWordBooks = new ucPassWordBooksList();
                AddUserControl(passWordBooks);
                labAccount.Text = PassWordBooks.PassWordBooks.GetInstance().CurAccountName;
            }
        }
        /// <summary>
        /// 添加用户控件
        /// </summary>
        /// <param name="uc"></param>
        private void AddUserControl(UserControl uc)
        {
            palContent.Controls.Add(uc);
        }
        /// <summary>
        /// 回滚到上一步
        /// </summary>
        private void RollbackUserControl()
        {
            var count = palContent.Controls.Count;
            if (count >= 2)
            {
                palContent.Controls.RemoveAt(count - 1);
            }
        }
    }
}
