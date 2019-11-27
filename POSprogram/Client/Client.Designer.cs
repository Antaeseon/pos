namespace Client
{
    partial class Client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.cItemGrid = new System.Windows.Forms.DataGridView();
            this.grdItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cItemGrid
            // 
            this.cItemGrid.AllowUserToAddRows = false;
            this.cItemGrid.AllowUserToDeleteRows = false;
            this.cItemGrid.AllowUserToResizeColumns = false;
            this.cItemGrid.AllowUserToResizeRows = false;
            this.cItemGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.cItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItemId,
            this.grdItemName,
            this.grdItemNum,
            this.grdItemPrice,
            this.grdItemTotal});
            this.cItemGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cItemGrid.Location = new System.Drawing.Point(26, 41);
            this.cItemGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cItemGrid.MultiSelect = false;
            this.cItemGrid.Name = "cItemGrid";
            this.cItemGrid.ReadOnly = true;
            this.cItemGrid.RowHeadersVisible = false;
            this.cItemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cItemGrid.RowTemplate.Height = 27;
            this.cItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cItemGrid.Size = new System.Drawing.Size(414, 251);
            this.cItemGrid.TabIndex = 5;
            // 
            // grdItemId
            // 
            this.grdItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdItemId.HeaderText = "아이템아이디";
            this.grdItemId.Name = "grdItemId";
            this.grdItemId.ReadOnly = true;
            this.grdItemId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdItemId.Visible = false;
            // 
            // grdItemName
            // 
            this.grdItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdItemName.HeaderText = "상품명";
            this.grdItemName.Name = "grdItemName";
            this.grdItemName.ReadOnly = true;
            this.grdItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grdItemNum
            // 
            this.grdItemNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdItemNum.HeaderText = "수량";
            this.grdItemNum.Name = "grdItemNum";
            this.grdItemNum.ReadOnly = true;
            this.grdItemNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grdItemPrice
            // 
            this.grdItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdItemPrice.HeaderText = "단가";
            this.grdItemPrice.Name = "grdItemPrice";
            this.grdItemPrice.ReadOnly = true;
            this.grdItemPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grdItemTotal
            // 
            this.grdItemTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdItemTotal.HeaderText = "합계";
            this.grdItemTotal.Name = "grdItemTotal";
            this.grdItemTotal.ReadOnly = true;
            this.grdItemTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(127, 380);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(15, 15);
            this.totalLbl.TabIndex = 16;
            this.totalLbl.Text = "0";
            // 
            // discountLbl
            // 
            this.discountLbl.AutoSize = true;
            this.discountLbl.Location = new System.Drawing.Point(127, 348);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(15, 15);
            this.discountLbl.TabIndex = 15;
            this.discountLbl.Text = "0";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(127, 317);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(15, 15);
            this.priceLbl.TabIndex = 14;
            this.priceLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "결제";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "할인";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "합계";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 423);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cItemGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView cItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemTotal;
        public System.Windows.Forms.Label totalLbl;
        public System.Windows.Forms.Label discountLbl;
        public System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

