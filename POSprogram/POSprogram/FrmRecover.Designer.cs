namespace PosProject
{
    partial class FrmRecover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecover));
            this.recoverGrid = new System.Windows.Forms.DataGridView();
            this.posIdRc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeIdRc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDateRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoverBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recoverGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recoverGrid
            // 
            this.recoverGrid.AllowUserToAddRows = false;
            this.recoverGrid.AllowUserToDeleteRows = false;
            this.recoverGrid.AllowUserToResizeColumns = false;
            this.recoverGrid.AllowUserToResizeRows = false;
            this.recoverGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.recoverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recoverGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posIdRc,
            this.tradeIdRc,
            this.tradeDateRec});
            this.recoverGrid.Location = new System.Drawing.Point(32, 22);
            this.recoverGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoverGrid.MultiSelect = false;
            this.recoverGrid.Name = "recoverGrid";
            this.recoverGrid.ReadOnly = true;
            this.recoverGrid.RowHeadersVisible = false;
            this.recoverGrid.RowTemplate.Height = 27;
            this.recoverGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recoverGrid.Size = new System.Drawing.Size(286, 278);
            this.recoverGrid.TabIndex = 0;
            // 
            // posIdRc
            // 
            this.posIdRc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.posIdRc.HeaderText = "포스ID";
            this.posIdRc.Name = "posIdRc";
            this.posIdRc.ReadOnly = true;
            this.posIdRc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tradeIdRc
            // 
            this.tradeIdRc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradeIdRc.HeaderText = "거래ID";
            this.tradeIdRc.Name = "tradeIdRc";
            this.tradeIdRc.ReadOnly = true;
            this.tradeIdRc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tradeDateRec
            // 
            this.tradeDateRec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradeDateRec.HeaderText = "거래시간";
            this.tradeDateRec.Name = "tradeDateRec";
            this.tradeDateRec.ReadOnly = true;
            this.tradeDateRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // recoverBtn
            // 
            this.recoverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recoverBtn.Location = new System.Drawing.Point(57, 315);
            this.recoverBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoverBtn.Name = "recoverBtn";
            this.recoverBtn.Size = new System.Drawing.Size(96, 34);
            this.recoverBtn.TabIndex = 1;
            this.recoverBtn.Tag = "1";
            this.recoverBtn.Text = "복원";
            this.recoverBtn.UseVisualStyleBackColor = true;
            this.recoverBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Location = new System.Drawing.Point(211, 315);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 34);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Tag = "2";
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // FrmRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.recoverBtn);
            this.Controls.Add(this.recoverGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 404);
            this.Name = "FrmRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "복원";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.recoverForm_FormClosing);
            this.Load += new System.EventHandler(this.recoverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recoverGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recoverGrid;
        private System.Windows.Forms.Button recoverBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posIdRc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeIdRc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDateRec;
    }
}