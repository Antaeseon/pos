using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfCustomControlLibrary1;

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
                    tranGrid.Rows.Add(tranStatusString, tranList[i].m_sDate.Substring(0, 10), tranList[i].m_sPosId, tranList[i].m_sTradeId);
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
            initDatePicker.Value = DateTime.Today.AddMonths(-1);
            endDatePicker.Value = DateTime.Today;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            switch (s)
            {
                default:
                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateFilter();
            checkFilter();
        }

        private void dateFilter()
        {
            DateTime sd = initDatePicker.Value;
            DateTime ed = endDatePicker.Value;
            string startDate = sd.ToString("yyyy-MM-dd");
            string endDate = ed.ToString("yyyy-MM-dd");
            if(DateTime.Parse(startDate) > DateTime.Parse(endDate)){
                MessageBox.Show("날짜 설정을 다시 해 주세요");
                initDatePicker.Value = DateTime.Today.AddMonths(-1);
                endDatePicker.Value = DateTime.Today;
                return;
            }

            for (int i = 0; i < tranGrid.Rows.Count; i++)
            {
                if (DateTime.Parse(startDate) <= DateTime.Parse(tranGrid.Rows[i].Cells[1].Value.ToString())
                 && DateTime.Parse(endDate) >= DateTime.Parse(tranGrid.Rows[i].Cells[1].Value.ToString()))
                {
                    tranGrid.Rows[i].Visible = true;
                }
                else
                {
                    tranGrid.Rows[i].Visible = false;
                }
            }
        }

        private void checkFilter()
        {
            string[] tranGridStatus = new string[] { "보류", "결제", "취소", "복원" };
            Dictionary<string, bool> dt = new Dictionary<string, bool>();
            dt.Add("보류", false);
            dt.Add("결제", false);
            dt.Add("취소", false);
            dt.Add("복원", false);
            int[] indexes = checkedListBox1.CheckedIndices.Cast<int>().ToArray();
            for (int i = 0; i < indexes.Length; i++)
            {
                dt[tranGridStatus[indexes[i]]] = true;
            }
            for (int j = 0; j < tranGrid.Rows.Count; j++)
            {
                if (tranGrid.Rows[j].Visible == false)
                    continue;


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

        private void initDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dateFilter();
            checkFilter();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dateFilter();
            checkFilter();
        }

        private void tranGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.ToString() == "-1")
            {
                return;
            }

            int ItemIndex = tranList.FindIndex(it => 
            it.m_sTradeId == tranGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            Window1 wpfwindow = new Window1("tran", ItemIndex);
            wpfwindow.Show();
        }
    }
}
