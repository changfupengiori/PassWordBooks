namespace PassWordBooksWinFrom
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.palContent = new System.Windows.Forms.Panel();
            this.palHead = new System.Windows.Forms.Panel();
            this.palSearch = new System.Windows.Forms.Panel();
            this.palBgColor = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.labAccountTitle = new System.Windows.Forms.Label();
            this.labAccount = new System.Windows.Forms.Label();
            this.labSetter = new System.Windows.Forms.Label();
            this.palLeft = new System.Windows.Forms.Panel();
            this.palHead.SuspendLayout();
            this.palSearch.SuspendLayout();
            this.palBgColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // palContent
            // 
            this.palContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palContent.Location = new System.Drawing.Point(194, 63);
            this.palContent.Name = "palContent";
            this.palContent.Size = new System.Drawing.Size(1038, 490);
            this.palContent.TabIndex = 0;
            // 
            // palHead
            // 
            this.palHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.palHead.Controls.Add(this.palSearch);
            this.palHead.Controls.Add(this.labAccountTitle);
            this.palHead.Controls.Add(this.labAccount);
            this.palHead.Controls.Add(this.labSetter);
            this.palHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.palHead.Location = new System.Drawing.Point(0, 0);
            this.palHead.Name = "palHead";
            this.palHead.Size = new System.Drawing.Size(1232, 63);
            this.palHead.TabIndex = 1;
            // 
            // palSearch
            // 
            this.palSearch.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.palSearch.Controls.Add(this.palBgColor);
            this.palSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palSearch.Location = new System.Drawing.Point(200, 0);
            this.palSearch.Name = "palSearch";
            this.palSearch.Padding = new System.Windows.Forms.Padding(10);
            this.palSearch.Size = new System.Drawing.Size(732, 63);
            this.palSearch.TabIndex = 3;
            // 
            // palBgColor
            // 
            this.palBgColor.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.palBgColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.palBgColor.Controls.Add(this.tbxSearch);
            this.palBgColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palBgColor.Location = new System.Drawing.Point(10, 10);
            this.palBgColor.Name = "palBgColor";
            this.palBgColor.Padding = new System.Windows.Forms.Padding(10);
            this.palBgColor.Size = new System.Drawing.Size(712, 43);
            this.palBgColor.TabIndex = 4;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSearch.ForeColor = System.Drawing.Color.White;
            this.tbxSearch.Location = new System.Drawing.Point(10, 10);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(692, 23);
            this.tbxSearch.TabIndex = 0;
            // 
            // labAccountTitle
            // 
            this.labAccountTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.labAccountTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAccountTitle.ForeColor = System.Drawing.Color.White;
            this.labAccountTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labAccountTitle.Location = new System.Drawing.Point(932, 0);
            this.labAccountTitle.Name = "labAccountTitle";
            this.labAccountTitle.Size = new System.Drawing.Size(100, 63);
            this.labAccountTitle.TabIndex = 2;
            this.labAccountTitle.Text = "账号";
            this.labAccountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labAccount
            // 
            this.labAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labAccount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAccount.ForeColor = System.Drawing.Color.White;
            this.labAccount.Location = new System.Drawing.Point(1032, 0);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(200, 63);
            this.labAccount.TabIndex = 1;
            this.labAccount.Text = "13512345678";
            this.labAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labSetter
            // 
            this.labSetter.Dock = System.Windows.Forms.DockStyle.Left;
            this.labSetter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSetter.ForeColor = System.Drawing.Color.White;
            this.labSetter.Location = new System.Drawing.Point(0, 0);
            this.labSetter.Name = "labSetter";
            this.labSetter.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.labSetter.Size = new System.Drawing.Size(200, 63);
            this.labSetter.TabIndex = 0;
            this.labSetter.Text = "设置";
            this.labSetter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // palLeft
            // 
            this.palLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.palLeft.Location = new System.Drawing.Point(0, 63);
            this.palLeft.Name = "palLeft";
            this.palLeft.Size = new System.Drawing.Size(194, 490);
            this.palLeft.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 553);
            this.Controls.Add(this.palContent);
            this.Controls.Add(this.palLeft);
            this.Controls.Add(this.palHead);
            this.Name = "MainWindow";
            this.Text = "密码本";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.palHead.ResumeLayout(false);
            this.palSearch.ResumeLayout(false);
            this.palBgColor.ResumeLayout(false);
            this.palBgColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palContent;
        private System.Windows.Forms.Panel palHead;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.Label labSetter;
        private System.Windows.Forms.Label labAccountTitle;
        private System.Windows.Forms.Panel palSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel palBgColor;
        private System.Windows.Forms.Panel palLeft;
    }
}

