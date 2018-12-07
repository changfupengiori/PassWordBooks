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
    public partial class ucPassWordBooksList : UserControl
    {
        public ucPassWordBooksList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置显示的数据
        /// </summary>
        /// <param name="list"></param>
        public void SetData(List<PassWordBooks.Model.PassWordBookModel> list)
        {

        }        
        /// <summary>
        /// 新增密码本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPassWordBook_Click(object sender, EventArgs e)
        {
            frmAddPassWordBook addPassWordBook = new PassWordBooksWinFrom.frmAddPassWordBook();
            if(addPassWordBook.ShowDialog()== DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// 删除密码本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelPassWordBook_Click(object sender, EventArgs e)
        {

        }

        private void ucPassWordBooksList_Load(object sender, EventArgs e)
        {
            if (1 == 1)//无任何数据
            {
                palDataList.Visible = false;
                palNullData.Visible = true;
                palNullData.Location = new Point(0, 0);
            }
            else//有数据
            {
                palDataList.Visible = true;
                palNullData.Visible = false;
            }

        }
    }
}
