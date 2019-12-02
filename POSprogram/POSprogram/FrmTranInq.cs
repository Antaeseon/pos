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
    public partial class FrmTranInq : Form
    {
        List<tran> tranList = new List<tran>();
        public FrmTranInq()
        {
            InitializeComponent();
        }

        private void init()
        {
            try
            {
                tranList = fileReadFunction.getTranList();
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(1, true);
                checkedListBox1.SetItemChecked(2, true);
                checkedListBox1.SetItemChecked(3, true);

                for (int i = 0; i < tranList.Count; i++)
                {
                    string tranStatusString = "";
                    if (tranList[i].m_nStatus == tran.s_tranHold)
                    {
                        tranStatusString = "보류";
                    }
                    else if (tranList[i].m_nStatus == tran.s_tranFinish)
                    {
                        tranStatusString = "결제";
                    }
                    else if (tranList[i].m_nStatus == tran.s_tranCancel)
                    {
                        tranStatusString = "취소";
                    }
                    else if (tranList[i].m_nStatus == tran.s_tranRecover
                        || tranList[i].m_nStatus == 4)
                    {
                        tranStatusString = "복원";
                    }
                    tranGrid.Rows.Add(tranStatusString, tranList[i].m_sDate, tranList[i].m_sPosId, tranList[i].m_sTradeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmTranInq_Load(object sender, EventArgs e)
        {
            init();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tranGridStatus = new string[] { "보류", "결제", "취소", "복원" };
            Dictionary<string, bool> dt = new Dictionary<string, bool>();
            dt.Add("보류", false);
            dt.Add("결제", false);
            dt.Add("취소", false);
            dt.Add("복원", false);
            int[] indexes = checkedListBox1.CheckedIndices.Cast<int>().ToArray();
            for(int i = 0; i < indexes.Length; i++)
            {
                dt[tranGridStatus[indexes[i]]] = true;
            }
            for (int j = 0; j < tranGrid.Rows.Count; j++)
            {
                if (dt[tranGrid.Rows[j].Cells[0].Value.ToString()])
                {
                    tranGrid.Rows[j].Visible = true;
                }
                else
                {
                    tranGrid.Rows[j].Visible = false;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tranGrid.Rows[0].Visible = false;
        }
    }
}
