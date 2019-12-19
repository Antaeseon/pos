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
    public partial class FrmCancelView : Form
    {
        List<tran> tranList = new List<tran>();
        public FrmCancelView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSaleCancel dlg = new FrmSaleCancel();
            dlg.FormSendEvent += new FrmSaleCancel.FormSendDataHandler(getTranIndex);
            dlg.ShowDialog();
        }
        private void getTranIndex(int posIndex,int tradeIndex)
        {
            try
            {
                tran t = new tran();
                t = tranList[tradeIndex];

                for(int i = 0; i < t.m_lItem.Count; i++)
                {
                    
                }
            }
            catch(Exception ex)
            {
            }
        }



        private void FrmCancelView_Load(object sender, EventArgs e)
        {
            try
            {
                tranList = fileReadFunction.getTranList();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
