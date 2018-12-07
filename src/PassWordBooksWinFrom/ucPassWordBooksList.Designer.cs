namespace PassWordBooksWinFrom
{
    partial class ucPassWordBooksList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palNullData = new System.Windows.Forms.Panel();
            this.btnAddPassWordBook1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.palDataList = new System.Windows.Forms.Panel();
            this.btnDelPassWordBook = new System.Windows.Forms.Button();
            this.btnAddPassWordBook = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.palNullData.SuspendLayout();
            this.palDataList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(700, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // palNullData
            // 
            this.palNullData.Controls.Add(this.btnAddPassWordBook1);
            this.palNullData.Controls.Add(this.label3);
            this.palNullData.Location = new System.Drawing.Point(0, 400);
            this.palNullData.Name = "palNullData";
            this.palNullData.Size = new System.Drawing.Size(700, 400);
            this.palNullData.TabIndex = 1;
            // 
            // btnAddPassWordBook1
            // 
            this.btnAddPassWordBook1.Location = new System.Drawing.Point(282, 213);
            this.btnAddPassWordBook1.Name = "btnAddPassWordBook1";
            this.btnAddPassWordBook1.Size = new System.Drawing.Size(100, 30);
            this.btnAddPassWordBook1.TabIndex = 3;
            this.btnAddPassWordBook1.Text = "添加密码本";
            this.btnAddPassWordBook1.UseVisualStyleBackColor = true;
            this.btnAddPassWordBook1.Click += new System.EventHandler(this.btnAddPassWordBook_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("楷体", 9F);
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(688, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "你还未添加任何的密码本，立马添加一个";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palDataList
            // 
            this.palDataList.Controls.Add(this.btnShow);
            this.palDataList.Controls.Add(this.btnDelPassWordBook);
            this.palDataList.Controls.Add(this.btnAddPassWordBook);
            this.palDataList.Controls.Add(this.dataGridView1);
            this.palDataList.Location = new System.Drawing.Point(0, 0);
            this.palDataList.Name = "palDataList";
            this.palDataList.Size = new System.Drawing.Size(700, 400);
            this.palDataList.TabIndex = 2;
            // 
            // btnDelPassWordBook
            // 
            this.btnDelPassWordBook.Location = new System.Drawing.Point(443, 12);
            this.btnDelPassWordBook.Name = "btnDelPassWordBook";
            this.btnDelPassWordBook.Size = new System.Drawing.Size(120, 30);
            this.btnDelPassWordBook.TabIndex = 3;
            this.btnDelPassWordBook.Text = "删除密码本";
            this.btnDelPassWordBook.UseVisualStyleBackColor = true;
            this.btnDelPassWordBook.Click += new System.EventHandler(this.btnDelPassWordBook_Click);
            // 
            // btnAddPassWordBook
            // 
            this.btnAddPassWordBook.Location = new System.Drawing.Point(576, 12);
            this.btnAddPassWordBook.Name = "btnAddPassWordBook";
            this.btnAddPassWordBook.Size = new System.Drawing.Size(120, 30);
            this.btnAddPassWordBook.TabIndex = 3;
            this.btnAddPassWordBook.Text = "添加密码本";
            this.btnAddPassWordBook.UseVisualStyleBackColor = true;
            this.btnAddPassWordBook.Click += new System.EventHandler(this.btnAddPassWordBook_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(310, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 30);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "删除密码本";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnDelPassWordBook_Click);
            // 
            // ucPassWordBooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.palDataList);
            this.Controls.Add(this.palNullData);
            this.Name = "ucPassWordBooksList";
            this.Size = new System.Drawing.Size(700, 800);
            this.Load += new System.EventHandler(this.ucPassWordBooksList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.palNullData.ResumeLayout(false);
            this.palDataList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel palNullData;
        private System.Windows.Forms.Button btnAddPassWordBook1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel palDataList;
        private System.Windows.Forms.Button btnDelPassWordBook;
        private System.Windows.Forms.Button btnAddPassWordBook;
        private System.Windows.Forms.Button btnShow;
    }
}
