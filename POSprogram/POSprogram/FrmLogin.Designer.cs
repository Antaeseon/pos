namespace PosProject
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminIdTxt = new System.Windows.Forms.TextBox();
            this.adminPwdTxt = new System.Windows.Forms.TextBox();
            this.amdinClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminAuth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "관리자 암호";
            // 
            // adminIdTxt
            // 
            this.adminIdTxt.Location = new System.Drawing.Point(209, 61);
            this.adminIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminIdTxt.MaxLength = 15;
            this.adminIdTxt.Name = "adminIdTxt";
            this.adminIdTxt.Size = new System.Drawing.Size(254, 25);
            this.adminIdTxt.TabIndex = 2;
            // 
            // adminPwdTxt
            // 
            this.adminPwdTxt.Location = new System.Drawing.Point(209, 140);
            this.adminPwdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminPwdTxt.MaxLength = 15;
            this.adminPwdTxt.Name = "adminPwdTxt";
            this.adminPwdTxt.PasswordChar = '*';
            this.adminPwdTxt.Size = new System.Drawing.Size(254, 25);
            this.adminPwdTxt.TabIndex = 3;
            // 
            // amdinClose
            // 
            this.amdinClose.Location = new System.Drawing.Point(370, 186);
            this.amdinClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amdinClose.Name = "amdinClose";
            this.amdinClose.Size = new System.Drawing.Size(95, 29);
            this.amdinClose.TabIndex = 5;
            this.amdinClose.Text = "취소";
            this.amdinClose.UseVisualStyleBackColor = true;
            this.amdinClose.Click += new System.EventHandler(this.Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // adminAuth
            // 
            this.adminAuth.Location = new System.Drawing.Point(255, 186);
            this.adminAuth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminAuth.Name = "adminAuth";
            this.adminAuth.Size = new System.Drawing.Size(95, 29);
            this.adminAuth.TabIndex = 7;
            this.adminAuth.Text = "확인";
            this.adminAuth.UseVisualStyleBackColor = true;
            this.adminAuth.Click += new System.EventHandler(this.Btn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(497, 244);
            this.Controls.Add(this.adminAuth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amdinClose);
            this.Controls.Add(this.adminPwdTxt);
            this.Controls.Add(this.adminIdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(513, 279);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminIdTxt;
        private System.Windows.Forms.TextBox adminPwdTxt;
        private System.Windows.Forms.Button amdinClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adminAuth;
    }
}