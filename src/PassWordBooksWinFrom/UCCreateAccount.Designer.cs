namespace PassWordBooksWinFrom
{
    partial class ucCreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextStep1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNextStep2 = new System.Windows.Forms.Button();
            this.tbxRemark = new System.Windows.Forms.TextBox();
            this.tbxPassWordHelp = new System.Windows.Forms.TextBox();
            this.tbxPassWordConfirm = new System.Windows.Forms.TextBox();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbkIsComputer = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveShield = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNextStep1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 354);
            this.panel1.TabIndex = 0;
            // 
            // btnNextStep1
            // 
            this.btnNextStep1.Location = new System.Drawing.Point(272, 146);
            this.btnNextStep1.Name = "btnNextStep1";
            this.btnNextStep1.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep1.TabIndex = 1;
            this.btnNextStep1.Text = "创建账户";
            this.btnNextStep1.UseVisualStyleBackColor = true;
            this.btnNextStep1.Click += new System.EventHandler(this.btnNextStep1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 92);
            this.label2.TabIndex = 0;
            this.label2.Text = "    此系统是本地版本数据不存储在云端，请放行使用。本系统也不缓存和加密缓存用户的手机、邮箱、账户密码等用户隐私信息。用户的密码本采用主账号的数据作加密处理以保" +
    "证除了用户自己提供密码外其他人都无法解开密码本。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前系统并没有创建账号，立即去创建一个账号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNextStep2);
            this.panel2.Controls.Add(this.tbxRemark);
            this.panel2.Controls.Add(this.tbxPassWordHelp);
            this.panel2.Controls.Add(this.tbxPassWordConfirm);
            this.panel2.Controls.Add(this.tbxPassWord);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbxAccount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 354);
            this.panel2.TabIndex = 2;
            // 
            // btnNextStep2
            // 
            this.btnNextStep2.Location = new System.Drawing.Point(289, 322);
            this.btnNextStep2.Name = "btnNextStep2";
            this.btnNextStep2.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep2.TabIndex = 6;
            this.btnNextStep2.Text = "创建账户";
            this.btnNextStep2.UseVisualStyleBackColor = true;
            this.btnNextStep2.Click += new System.EventHandler(this.btnNextStep2_Click);
            // 
            // tbxRemark
            // 
            this.tbxRemark.Location = new System.Drawing.Point(101, 247);
            this.tbxRemark.Multiline = true;
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.Size = new System.Drawing.Size(568, 67);
            this.tbxRemark.TabIndex = 5;
            this.tbxRemark.UseSystemPasswordChar = true;
            // 
            // tbxPassWordHelp
            // 
            this.tbxPassWordHelp.Location = new System.Drawing.Point(101, 181);
            this.tbxPassWordHelp.Name = "tbxPassWordHelp";
            this.tbxPassWordHelp.Size = new System.Drawing.Size(568, 25);
            this.tbxPassWordHelp.TabIndex = 4;
            this.tbxPassWordHelp.Leave += new System.EventHandler(this.tbxPassWordHelp_Leave);
            // 
            // tbxPassWordConfirm
            // 
            this.tbxPassWordConfirm.Location = new System.Drawing.Point(101, 124);
            this.tbxPassWordConfirm.Name = "tbxPassWordConfirm";
            this.tbxPassWordConfirm.Size = new System.Drawing.Size(568, 25);
            this.tbxPassWordConfirm.TabIndex = 3;
            this.tbxPassWordConfirm.UseSystemPasswordChar = true;
            this.tbxPassWordConfirm.Leave += new System.EventHandler(this.tbxPassWordConfirm_Leave);
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.Location = new System.Drawing.Point(101, 67);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.Size = new System.Drawing.Size(568, 25);
            this.tbxPassWord.TabIndex = 2;
            this.tbxPassWord.UseSystemPasswordChar = true;
            this.tbxPassWord.Leave += new System.EventHandler(this.tbxPassWord_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "描述信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "密码提示";
            // 
            // tbxAccount
            // 
            this.tbxAccount.Location = new System.Drawing.Point(101, 10);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(568, 25);
            this.tbxAccount.TabIndex = 1;
            this.tbxAccount.Leave += new System.EventHandler(this.tbxAccount_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "确认密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "账户密码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(101, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "密码提示文档。不能和密码相同";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(101, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(533, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "密码必须包含 8个或更多字符，并同时包含大写和小写字母，以及至少一个数字";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(101, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "账号包含4个或最多15个字符的组合。账号不能重复";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "账户名称";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbkIsComputer);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnSaveShield);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(0, 723);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 354);
            this.panel3.TabIndex = 2;
            // 
            // cbkIsComputer
            // 
            this.cbkIsComputer.AutoSize = true;
            this.cbkIsComputer.Location = new System.Drawing.Point(268, 131);
            this.cbkIsComputer.Name = "cbkIsComputer";
            this.cbkIsComputer.Size = new System.Drawing.Size(104, 19);
            this.cbkIsComputer.TabIndex = 3;
            this.cbkIsComputer.Text = "机器码加密";
            this.cbkIsComputer.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(86, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(562, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "式如果勾选机器加密，此系统保存的密码本仅能在当前计算机使用。\r\n请勿更换CPU。";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(72, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(562, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "此密保请和本系统分开存储。\r\n密保用于用户忘记密码找回密码使用，密保文件加密存储了用户账号和密码等数据。";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveShield
            // 
            this.btnSaveShield.Location = new System.Drawing.Point(275, 209);
            this.btnSaveShield.Name = "btnSaveShield";
            this.btnSaveShield.Size = new System.Drawing.Size(75, 23);
            this.btnSaveShield.TabIndex = 1;
            this.btnSaveShield.Text = "保存密保";
            this.btnSaveShield.UseVisualStyleBackColor = true;
            this.btnSaveShield.Click += new System.EventHandler(this.btnSaveShield_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(688, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "账号创建成功，请保存密保";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucCreateAccount";
            this.Size = new System.Drawing.Size(700, 1158);
            this.Load += new System.EventHandler(this.ucCreateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNextStep1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNextStep2;
        private System.Windows.Forms.TextBox tbxRemark;
        private System.Windows.Forms.TextBox tbxPassWordHelp;
        private System.Windows.Forms.TextBox tbxPassWordConfirm;
        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbkIsComputer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveShield;
        private System.Windows.Forms.Label label12;
    }
}
