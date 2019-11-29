namespace PosProject
{
    partial class FrmTranInq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTranInq));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tranGrid = new System.Windows.Forms.DataGridView();
            this.gridTranStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTranDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTranPosId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTranTradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tranGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(31, 211);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "날짜선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "거래번호 입력";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "보류",
            "거래완료",
            "거래취소",
            "복원"});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 88);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(248, 84);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "필터";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 454);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tranGrid
            // 
            this.tranGrid.AllowUserToAddRows = false;
            this.tranGrid.AllowUserToDeleteRows = false;
            this.tranGrid.AllowUserToResizeColumns = false;
            this.tranGrid.AllowUserToResizeRows = false;
            this.tranGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.tranGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tranGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridTranStatus,
            this.gridTranDate,
            this.gridTranPosId,
            this.gridTranTradeId});
            this.tranGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tranGrid.Location = new System.Drawing.Point(370, 88);
            this.tranGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tranGrid.MultiSelect = false;
            this.tranGrid.Name = "tranGrid";
            this.tranGrid.ReadOnly = true;
            this.tranGrid.RowHeadersVisible = false;
            this.tranGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tranGrid.RowTemplate.Height = 27;
            this.tranGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tranGrid.Size = new System.Drawing.Size(404, 391);
            this.tranGrid.TabIndex = 9;
            // 
            // gridTranStatus
            // 
            this.gridTranStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridTranStatus.HeaderText = "상태";
            this.gridTranStatus.Name = "gridTranStatus";
            this.gridTranStatus.ReadOnly = true;
            this.gridTranStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridTranDate
            // 
            this.gridTranDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridTranDate.HeaderText = "날짜";
            this.gridTranDate.Name = "gridTranDate";
            this.gridTranDate.ReadOnly = true;
            this.gridTranDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridTranPosId
            // 
            this.gridTranPosId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridTranPosId.HeaderText = "포스Id";
            this.gridTranPosId.Name = "gridTranPosId";
            this.gridTranPosId.ReadOnly = true;
            this.gridTranPosId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridTranTradeId
            // 
            this.gridTranTradeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridTranTradeId.HeaderText = "거래Id";
            this.gridTranTradeId.Name = "gridTranTradeId";
            this.gridTranTradeId.ReadOnly = true;
            this.gridTranTradeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmTranInq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(811, 526);
            this.Controls.Add(this.tranGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTranInq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "거래내역조회";
            this.Load += new System.EventHandler(this.FrmTranInq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tranGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView tranGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTranStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTranDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTranPosId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTranTradeId;
    }
}