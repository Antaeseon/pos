using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PosProject
{
    public partial class FrmLogin : Form
    {
        public delegate void FormSendDataHandler(bool flag);
        public event FormSendDataHandler FormSendEvent;
        private string adminId;
        private string adminPwd;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            posInfo p = new posInfo();
            adminId = p.m_sAdminId;
            adminPwd = p.m_sAdminPwd;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            switch (s)
            {
                case "확인":
                    check();
                    break;
                case "취소":
                    this.Close();
                    break;
                default :
                    break;
            }
        }


        private void check()
        {
            try
            {
                if (String.IsNullOrEmpty(adminIdTxt.Text))
                {
                    MessageBox.Show("아이디를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    adminIdTxt.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(adminPwdTxt.Text))
                {
                    MessageBox.Show("비밀번호를 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    adminPwdTxt.Focus();
                    return;
                }
                if (adminIdTxt.Text.Equals(adminId) && adminPwdTxt.Text.Equals(adminPwd))
                {
                    FormSendEvent(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("아이디와 패스워드가 틀렸습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adminIdTxt.Text = "";
                    adminPwdTxt.Text = "";
                    adminIdTxt.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
