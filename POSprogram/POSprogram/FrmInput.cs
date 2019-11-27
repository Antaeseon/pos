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
    public partial class FrmInput : Form
    {
        public FrmInput(string _text,string _title)
        {
            InitializeComponent();
            this.label1.Text = _text;
            this.Text = _title;
        }

       public String Result { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                if (txtInput.Text == "")
                {
                    MessageBox.Show("금액을 입력해주세요");
                    this.ActiveControl = txtInput;
                    txtInput.SelectAll();
                    return;
                }
                if (Convert.ToInt32(txtInput.Text) <= 0)
                {
                    MessageBox.Show("10 이상의 값을 입력해주세요");
                    this.ActiveControl = txtInput;
                    txtInput.Text = "";
                    return;
                }
                if (Convert.ToInt32(txtInput.Text) % 10 != 0)
                {
                    MessageBox.Show("1원 단위는 입력할 수 없습니다.");
                    this.ActiveControl = txtInput;
                    txtInput.Text = "";
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Result = this.txtInput.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("입력이 올바르지 않습니다.");
                txtInput.Text = "";
                this.ActiveControl = txtInput;
                return;

            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (txtInput.Text == "")
            {
                return;
            }
            bool flag = int.TryParse(txtInput.Text, out i);
            if (!flag)
            {
                MessageBox.Show("잘못된 입력입니다.");
                txtInput.Text = "";
            }
        }
    }
}
