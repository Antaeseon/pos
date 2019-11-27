namespace PosProject
{
    partial class FrmCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCancel));
            this.res1Btn = new System.Windows.Forms.Button();
            this.res2Btn = new System.Windows.Forms.Button();
            this.res3Btn = new System.Windows.Forms.Button();
            this.res4Btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // res1Btn
            // 
            this.res1Btn.Location = new System.Drawing.Point(48, 21);
            this.res1Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.res1Btn.Name = "res1Btn";
            this.res1Btn.Size = new System.Drawing.Size(203, 41);
            this.res1Btn.TabIndex = 0;
            this.res1Btn.Text = "제품결함";
            this.res1Btn.UseVisualStyleBackColor = true;
            this.res1Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // res2Btn
            // 
            this.res2Btn.Location = new System.Drawing.Point(48, 79);
            this.res2Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.res2Btn.Name = "res2Btn";
            this.res2Btn.Size = new System.Drawing.Size(203, 41);
            this.res2Btn.TabIndex = 1;
            this.res2Btn.Text = "한도초과";
            this.res2Btn.UseVisualStyleBackColor = true;
            this.res2Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // res3Btn
            // 
            this.res3Btn.Location = new System.Drawing.Point(48, 136);
            this.res3Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.res3Btn.Name = "res3Btn";
            this.res3Btn.Size = new System.Drawing.Size(203, 41);
            this.res3Btn.TabIndex = 2;
            this.res3Btn.Text = "재결제";
            this.res3Btn.UseVisualStyleBackColor = true;
            this.res3Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // res4Btn
            // 
            this.res4Btn.Location = new System.Drawing.Point(48, 192);
            this.res4Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.res4Btn.Name = "res4Btn";
            this.res4Btn.Size = new System.Drawing.Size(203, 41);
            this.res4Btn.TabIndex = 3;
            this.res4Btn.Text = "단순변심";
            this.res4Btn.UseVisualStyleBackColor = true;
            this.res4Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 282);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "취소";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // FrmCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(318, 356);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.res4Btn);
            this.Controls.Add(this.res3Btn);
            this.Controls.Add(this.res2Btn);
            this.Controls.Add(this.res1Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(333, 393);
            this.Name = "FrmCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "일괄취소";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button res1Btn;
        private System.Windows.Forms.Button res2Btn;
        private System.Windows.Forms.Button res3Btn;
        private System.Windows.Forms.Button res4Btn;
        private System.Windows.Forms.Button button5;
    }
}