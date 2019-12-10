using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfCustomControlLibrary1
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        private string message;
        private List<tran> tranList = new List<tran>();
        private List<singleItem> singleList = new List<singleItem>();
        private tran tr = new tran();
        private int tranIndex;
        public Window1(string _message, int st = -1)
        {
            InitializeComponent();
            tranIndex = st;
            message = _message;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (tranIndex == -1)
            {
                DisplayText(message);
                return;
            }
            try
            {
                tranList = fileReadFunction.getTranList();
                tr = tranList[tranIndex];
                singleList = fileReadFunction.getSingleItemList();
                DisplayText("tran");
            }
            catch (Exception ex)
            {

            }
        }
                
        private void DisplayText(string text)
        {
            if (tranIndex != -1)
            {
                string _line = "상품명".PadRight(13, ' ') + "수량".PadRight(12, ' ') + "단가".PadRight(13, ' ') + "합계".PadRight(12, ' ') + "\n";
                richTextBox.AppendText(_line);

                for (int i = 0; i < tr.m_lItem.Count; i++)
                {
                    int nextItemIndex = i * 6;

                    if(tr.m_lItem[i].sTranItemStatus== sendMessage.s_hold.ToString())
                    {
                        continue;
                    }
                    //int iNum = Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemNum]);
                    //int iPrice = Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemPrice]);
                    //int itotal = iNum * iPrice;
                    int sIndex=singleList.FindIndex(it => it.m_sItemId == tr.m_lItem[i].sTranItemId);
                    int iPrice = singleList[sIndex].m_nItemPrice;
                    int itotal = tr.m_lItem[i].nTranItemNum * iPrice;
                    _line = singleList[sIndex].m_sItemName.PadRight(14, ' ')
                        + tr.m_lItem[i].nTranItemNum.ToString().PadLeft(5, ' ') +
                        calcFunction.getCommaString(Convert.ToInt32(iPrice)).PadLeft(14, ' ') +
                        calcFunction.getCommaString(itotal).PadLeft(14, ' ') + "\n";
                    richTextBox.AppendText(_line);
                }
                richTextBox.AppendText("==================================================\n");
                if (tr.m_nStatus == tran.s_tranHold)
                {
                    _line = "거래보류상품\n\n";
                    richTextBox.AppendText(_line);
                }
                else if (tr.m_nStatus == tran.s_tranFinish)
                {
                    _line = "거래완료상품\n\n";
                    richTextBox.AppendText(_line);
                }
                else if (tr.m_nStatus == tran.s_tranCancel)
                {
                    _line = "거래취소상품\n\n";
                    richTextBox.AppendText(_line);
                }
                else if (tr.m_nStatus == tran.s_tranRecover)
                {
                    _line = "거래복원상품\n\n";
                    richTextBox.AppendText(_line);
                }
                if (tr.m_nStatus == tran.s_tranCancel)
                {
                    return;
                }
                else if (tr.m_nStatus == tran.s_tranRecover)
                {
                    return;
                }

                _line = "합계 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(tr.m_nPriceMoney).PadLeft(13, ' ') + "\n";
                richTextBox.AppendText(_line);

                _line = "할인 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(tr.m_nDiscountMoney).PadLeft(13, ' ')
                    + " 받은 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(tr.m_nReceiveMoney).PadLeft(13, ' ') + "\n";
                richTextBox.AppendText(_line);

                _line = "결제 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(tr.m_nTotalMoney).PadLeft(13, ' ')
                  + " 거스름 돈 :".PadRight(9, ' ') + calcFunction.getCommaString((tr.m_nReceiveMoney)
                  - Convert.ToInt32(tr.m_nTotalMoney)).PadLeft(13, ' ') + "\n";
                richTextBox.AppendText(_line);
                return;
            }

            try
            {
                string _line = "상품명".PadRight(13, ' ') + "수량".PadRight(12, ' ') + "단가".PadRight(13, ' ') + "합계".PadRight(12, ' ') + "\n";
                richTextBox.AppendText(_line);
                string[] result = text.Split(',');
                for (int i = 0; i < Convert.ToInt32(result[sendMessage.c_totalItemNum]); i++)
                {
                    int nextItemIndex = i * 6;
                    if (result[nextItemIndex + sendMessage.c_itemStatus] == sendMessage.s_hold.ToString())
                    {
                        continue;
                    }
                    int iNum = Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemNum]);
                    int iPrice = Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemPrice]);
                    int itotal = iNum * iPrice;
                    //formatText = String.Format("{0,5} {1,3} {2,10} {3,10}\n", result[tnum+2], result[tnum+3], result[tnum+4], itotal.ToString());
                    //richTextBox.AppendText(formatText);
                    _line = result[nextItemIndex + sendMessage.c_itemName].PadRight(14, ' ') 
                        + result[nextItemIndex + sendMessage.c_itemNum].PadLeft(5,' ') +
                        calcFunction.getCommaString(Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemPrice])).PadLeft(14,' ')+
                        calcFunction.getCommaString(itotal).PadLeft(14,' ')+"\n";
                    richTextBox.AppendText(_line);
                }
                richTextBox.AppendText("==================================================\n");
                int priceIndex = 6 * Convert.ToInt32(result[0]) + 1;
                int discountIndex = 6 * Convert.ToInt32(result[0]) + 2;
                int receiveIndex = 6 * Convert.ToInt32(result[0]) + 3;
                int totalIndex = 6 * Convert.ToInt32(result[0]) + 4;

                _line = "합계 금액 :".PadRight(9,' ') + calcFunction.getCommaString(Convert.ToInt32(result[priceIndex])).PadLeft(13,' ')+"\n";
                richTextBox.AppendText(_line);

                _line = "할인 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[discountIndex])).PadLeft(13, ' ')
                    + " 받은 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[receiveIndex])).PadLeft(13, ' ')+"\n";
                richTextBox.AppendText(_line);

                _line = "결제 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[totalIndex])).PadLeft(13, ' ')
                  + " 거스름 돈 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[receiveIndex])
                  - Convert.ToInt32(result[totalIndex])).PadLeft(13,' ')+"\n";
                richTextBox.AppendText(_line);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
