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
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultPosIndex = tranList.FindIndex(it => it.m_sPosId.ToString() == txtPosId.Text);
            if (resultPosIndex == -1)
            {
                MessageBox.Show("해당 posId가 존재하지 않습니다.");
                return;
            }
            int resultTradeIndex = tranList.FindIndex(it => it.m_sTradeId == txtTradeId.Text);
            if (resultTradeIndex == -1)
            {
                MessageBox.Show("해당 TradeId가 존재하지 않습니다.");
                return;
            }
            FormSendEvent(resultPosIndex,resultTradeIndex);
            this.Close();
        }
    }
}
