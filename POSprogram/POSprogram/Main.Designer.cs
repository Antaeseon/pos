namespace PosProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.grdItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.inquireItemBtn = new System.Windows.Forms.Button();
            this.inquireDisBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.selectCancelBtn = new System.Windows.Forms.Button();
            this.allCancelBtn = new System.Windows.Forms.Button();
            this.recoverBtn = new System.Windows.Forms.Button();
            this.adminBtn1 = new System.Windows.Forms.Button();
            this.adminBtn2 = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.adminOffBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.receiveLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.restLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tranBtn = new System.Windows.Forms.Button();
            this.saleCancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "상품등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClick);
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToResizeColumns = false;
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItemId,
            this.grdItemName,
            this.grdItemNum,
            this.grdItemPrice,
            this.grdItemTotal,
            this.cancelFlag});
            this.itemGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.itemGrid.Location = new System.Drawing.Point(39, 73);
            this.itemGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemGrid.MultiSelect = false;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid.RowTemplate.Height = 27;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(555, 251);
            this.itemGrid.TabIndex = 4;
            this.itemGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.itemGrid_CellFormatting);
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
            // cancelFlag
            // 
            this.cancelFlag.HeaderText = "취소플래그";
            this.cancelFlag.Name = "cancelFlag";
            this.cancelFlag.ReadOnly = true;
            this.cancelFlag.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "합계금액";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "할인금액";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "결제금액";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(109, 1);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(131, 15);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.Text = "0";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountLbl
            // 
            this.discountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLbl.AutoSize = true;
            this.discountLbl.Location = new System.Drawing.Point(109, 18);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(131, 15);
            this.discountLbl.TabIndex = 9;
            this.discountLbl.Text = "0";
            this.discountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLbl
            // 
            this.totalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(109, 52);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(131, 15);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "0";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(418, 391);
            this.payBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(78, 32);
            this.payBtn.TabIndex = 12;
            this.payBtn.Text = "결제";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // inquireItemBtn
            // 
            this.inquireItemBtn.Location = new System.Drawing.Point(516, 337);
            this.inquireItemBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inquireItemBtn.Name = "inquireItemBtn";
            this.inquireItemBtn.Size = new System.Drawing.Size(78, 32);
            this.inquireItemBtn.TabIndex = 13;
            this.inquireItemBtn.Text = "상품조회";
            this.inquireItemBtn.UseVisualStyleBackColor = true;
            this.inquireItemBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // inquireDisBtn
            // 
            this.inquireDisBtn.Location = new System.Drawing.Point(516, 391);
            this.inquireDisBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inquireDisBtn.Name = "inquireDisBtn";
            this.inquireDisBtn.Size = new System.Drawing.Size(78, 32);
            this.inquireDisBtn.TabIndex = 14;
            this.inquireDisBtn.Text = "행사조회";
            this.inquireDisBtn.UseVisualStyleBackColor = true;
            this.inquireDisBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminBtn.Location = new System.Drawing.Point(333, 14);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(82, 30);
            this.adminBtn.TabIndex = 15;
            this.adminBtn.Text = "관리자";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Visible = false;
            this.adminBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // selectCancelBtn
            // 
            this.selectCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectCancelBtn.Location = new System.Drawing.Point(3, 5);
            this.selectCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectCancelBtn.Name = "selectCancelBtn";
            this.selectCancelBtn.Size = new System.Drawing.Size(86, 30);
            this.selectCancelBtn.TabIndex = 16;
            this.selectCancelBtn.Text = "지정취소";
            this.selectCancelBtn.UseVisualStyleBackColor = true;
            this.selectCancelBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // allCancelBtn
            // 
            this.allCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allCancelBtn.Location = new System.Drawing.Point(95, 5);
            this.allCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allCancelBtn.Name = "allCancelBtn";
            this.allCancelBtn.Size = new System.Drawing.Size(86, 30);
            this.allCancelBtn.TabIndex = 17;
            this.allCancelBtn.Text = "일괄취소";
            this.allCancelBtn.UseVisualStyleBackColor = true;
            this.allCancelBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // recoverBtn
            // 
            this.recoverBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recoverBtn.Location = new System.Drawing.Point(187, 5);
            this.recoverBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoverBtn.Name = "recoverBtn";
            this.recoverBtn.Size = new System.Drawing.Size(86, 30);
            this.recoverBtn.TabIndex = 18;
            this.recoverBtn.Text = "보류/복원";
            this.recoverBtn.UseVisualStyleBackColor = true;
            this.recoverBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // adminBtn1
            // 
            this.adminBtn1.Location = new System.Drawing.Point(-2, 454);
            this.adminBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminBtn1.Name = "adminBtn1";
            this.adminBtn1.Size = new System.Drawing.Size(89, 26);
            this.adminBtn1.TabIndex = 19;
            this.adminBtn1.UseVisualStyleBackColor = true;
            this.adminBtn1.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminBtn2
            // 
            this.adminBtn2.Location = new System.Drawing.Point(545, 454);
            this.adminBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminBtn2.Name = "adminBtn2";
            this.adminBtn2.Size = new System.Drawing.Size(89, 26);
            this.adminBtn2.TabIndex = 20;
            this.adminBtn2.UseVisualStyleBackColor = true;
            this.adminBtn2.Click += new System.EventHandler(this.button3_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logOutBtn.Location = new System.Drawing.Point(463, 5);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(89, 30);
            this.logOutBtn.TabIndex = 21;
            this.logOutBtn.Text = "관리자Off";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // adminOffBtn
            // 
            this.adminOffBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminOffBtn.Location = new System.Drawing.Point(438, 14);
            this.adminOffBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminOffBtn.Name = "adminOffBtn";
            this.adminOffBtn.Size = new System.Drawing.Size(82, 30);
            this.adminOffBtn.TabIndex = 22;
            this.adminOffBtn.Text = "관리자off";
            this.adminOffBtn.UseVisualStyleBackColor = false;
            this.adminOffBtn.Visible = false;
            this.adminOffBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "받은금액";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiveLbl
            // 
            this.receiveLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveLbl.AutoSize = true;
            this.receiveLbl.Location = new System.Drawing.Point(109, 35);
            this.receiveLbl.Name = "receiveLbl";
            this.receiveLbl.Size = new System.Drawing.Size(131, 15);
            this.receiveLbl.TabIndex = 24;
            this.receiveLbl.Text = "0";
            this.receiveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.57143F));
            this.tableLayoutPanel1.Controls.Add(this.restLbl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.receiveLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.discountLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalLbl, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 339);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 86);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // restLbl
            // 
            this.restLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.restLbl.AutoSize = true;
            this.restLbl.Location = new System.Drawing.Point(109, 69);
            this.restLbl.Name = "restLbl";
            this.restLbl.Size = new System.Drawing.Size(131, 15);
            this.restLbl.TabIndex = 26;
            this.restLbl.Text = "0";
            this.restLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "남은금액";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.saleCancelBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tranBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectCancelBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.allCancelBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.recoverBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.logOutBtn, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 40);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // tranBtn
            // 
            this.tranBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tranBtn.Location = new System.Drawing.Point(279, 5);
            this.tranBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tranBtn.Name = "tranBtn";
            this.tranBtn.Size = new System.Drawing.Size(86, 30);
            this.tranBtn.TabIndex = 22;
            this.tranBtn.Text = "거래조회";
            this.tranBtn.UseVisualStyleBackColor = true;
            this.tranBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // saleCancelBtn
            // 
            this.saleCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saleCancelBtn.Location = new System.Drawing.Point(371, 5);
            this.saleCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saleCancelBtn.Name = "saleCancelBtn";
            this.saleCancelBtn.Size = new System.Drawing.Size(86, 30);
            this.saleCancelBtn.TabIndex = 27;
            this.saleCancelBtn.Text = "매출취소";
            this.saleCancelBtn.UseVisualStyleBackColor = true;
            this.saleCancelBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(635, 479);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.adminOffBtn);
            this.Controls.Add(this.adminBtn2);
            this.Controls.Add(this.adminBtn1);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.inquireDisBtn);
            this.Controls.Add(this.inquireItemBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 499);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I&C POS";
            this.Load += new System.EventHandler(this.posScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button payBtn;
        public System.Windows.Forms.Label priceLbl;
        public System.Windows.Forms.DataGridView itemGrid;
        public System.Windows.Forms.Label discountLbl;
        public System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button inquireItemBtn;
        private System.Windows.Forms.Button inquireDisBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button selectCancelBtn;
        private System.Windows.Forms.Button allCancelBtn;
        private System.Windows.Forms.Button recoverBtn;
        private System.Windows.Forms.Button adminBtn1;
        private System.Windows.Forms.Button adminBtn2;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button adminOffBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdItemTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelFlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label receiveLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label restLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button tranBtn;
        private System.Windows.Forms.Button saleCancelBtn;
    }
}

