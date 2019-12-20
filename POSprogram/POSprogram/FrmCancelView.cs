using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ClassLibrary2;
using WpfCustomControlLibrary1;

namespace PosProject
{
    public partial class FrmCancelView : Form
    {
        List<tran> tranList = new List<tran>();
        List<singleItem> itemList = new List<singleItem>();
        tran tempT;
        int index;
        public FrmCancelView()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            switch (s)
            {
                case "검색":
                    research();
                    break;
                case "확정":
                    confirm();
                    break;
                case "취소":
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        private void research()
        {
            FrmSaleCancel dlg = new FrmSaleCancel();
            dlg.FormSendEvent += new FrmSaleCancel.FormSendDataHandler(getTranIndex);
            dlg.ShowDialog();
        }
        private void confirm()
        {
            if (itemGrid.Rows.Count == 0)
            {
                MessageBox.Show("거래를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tranList[index].m_nStatus = tran.s_tranSaleCancel;
            saveTran();
            /*string textFile = @"tran.mst";
            string copyFile = @"copy.mst";
            File.Copy(textFile, copyFile, true); //복사
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"copy.mst");
            FileStream fileStream = new FileStream(
            textFile,              //저장경로
            FileMode.Create,       //파일스트림 모드
            FileAccess.Write       //접근 권한
            );
            int inIndex = 0;
            StreamWriter streamWriter = new StreamWriter(
            fileStream,            //쓸 파일스트림을 여기에다가.....
            Encoding.UTF8          //파일에다 쓸때 인코딩 객체 전달.
            );

            while ((line = file.ReadLine()) != null)
            {
                if (inIndex++ == index)
                {
                    streamWriter.WriteLine("4" + line.Substring(1));
                }
                else
                {
                    streamWriter.WriteLine(line);
                }
            }
            file.Close();
            streamWriter.Close();
            fileStream.Close();*/

            Window1 wpfwindow = new Window1("취소", Convert.ToInt32(tempT.m_sTradeId));
            ElementHost.EnableModelessKeyboardInterop(wpfwindow);
            wpfwindow.Show();
        }

        private void getTranIndex(int posId, int tradeId)
        {
            try
            {
                clear();
                index = tranList.FindIndex(it => it.m_sTradeId == tradeId.ToString());
                tempT = tranList[index];
                if (tempT.m_nStatus != tran.s_tranFinish)
                {
                    MessageBox.Show("결제 완료건이 아닙니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clear();
                    return;
                }
                Dictionary<string, int> td = new Dictionary<string, int>();
                foreach (var i in tempT.m_lItem)
                {
                    if (i.sTranItemStatus == tran.s_itemStatusCancel.ToString())
                    {
                        continue;
                    }

                    if (td.ContainsKey(i.sTranItemId))
                    {
                        td[i.sTranItemId] += i.nTranItemNum;
                    }
                    else
                    {
                        td.Add(i.sTranItemId, i.nTranItemNum);
                    }
                }
                foreach (var pair in td)
                {
                    string itemId = pair.Key;
                    int itemNum = pair.Value;
                    int ItemIndex = itemList.FindIndex(it => it.m_sItemId == itemId);
                    for (int i = 0; i < itemNum / 999; i++)
                    {
                        itemGrid.Rows.Add(itemId, itemList[ItemIndex].m_sItemName, 999,
                            itemList[ItemIndex].m_nItemPrice
                            , 999 * itemList[ItemIndex].m_nItemPrice);
                    }
                    if (itemNum % 999 > 0)
                    {
                        itemGrid.Rows.Add(itemId, itemList[ItemIndex].m_sItemName, itemNum % 999,
                        itemList[ItemIndex].m_nItemPrice
                        , (itemNum % 999) * itemList[ItemIndex].m_nItemPrice);
                    }
                }
                txtTotal.Text = dllCalcFunction.getCommaString(-1 * tempT.m_nTotalMoney);
                txtReceive.Text = dllCalcFunction.getCommaString(-1 * tempT.m_nTotalMoney);
                txtPay.Text = dllCalcFunction.getCommaString(-1 * tempT.m_nTotalMoney);
            }
            catch (Exception ex)
            {
            }
        }

        private void FrmCancelView_Load(object sender, EventArgs e)
        {
            try
            {
                tranList = fileReadFunction.getTranList();
                itemList = fileReadFunction.getSingleItemList();
                clear();
            }
            catch (Exception ex)
            {
            }
        }

        private void saveTran()
        {
            try
            {
                string filePath = @"tran.mst";
                FileStream fileStream = new FileStream(
                filePath,              //저장경로
                FileMode.Create,       //파일스트림 모드
                FileAccess.Write       //접근 권한
                );

                StreamWriter streamWriter = new StreamWriter(
                fileStream,            //쓸 파일스트림을 여기에다가.....
                Encoding.UTF8          //파일에다 쓸때 인코딩 객체 전달.
                );
                foreach (var singleTran in tranList)
                {
                    string strData = "";
                    strData += (singleTran.m_nStatus.ToString() + ",");
                    strData += (singleTran.m_sDate.ToString() + ",");
                    strData += (singleTran.m_sPosId + ",");
                    strData += (singleTran.m_sTradeId + ",");
                    for (int i = 0; i < singleTran.m_lItem.Count; i++)
                    {
                        strData += (singleTran.m_lItem[i].sTranItemId.ToString() + ",");
                        strData += (singleTran.m_lItem[i].nTranItemNum.ToString() + ",");
                        strData += (singleTran.m_lItem[i].sTranItemStatus + ",");
                    }
                    strData += (singleTran.m_nReceiveMoney.ToString() + ",");
                    strData += (singleTran.m_nDiscountMoney.ToString() + ",");
                    strData += (singleTran.m_nPriceMoney.ToString() + ",");
                    strData += (singleTran.m_nTotalMoney.ToString() + "\n");
                    streamWriter.Write(strData);
                }


                //스트림 Writer 닫아 주세요.
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtTotal.Text = "0";
            txtPay.Text = "0";
            txtReceive.Text = "0";
            itemGrid.DataSource = null;
            itemGrid.Rows.Clear();
            itemGrid.Refresh();
        }
    }
}
