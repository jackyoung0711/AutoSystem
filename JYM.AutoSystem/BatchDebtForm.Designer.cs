namespace JYM.AutoSystem
{
    partial class BatchDebtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchDebtForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.ck_IsSelectedAll = new System.Windows.Forms.CheckBox();
            this.lbl_showOperate = new System.Windows.Forms.Label();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.cbx_pageSize = new System.Windows.Forms.ComboBox();
            this.lbl_pageinfo2 = new System.Windows.Forms.Label();
            this.lbl_pageinfo1 = new System.Windows.Forms.Label();
            this.txt_pageIndex = new System.Windows.Forms.TextBox();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.btn_LastPage = new System.Windows.Forms.Button();
            this.btn_FirstPage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloum9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.ck_IsSelectedAll);
            this.gb_data.Controls.Add(this.lbl_showOperate);
            this.gb_data.Controls.Add(this.picShow);
            this.gb_data.Controls.Add(this.cbx_pageSize);
            this.gb_data.Controls.Add(this.lbl_pageinfo2);
            this.gb_data.Controls.Add(this.lbl_pageinfo1);
            this.gb_data.Controls.Add(this.txt_pageIndex);
            this.gb_data.Controls.Add(this.btn_right);
            this.gb_data.Controls.Add(this.btn_left);
            this.gb_data.Controls.Add(this.btn_Go);
            this.gb_data.Controls.Add(this.btn_LastPage);
            this.gb_data.Controls.Add(this.btn_FirstPage);
            this.gb_data.Controls.Add(this.label3);
            this.gb_data.Controls.Add(this.dgv_Data);
            this.gb_data.Location = new System.Drawing.Point(1, 113);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(1339, 634);
            this.gb_data.TabIndex = 5;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "查询结果";
            // 
            // ck_IsSelectedAll
            // 
            this.ck_IsSelectedAll.AutoSize = true;
            this.ck_IsSelectedAll.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_IsSelectedAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ck_IsSelectedAll.Location = new System.Drawing.Point(25, 14);
            this.ck_IsSelectedAll.Name = "ck_IsSelectedAll";
            this.ck_IsSelectedAll.Size = new System.Drawing.Size(132, 23);
            this.ck_IsSelectedAll.TabIndex = 61;
            this.ck_IsSelectedAll.Text = "选中该页所有数据";
            this.ck_IsSelectedAll.UseVisualStyleBackColor = true;
            // 
            // lbl_showOperate
            // 
            this.lbl_showOperate.AutoSize = true;
            this.lbl_showOperate.Font = new System.Drawing.Font("微软雅黑", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showOperate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_showOperate.Location = new System.Drawing.Point(870, 600);
            this.lbl_showOperate.Name = "lbl_showOperate";
            this.lbl_showOperate.Size = new System.Drawing.Size(0, 19);
            this.lbl_showOperate.TabIndex = 60;
            // 
            // picShow
            // 
            this.picShow.BackColor = System.Drawing.Color.Transparent;
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(502, 185);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(274, 239);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picShow.TabIndex = 59;
            this.picShow.TabStop = false;
            // 
            // cbx_pageSize
            // 
            this.cbx_pageSize.FormattingEnabled = true;
            this.cbx_pageSize.Items.AddRange(new object[] {
            "30",
            "50",
            "100",
            "200",
            "500",
            "1000"});
            this.cbx_pageSize.Location = new System.Drawing.Point(607, 601);
            this.cbx_pageSize.Name = "cbx_pageSize";
            this.cbx_pageSize.Size = new System.Drawing.Size(58, 21);
            this.cbx_pageSize.TabIndex = 56;
            // 
            // lbl_pageinfo2
            // 
            this.lbl_pageinfo2.AutoSize = true;
            this.lbl_pageinfo2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pageinfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pageinfo2.Location = new System.Drawing.Point(671, 601);
            this.lbl_pageinfo2.Name = "lbl_pageinfo2";
            this.lbl_pageinfo2.Size = new System.Drawing.Size(156, 19);
            this.lbl_pageinfo2.TabIndex = 54;
            this.lbl_pageinfo2.Text = "1/25   总共12345条记录";
            // 
            // lbl_pageinfo1
            // 
            this.lbl_pageinfo1.AutoSize = true;
            this.lbl_pageinfo1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pageinfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pageinfo1.Location = new System.Drawing.Point(568, 598);
            this.lbl_pageinfo1.Name = "lbl_pageinfo1";
            this.lbl_pageinfo1.Size = new System.Drawing.Size(35, 19);
            this.lbl_pageinfo1.TabIndex = 55;
            this.lbl_pageinfo1.Text = "每页";
            // 
            // txt_pageIndex
            // 
            this.txt_pageIndex.Location = new System.Drawing.Point(390, 601);
            this.txt_pageIndex.Name = "txt_pageIndex";
            this.txt_pageIndex.Size = new System.Drawing.Size(89, 20);
            this.txt_pageIndex.TabIndex = 53;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(241, 598);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(63, 25);
            this.btn_right.TabIndex = 48;
            this.btn_right.Text = ">|";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(165, 598);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(61, 25);
            this.btn_left.TabIndex = 49;
            this.btn_left.Text = "|<";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(485, 598);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(77, 25);
            this.btn_Go.TabIndex = 50;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.Location = new System.Drawing.Point(310, 598);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new System.Drawing.Size(70, 25);
            this.btn_LastPage.TabIndex = 51;
            this.btn_LastPage.Text = "末页";
            this.btn_LastPage.UseVisualStyleBackColor = true;
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Location = new System.Drawing.Point(92, 598);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(67, 25);
            this.btn_FirstPage.TabIndex = 52;
            this.btn_FirstPage.Text = "首页";
            this.btn_FirstPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "翻页浏览:";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column3,
            this.Column5,
            this.cloum9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Data.Location = new System.Drawing.Point(9, 43);
            this.dgv_Data.MultiSelect = false;
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersVisible = false;
            this.dgv_Data.RowTemplate.Height = 23;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(1318, 549);
            this.dgv_Data.TabIndex = 1;
            this.dgv_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellContentClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "选项";
            this.Column9.Name = "Column9";
            this.Column9.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserId";
            this.Column2.HeaderText = "UserId";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UserAssetRatioId";
            this.Column4.HeaderText = "UserAssetRatioId";
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OriginalUserAssetRatioId";
            this.Column6.HeaderText = "OriginalUserAssetRatioId";
            this.Column6.Name = "Column6";
            this.Column6.Width = 170;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "AssetId";
            this.Column7.HeaderText = "AssetId";
            this.Column7.Name = "Column7";
            this.Column7.Width = 170;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Principal";
            this.Column1.HeaderText = "Principal";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PrincipalInterest";
            this.Column3.HeaderText = "PrincipalInterest";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OrderId";
            this.Column5.HeaderText = "OrderId";
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // cloum9
            // 
            this.cloum9.DataPropertyName = "ChildOrderId";
            this.cloum9.HeaderText = "ChildOrderId";
            this.cloum9.Name = "cloum9";
            this.cloum9.Width = 170;
            // 
            // BatchDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 759);
            this.Controls.Add(this.gb_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BatchDebtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量赎回";
            this.Load += new System.EventHandler(this.BatchDebtForm_Load);
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_data;
        private System.Windows.Forms.CheckBox ck_IsSelectedAll;
        private System.Windows.Forms.Label lbl_showOperate;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.ComboBox cbx_pageSize;
        private System.Windows.Forms.Label lbl_pageinfo2;
        private System.Windows.Forms.Label lbl_pageinfo1;
        private System.Windows.Forms.TextBox txt_pageIndex;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Button btn_LastPage;
        private System.Windows.Forms.Button btn_FirstPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloum9;
    }
}