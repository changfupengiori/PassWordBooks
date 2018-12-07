/* * 
 * author:changfupeng
 * createDate:2018-11-28 09:41
 * remark:标签编辑页
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
    public partial class frmTags : Form
    {
        public frmTags()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用户选择的标签集合
        /// </summary>
        public HashSet<string> ChooseTags { get; set; }
        private Dictionary<string,bool> _tags = new Dictionary<string,bool>();

        private void frmTags_Load(object sender, EventArgs e)
        {
            HashSet<string> oldList = PassWordBooks.PassWordBooks.GetInstance().GetTags();
            if (ChooseTags != null)
            {
                foreach (var item in ChooseTags)
                {
                    if (!string.IsNullOrEmpty(item))
                        oldList.Add(item);
                }
            }
            foreach (var item in oldList)
            {
                if (ChooseTags != null && ChooseTags.Contains(item))
                {
                    _tags.Add(item, true);
                    flowLayoutPanel1.Controls.Add(new CheckBox()
                    {
                        Text = item,
                        Checked = true
                    });
                }
                else
                {
                    _tags.Add(item, false);
                    flowLayoutPanel1.Controls.Add(new CheckBox()
                    {
                        Text = item,
                        Checked = false
                    });
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    i++;
                }
            }
            if (i >= 10)
            {
                MessageBox.Show("最多选择10个标签");
            }
            else
            {
                ChooseTags.Clear();
                foreach (CheckBox item in flowLayoutPanel1.Controls)
                {
                    if (item.Checked)
                    {
                        ChooseTags.Add(item.Text);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            string newTag = tbxNewTag.Text;
            if (string.IsNullOrEmpty(newTag))
                return;
            flowLayoutPanel1.Controls.Add(new CheckBox()
            {
                Text = newTag,
                Checked = true
            });
            _tags[newTag] = true;
            tbxNewTag.Text = string.Empty;
            tbxNewTag.Focus();
        }

        private void tbxNewTag_TextChanged(object sender, EventArgs e)
        {
            btnAddTag.Enabled = !string.IsNullOrEmpty(tbxNewTag.Text);
        }

        private void tbxNewTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAddTag_Click(sender, e);
            }
        }
    }
}
