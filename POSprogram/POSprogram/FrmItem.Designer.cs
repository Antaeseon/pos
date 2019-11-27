namespace PosProject
{
    partial class FrmItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItem));
            this.label1 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNum = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemIdBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품번호";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(119, 158);
            this.enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 31);
            this.enter.TabIndex = 2;
            this.enter.Text = "상품등록";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "수량";
            // 
            // itemNum
            // 
            this.itemNum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemNum.Location = new System.Drawing.Point(106, 104);
            this.itemNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemNum.MaxLength = 3;
            this.itemNum.Name = "itemNum";
            this.itemNum.Size = new System.Drawing.Size(134, 25);
            this.itemNum.TabIndex = 2;
            this.itemNum.TextChanged += new System.EventHandler(this.itemNum_TextChanged);
            this.itemNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemNum_KeyPress);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.itemName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemName.Location = new System.Drawing.Point(106, 72);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(71, 17);
            this.itemName.TabIndex = 5;
            this.itemName.Text = "itemName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "상품이름";
            // 
            // itemIdBox
            // 
            this.itemIdBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemIdBox.FormattingEnabled = true;
            this.itemIdBox.Location = new System.Drawing.Point(106, 35);
            this.itemIdBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemIdBox.MaxLength = 10;
            this.itemIdBox.Name = "itemIdBox";
            this.itemIdBox.Size = new System.Drawing.Size(134, 23);
            this.itemIdBox.TabIndex = 1;
            this.itemIdBox.TextChanged += new System.EventHandler(this.itemIdBox_TextChanged);
            // 
            // itemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(275, 209);
            this.Controls.Add(this.itemIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 256);
            this.MinimumSize = new System.Drawing.Size(293, 256);
            this.Name = "itemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품";
            this.Load += new System.EventHandler(this.itemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNum;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemIdBox;
    }
}