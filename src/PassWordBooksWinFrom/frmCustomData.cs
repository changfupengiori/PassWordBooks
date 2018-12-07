/* * 
 * author:changfupeng
 * createDate:2018-11-30 9:41
 * remark:新增和编辑单个密码本。
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassWordBooksWinFrom
{
    public partial class frmCustomData : Form
    {
        public frmCustomData()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 由外部系统提供数据添加方法
        /// </summary>
        public Func<string, string, bool> AddDataFunc
        {
            get; set;
        }
        /// <summary>
        /// 逐条添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddList_Click(object sender, EventArgs e)
        {
            AddDataFunc?.Invoke(tbxKey.Text, tbxValue.Text);
            tbxKey.Text = string.Empty;
            tbxValue.Text = string.Empty;
        }
        /// <summary>
        /// 单条添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDataFunc?.Invoke(tbxKey.Text, tbxValue.Text);
            this.Close();
        }
        /// <summary>
        /// 文本有变动后修改确定按钮的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxKey_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxKey.Text) && !string.IsNullOrEmpty(tbxValue.Text))
            {
                btnAdd.Enabled = true;
                btnAddList.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAddList.Enabled = false;
            }
        }
    }
}
