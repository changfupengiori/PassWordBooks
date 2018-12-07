namespace PassWordBooksWinFrom
{
    partial class frmVerifyPassWord
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labHelp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(340, 101);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "账户密码";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.Location = new System.Drawing.Point(93, 15);
            this.tbxPassWord.MaxLength = 230131;
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.Size = new System.Drawing.Size(322, 25);
            this.tbxPassWord.TabIndex = 24;
            this.tbxPassWord.UseSystemPasswordChar = true;
            this.tbxPassWord.TextChanged += new System.EventHandler(this.tbxPassWord_TextChanged);
            this.tbxPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassWord_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "密码提示";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHelp
            // 
            this.labHelp.Location = new System.Drawing.Point(93, 51);
            this.labHelp.Name = "labHelp";
            this.labHelp.Size = new System.Drawing.Size(322, 40);
            this.labHelp.TabIndex = 26;
            this.labHelp.Text = "自定义的密码提示";
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(160, 105);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(165, 15);
            this.labError.TabIndex = 26;
            this.labError.Text = "密码错误你还能输入3次";
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labError.Visible = false;
            // 
            // frmVerifyPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 137);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labHelp);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxPassWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerifyPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验证主账号密码";
            this.Load += new System.EventHandler(this.frmVerifyPassWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labError;
    }
}