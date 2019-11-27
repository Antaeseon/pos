using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject
{
    public partial class FrmCancel : Form
    {
        public delegate void FormSendDataHandler(int reason);
        public event FormSendDataHandler FormSendEvent;
        public FrmCancel()
        {
            InitializeComponent();
        }

        private bool message(string ms, int index)
        {
            bool flag = true;
            var message = ms + " 취소를 하시겠습니까?";
            var title = "일괄취소";
            var result = MessageBox.Show(
                message,                  // the message to show
                title,                    // the title for the dialog box
                MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                MessageBoxIcon.Question); // show a question mark icon
            switch (result)
            {
                case DialogResult.Yes:
                    flag = true;
                    FormSendEvent(index);
                    this.Close();
                    break;
                case DialogResult.No:
                    flag = false;
                    break;
                default:
                    break;
            }
            return flag;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            switch (s)
            {
                case "제품결함":
                    message(s, tran.s_itemStatusCancel);
                    break;
                case "한도초과":
                    message(s, tran.s_itemStatusCancel);
                    break;
                case "재결제":
                    message(s, tran.s_itemStatusCancel);
                    break;
                case "단순변심":
                    message(s, tran.s_itemStatusCancel);
                    break;
                default:
                    FormSendEvent(0);
                    this.Close();
                    break;
            }
        }
    }
}
