using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject
{
    public partial class FrmReceipt : Form
    {
        Main main = null;
        int totalMoney;
        int recMoney;

        public FrmReceipt(Main _main,int _recMoney,int _totalMoney)
        {
            InitializeComponent();
            main = _main;
            recMoney = _recMoney;
            totalMoney = _totalMoney;
        }
        public static void work()
        {

        }

        private void init()
        {
            try
            {
                StringBuilder text = new StringBuilder(richTextBox1.Text);
                text.AppendFormat("\t\t[영수증]\n\n");
                text.AppendFormat("{0}[매장명]I&C 성수", Environment.NewLine);
                text.AppendFormat("{0}[사업자]I&C 성수", Environment.NewLine);
                text.AppendFormat("{0}[대표자]I&C 성수", Environment.NewLine);
                text.AppendFormat("{0}=======================================", Environment.NewLine);
                text.AppendFormat("{0}상품명\t 수량\t 단가\t 합계\n", Environment.NewLine);
                for (int rows = 0; rows < main.itemGrid.RowCount; rows++)
                {
                    if (main.itemGrid.Rows[rows].Cells[5].Value.ToString() == "1")
                        continue;
                    text.AppendFormat("{0,-15}{1,-10}{2,-10}{3,-10}\n", main.itemGrid.Rows[rows].Cells[1].Value.ToString(), main.itemGrid.Rows[rows].Cells[2].Value.ToString(),
                        main.itemGrid.Rows[rows].Cells[3].Value.ToString(), main.itemGrid.Rows[rows].Cells[4].Value.ToString());
                }
                text.AppendFormat("=======================================\n\n");
                text.AppendFormat("합계금액 : {0}\n", main.priceLbl.Text);
                text.AppendFormat("할인금액 : {0} \t\t받은금액 : {1}\n", main.discountLbl.Text, recMoney.ToString());
                text.AppendFormat("결제금액 : {0} \t\t거스름돈 : {1}\n", totalMoney.ToString(), (recMoney - totalMoney));
                richTextBox1.Text = text.ToString();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
