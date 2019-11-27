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
    public partial class FrmRecover : Form
    {
        public delegate void FormSendDataHandler(string tradeId);
        public event FormSendDataHandler FormSendEvent;

        List<tran> tranList = new List<tran>();
        string line;
        public FrmRecover()
        {
            InitializeComponent();
        }

        private void recoverForm_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader file4 =
                    new System.IO.StreamReader(@"tran.mst");

                while ((line = file4.ReadLine()) != null)
                {
                    List<sItem> s = new List<sItem>();
                    sItem tempS;
                    char sep = ',';
                    string[] result = line.Split(sep);
                    for (int i = 4; i < result.Length - 2; i++)
                    {
                        tempS.sTranItemId = result[i++];
                        tempS.nTranItemNum = Convert.ToInt32(result[i++]);
                        tempS.sTranItemStatus = result[i];
                        s.Add(tempS);
                    }
                    tranList.Add(new tran()
                    {
                        m_nStatus = Convert.ToInt32(result[0]),
                        m_sDate = result[1],
                        m_sPosId = result[2],
                        m_sTradeId = result[3],
                        m_lItem = s,
                        m_nReceiveMoney = Convert.ToInt32(result[result.Length - 2]),
                        m_nTotalMoney = Convert.ToInt32(result[result.Length - 1])
                    });
                }
                file4.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            for(int i = 0; i < tranList.Count; i++)
            {
                if (tranList[i].m_nStatus == 0)
                {
                    recoverGrid.Rows.Add(tranList[i].m_sPosId,tranList[i].m_sTradeId, tranList[i].m_sDate);
                }
            }

            if (recoverGrid.RowCount == 0)
            {
                MessageBox.Show("보류 내역이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            switch (s)
            {
                case "복원":
                    recover();
                    break;
                case "취소":
                    this.Close();
                    break;
            }

        }
        private void recover()
        {
            try
            {
                string ser = recoverGrid.Rows[recoverGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
                var message = "상품을 복원하시겠습니까?";
                var title = "상품 복원";
                var result = MessageBox.Show(
                    message,                  // the message to show
                    title,                    // the title for the dialog box
                    MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                    MessageBoxIcon.Question); // show a question mark icon
                switch (result)
                {
                    case DialogResult.Yes:
                        FormSendEvent(ser);
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void recoverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }
    }
}
