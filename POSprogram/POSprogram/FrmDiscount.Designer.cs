namespace PosProject
{
    partial class FrmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiscount));
            this.discountGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dfDisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.discountGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // discountGrid
            // 
            this.discountGrid.AllowUserToAddRows = false;
            this.discountGrid.AllowUserToDeleteRows = false;
            this.discountGrid.AllowUserToResizeColumns = false;
            this.discountGrid.AllowUserToResizeRows = false;
            this.discountGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.discountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dfDisId,
            this.dfItemId,
            this.dfItemName,
            this.dfCategory,
            this.dfDiscount});
            this.discountGrid.Location = new System.Drawing.Point(14, 15);
            this.discountGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.discountGrid.MinimumSize = new System.Drawing.Size(394, 390);
            this.discountGrid.MultiSelect = false;
            this.discountGrid.Name = "discountGrid";
            this.discountGrid.ReadOnly = true;
            this.discountGrid.RowHeadersVisible = false;
            this.discountGrid.RowTemplate.Height = 23;
            this.discountGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.discountGrid.Size = new System.Drawing.Size(519, 390);
            this.discountGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "행사ID";
            // 
            // idTxt
            // 
            this.idTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idTxt.Location = new System.Drawing.Point(168, 434);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.MaxLength = 10;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(171, 25);
            this.idTxt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(357, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dfDisId
            // 
            this.dfDisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dfDisId.HeaderText = "행사ID";
            this.dfDisId.Name = "dfDisId";
            this.dfDisId.ReadOnly = true;
            // 
            // dfItemId
            // 
            this.dfItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dfItemId.HeaderText = "상품ID";
            this.dfItemId.Name = "dfItemId";
            this.dfItemId.ReadOnly = true;
            // 
            // dfItemName
            // 
            this.dfItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dfItemName.HeaderText = "상품명";
            this.dfItemName.Name = "dfItemName";
            this.dfItemName.ReadOnly = true;
            // 
            // dfCategory
            // 
            this.dfCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dfCategory.HeaderText = "구분";
            this.dfCategory.Name = "dfCategory";
            this.dfCategory.ReadOnly = true;
            // 
            // dfDiscount
            // 
            this.dfDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dfDiscount.HeaderText = "할인";
            this.dfDiscount.Name = "dfDiscount";
            this.dfDiscount.ReadOnly = true;
            // 
            // discountInqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(558, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discountGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(573, 535);
            this.Name = "discountInqForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "행사목록";
            this.Load += new System.EventHandler(this.discountInqForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discountGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView discountGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfDisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfDiscount;
    }
}