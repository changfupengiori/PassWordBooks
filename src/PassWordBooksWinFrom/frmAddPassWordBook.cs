/* * 
 * author:changfupeng
 * createDate:2018-11-29 09:41
 * remark:新增和编辑单个密码本。
 * 
 * */
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
    public partial class frmAddPassWordBook : Form
    {
        public frmAddPassWordBook()
        {
            InitializeComponent();
        }
        PassWordBooks.Model.PassWordBookModel _curModel;
        /// <summary>
        /// 如果是编辑的状态进行修订
        /// </summary>
        /// <param name="model"></param>
        public frmAddPassWordBook(PassWordBooks.Model.PassWordBookModel model)
        {
            InitializeComponent();
            _curModel = model;
        }
        /// <summary>
        /// 滑块显示具体选择的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBarRedo.Value == 0)
            {
                labChooseRedo.Text = "不提醒";
            }
            else
            {
                labChooseRedo.Text = trackBarRedo.Value + "月";
            }
        }
        /// <summary>
        /// 默认状态下创建密保文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPassWordBook1_Click(object sender, EventArgs e)
        {
            BingBaseDate();
            try
            {
                try
                {
                    PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel);
                }
                catch (PassWordBooks.ExceptionSecurityTimeout)
                {
                    frmVerifyPassWord frm = new frmVerifyPassWord();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        /// <summary>
        /// 绑定基础数据
        /// </summary>
        private void BingBaseDate()
        {
            if (_curModel == null)
                _curModel = new PassWordBooks.Model.PassWordBookModel() { };

            //获取基本的数据
            _curModel.Account = tbxAccount.Text;
            _curModel.Name = tbxName.Text;
            _curModel.PassWord = tbxPassWord.Text;
            _curModel.Tags = tbxTags.Text.Split(',').ToList();
            _curModel.Remark = tbxRemark.Text;
            _curModel.PassWordHelp = tbxPassWordHelp.Text;
            _curModel.Redo = trackBarRedo.Value;
            _curModel.Path = tbxPath.Text;
            //获取密码本的类型
            if (rbtnFile.Checked)
                _curModel.Type = PassWordBooks.PassWordBookType.file;
            if (rbtnHttp.Checked)
                _curModel.Type = PassWordBooks.PassWordBookType.http;
            if (rbtnZip.Checked)
                _curModel.Type = PassWordBooks.PassWordBookType.zip;
            if (rbtnOther.Checked)
                _curModel.Type = PassWordBooks.PassWordBookType.file;
            //获取用户自定义数据
            _curModel.Data = new List<PassWordBooks.Model.PassWordBookData>();
            if (lbxCustomData.Items.Count >= 1)
            {
                foreach (PassWordBooks.Model.PassWordBookData item in lbxCustomData.Items)
                {
                    _curModel.Data.Add(new PassWordBooks.Model.PassWordBookData()
                    {
                        Key = item.Key,
                        Value = item.Value.Replace(item.Key + ":", "")
                    });
                }
            }
        }

        /// <summary>
        /// 随机生产密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labAddRandomPassWord_Click(object sender, EventArgs e)
        {
            tbxPassWord.Text = PassWordBooks.PassWordBooks.GetInstance().GetRandomPassWord(12);
        }
        /// <summary>
        /// 删除自定义数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelCustomData_Click(object sender, EventArgs e)
        {
            lbxCustomData.Items.Remove(lbxCustomData.SelectedItem);
        }
        /// <summary>
        /// 新增自定义数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomData_Click(object sender, EventArgs e)
        {
            frmCustomData customData = new frmCustomData();
            ///添加数据处理委托
            customData.AddDataFunc = (key, value) =>
            {
                PassWordBooks.Model.PassWordBookData date = new PassWordBooks.Model.PassWordBookData();
                date.Key = key;
                date.Value = string.Format("{0}:{1}", key, value);
                lbxCustomData.Items.Add(date);
                return true;
            };
            customData.ShowDialog();
        }
        /// <summary>
        /// 复制数据到粘贴板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(((PassWordBooks.Model.PassWordBookData)lbxCustomData.SelectedItem).Value);
        }

        private void btnAddPassWordBook2_Click(object sender, EventArgs e)
        {
            BingBaseDate();
            try
            {
                try
                {
                    _curModel.PassWordHelp = tbxPassWordHelp.Text;
                    PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.AuthPassWord, tbxSecondPassWord.Text);

                }
                catch (PassWordBooks.ExceptionSecurityTimeout)
                {
                    frmVerifyPassWord frm = new frmVerifyPassWord();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _curModel.PassWordHelp = tbxPassWordHelp.Text;
                        PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.AuthPassWord, tbxSecondPassWord.Text);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnAddPassWordBook3_Click(object sender, EventArgs e)
        {
            BingBaseDate();
            try
            {
                try
                {
                    PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.AuthEmailCode);
                }
                catch (PassWordBooks.ExceptionSecurityTimeout)
                {
                    frmVerifyPassWord frm = new frmVerifyPassWord();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.AuthEmailCode);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnAddPassWordBook4_Click(object sender, EventArgs e)
        {
            BingBaseDate();
            try
            {
                try
                {
                    PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.AuthPhoneCode);
                }
                catch (PassWordBooks.ExceptionSecurityTimeout)
                {
                    frmVerifyPassWord frm = new frmVerifyPassWord();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.AuthPhoneCode);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnAddPassWordBook5_Click(object sender, EventArgs e)
        {
            BingBaseDate();
            string physics = string.Empty ;
            try
            {
                try
                {
                    physics = PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.PhysicsCode);

                    btnSavePhysics.Tag = physics;
                    btnSavePhysics.Enabled = true;
                }
                catch (PassWordBooks.ExceptionSecurityTimeout)
                {
                    frmVerifyPassWord frm = new frmVerifyPassWord();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        physics = PassWordBooks.PassWordBooks.GetInstance().SavePassWordBook(_curModel, PassWordBooks.PassWordBookSaveType.PhysicsCode);

                        btnSavePhysics.Tag = physics;
                        btnSavePhysics.Enabled = true;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        /// <summary>
        /// 选择快速标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labChooseTags_Click(object sender, EventArgs e)
        {
            frmTags tags = new PassWordBooksWinFrom.frmTags();
            tags.ChooseTags = new HashSet<string>(tbxTags.Text.Split(','));
            if (tags.ShowDialog() == DialogResult.OK)
            {
                tbxTags.Text = string.Join(",", tags.ChooseTags);
            }
        }
        /// <summary>
        /// 保存物理密钥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSavePhysics_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileDialog = new SaveFileDialog();
            savefileDialog.FileName = string.Format("账号_{0}_物理密钥_{1}.db", _curModel.Name,DateTime.Now.ToString("yyyy-MM-dd"));
            if (savefileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefileDialog.FileName, false))
                {
                    sw.Write(btnSavePhysics.Tag.ToString());
                }
                btnSavePhysics.Tag = null;
            }
        }
        /// <summary>
        /// 窗体关闭前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddPassWordBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnSavePhysics.Tag.Equals(""))
            {
                if (MessageBox.Show("使用了物理密保加密，请保存密保文件。否则次密码本将无法解密,请点确定按钮返回保存密保文件。", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
