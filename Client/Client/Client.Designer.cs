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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.receiveLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cItemGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.cItemGrid.Location = new System.Drawing.Point(29, 26);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.57143F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.receiveLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.discountLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalLbl, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.32467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.32467F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 79);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "합계금액";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiveLbl
            // 
            this.receiveLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveLbl.AutoSize = true;
            this.receiveLbl.Location = new System.Drawing.Point(91, 40);
            this.receiveLbl.Name = "receiveLbl";
            this.receiveLbl.Size = new System.Drawing.Size(107, 15);
            this.receiveLbl.TabIndex = 24;
            this.receiveLbl.Text = "0";
            this.receiveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "할인금액";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "받은금액";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "결제금액";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(91, 2);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(107, 15);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.Text = "0";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountLbl
            // 
            this.discountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLbl.AutoSize = true;
            this.discountLbl.Location = new System.Drawing.Point(91, 21);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(107, 15);
            this.discountLbl.TabIndex = 9;
            this.discountLbl.Text = "0";
            this.discountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLbl
            // 
            this.totalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(91, 60);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(107, 15);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "0";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cItemGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cItemGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView cItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label receiveLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label priceLbl;
        public System.Windows.Forms.Label discountLbl;
        public System.Windows.Forms.Label totalLbl;
    }
}

