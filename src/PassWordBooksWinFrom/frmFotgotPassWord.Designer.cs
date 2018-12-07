namespace PassWordBooksWinFrom
{
    partial class frmFotgotPassWord
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooleShield = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labCurPassWord = new System.Windows.Forms.Label();
            this.labCurAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooleShield
            // 
            this.btnChooleShield.Location = new System.Drawing.Point(251, 158);
            this.btnChooleShield.Name = "btnChooleShield";
            this.btnChooleShield.Size = new System.Drawing.Size(100, 30);
            this.btnChooleShield.TabIndex = 6;
            this.btnChooleShield.Text = "选择密保";
            this.btnChooleShield.UseVisualStyleBackColor = true;
            this.btnChooleShield.Click += new System.EventHandler(this.btnChooleShield_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("楷体", 9F);
            this.label2.Location = new System.Drawing.Point(0, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 92);
            this.label2.TabIndex = 2;
            this.label2.Text = "此系统不存储也不加密存储用户主账号的手机号、邮箱、密码等数据。\r\n密保文件加密存储了密码相关数据。\r\n注：密保文件格式：账号_Shield_时间.db\r\n注：如果" +
    "启用了机器加密，仅能使用加密的计算机才能解密。";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCurPassWord
            // 
            this.labCurPassWord.Font = new System.Drawing.Font("楷体", 12F);
            this.labCurPassWord.ForeColor = System.Drawing.Color.Blue;
            this.labCurPassWord.Location = new System.Drawing.Point(2, 202);
            this.labCurPassWord.Name = "labCurPassWord";
            this.labCurPassWord.Size = new System.Drawing.Size(599, 51);
            this.labCurPassWord.TabIndex = 3;
            this.labCurPassWord.Text = "密码将在当前位置读取出来";
            this.labCurPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCurAccount
            // 
            this.labCurAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.labCurAccount.ForeColor = System.Drawing.Color.Blue;
            this.labCurAccount.Location = new System.Drawing.Point(2, 91);
            this.labCurAccount.Name = "labCurAccount";
            this.labCurAccount.Size = new System.Drawing.Size(599, 45);
            this.labCurAccount.TabIndex = 4;
            this.labCurAccount.Text = "123456789";
            this.labCurAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(599, 82);
            this.label3.TabIndex = 5;
            this.label3.Text = "当前账号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFotgotPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 353);
            this.Controls.Add(this.btnChooleShield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labCurPassWord);
            this.Controls.Add(this.labCurAccount);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFotgotPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找回主账号密码";
            this.Load += new System.EventHandler(this.frmFotgotPassWord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooleShield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCurPassWord;
        private System.Windows.Forms.Label labCurAccount;
        private System.Windows.Forms.Label label3;
    }
}
