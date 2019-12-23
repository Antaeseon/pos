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
    public partial class FrmSaleCancel : Form
    {
        public delegate void FormSendDataHandler(int pIndex,int tIndex);
        public event FormSendDataHandler FormSendEvent;
        List<tran> tranList = new List<tran>();

        public FrmSaleCancel()
        {
            InitializeComponent();
        }

        private void FrmSaleCancel_Load(object sender, EventArgs e)
        {
            try
            {
                tranList = fileReadFunction.getTranList();
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
            catch (Exception ex)
            {

            }
        }




        private void but_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            switch (s)
            {
                case "입력완료":
                    complete();
                    break;
                case "취소":
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void complete()
        {
            int PosIndex = tranList.FindIndex(it => it.m_sPosId.ToString() == txtPosId.Text
            && it.m_sDate.Substring(0, 10) == dateTimePicker1.Value.ToString().Substring(0, 10)
            &&it.m_sTradeId==txtTradeId.Text);
            //MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            if (PosIndex == -1)
            {
                MessageBox.Show("해당 거래가 존재하지 않습니다.");
                return;
            }
            FormSendEvent(PosIndex, PosIndex);
            this.Close();

        }
    }
}
