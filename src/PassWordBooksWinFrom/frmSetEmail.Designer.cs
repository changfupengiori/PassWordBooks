namespace PassWordBooksWinFrom
{
    partial class frmSetEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxVerifyCode = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.tbxOldEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labOldEmailTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(293, 158);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "新邮箱地址";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(90, 78);
            this.tbxEmail.MaxLength = 200;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(305, 25);
            this.tbxEmail.TabIndex = 24;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "验证码";
            // 
            // tbxVerifyCode
            // 
            this.tbxVerifyCode.Location = new System.Drawing.Point(90, 117);
            this.tbxVerifyCode.MaxLength = 6;
            this.tbxVerifyCode.Name = "tbxVerifyCode";
            this.tbxVerifyCode.Size = new System.Drawing.Size(122, 25);
            this.tbxVerifyCode.TabIndex = 27;
            this.tbxVerifyCode.TextChanged += new System.EventHandler(this.tbxVerifyCode_TextChanged);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Enabled = false;
            this.btnSendCode.Location = new System.Drawing.Point(293, 117);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(100, 30);
            this.btnSendCode.TabIndex = 25;
            this.btnSendCode.Text = "发送验证码";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(90, 159);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(67, 15);
            this.labError.TabIndex = 29;
            this.labError.Text = "验证错误";
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labError.Visible = false;
            // 
            // tbxOldEmail
            // 
            this.tbxOldEmail.Location = new System.Drawing.Point(90, 10);
            this.tbxOldEmail.MaxLength = 200;
            this.tbxOldEmail.Name = "tbxOldEmail";
            this.tbxOldEmail.Size = new System.Drawing.Size(305, 25);
            this.tbxOldEmail.TabIndex = 24;
            this.tbxOldEmail.Leave += new System.EventHandler(this.tbxOldEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "旧邮箱地址";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "邮箱提示";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labOldEmailTip
            // 
            this.labOldEmailTip.AutoSize = true;
            this.labOldEmailTip.ForeColor = System.Drawing.Color.Gray;
            this.labOldEmailTip.Location = new System.Drawing.Point(90, 49);
            this.labOldEmailTip.Name = "labOldEmailTip";
            this.labOldEmailTip.Size = new System.Drawing.Size(82, 15);
            this.labOldEmailTip.TabIndex = 26;
            this.labOldEmailTip.Text = "旧邮箱提示";
            this.labOldEmailTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSetEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 198);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxVerifyCode);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labOldEmailTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxOldEmail);
            this.Controls.Add(this.tbxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置用户邮箱";
            this.Load += new System.EventHandler(this.frmSetEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxVerifyCode;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.TextBox tbxOldEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labOldEmailTip;
    }
}