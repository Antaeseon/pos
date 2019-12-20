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
        private int saleCancel = 1;
        receiptString rs = new receiptString();
        public Window1(string _message, int st = -1)
        {
            InitializeComponent();
            tranIndex = st;
            message = _message;
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private void initTextLoad()
        {
            try
            {
                richTextBox.BorderThickness = new Thickness(0);
                referTxt.Text = rs.m_referText;
                comName.Text = rs.m_companyName;
                comTel.Text = rs.m_companyTel;
                comCeo.Text = rs.m_companyCeo;
                comAddress.Text = rs.m_companyAddress;
            }
            catch (Exception ex)
            {
            }
        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                initTextLoad();
                tranList = fileReadFunction.getTranList();
                tr = tranList[tranIndex];
                singleList = fileReadFunction.getSingleItemList();
                DisplayText(message);
            }
            catch (Exception ex)
            {
            }
        }
        private void DisplayText(string text)
        {
            /*TextBlock txtNumber = new TextBlock();
            txtNumber.Name = "txtNumber";
            txtNumber.Text = "1776";
            apanel.Children.Add(txtNumber);
            apanel.RegisterName(txtNumber.Name, txtNumber);*/
            try
            {
                bool flag = false;
                saleCancel = 1;
                string cancelReason = "";
                if (tranIndex != -1)
                {
                    richTextBox.AppendText(rs.m_divideLine);
                    string _line = "상품명".PadRight(13, ' ') + "수량".PadRight(12, ' ') + "단가".PadRight(13, ' ') + "금액".PadRight(12, ' ') + "\n";
                    richTextBox.AppendText(_line);
                    richTextBox.AppendText(rs.m_divideLine);
                    if (tr.m_nStatus == tran.s_tranHold)
                    {
                        _line = "[보 류]";
                        flag = true;
                    }
                    else if (tr.m_nStatus == tran.s_tranFinish)
                    {
                        _line = "[구 매]";
                    }
                    else if (tr.m_nStatus == tran.s_tranCancel)
                    {
                        _line = "[취 소]";
                        flag = true;
                        cancelReason = "";
                        if (tr.m_nReceiveMoney == 1)
                        {
                            cancelReason = "제품결함";
                        }
                        else if (tr.m_nReceiveMoney == 2)
                        {
                            cancelReason = "한도초과";
                        }
                        else if (tr.m_nReceiveMoney == 3)
                        {
                            cancelReason = "재결제";
                        }
                        else if (tr.m_nReceiveMoney == 4)
                        {
                            cancelReason = "단순변심";
                        }
                    }
                    else if (tr.m_nStatus == tran.s_tranRecover)
                    {
                        _line = "[복 원]";
                        flag = true;
                    }
                    else if (tr.m_nStatus == tran.s_tranSaleCancel)
                    {
                        _line = "[반 품]";
                        saleCancel = -1;
                    }

                    timeBlk.Text = _line + " " + tr.m_sDate;

                    posBlk.Text = "POS: " + tr.m_sPosId + "-" + tr.m_sTradeId;
                    for (int i = 0; i < tr.m_lItem.Count; i++)
                    {
                        int nextItemIndex = i * 6;
                        if (tr.m_lItem[i].sTranItemStatus == sendMessage.s_hold.ToString())
                        {
                            continue;
                        }
                        //int itotal = iNum * iPrice;
                        int sIndex = singleList.FindIndex(it => it.m_sItemId == tr.m_lItem[i].sTranItemId);
                        int iPrice = singleList[sIndex].m_nItemPrice;
                        int itotal = saleCancel * tr.m_lItem[i].nTranItemNum * iPrice;
                        _line = singleList[sIndex].m_sItemName.PadRight(14, ' ')
                            + (saleCancel * tr.m_lItem[i].nTranItemNum).ToString().PadLeft(5, ' ') +
                            calcFunction.getCommaString(Convert.ToInt32(iPrice)).PadLeft(14, ' ') +
                            calcFunction.getCommaString(itotal).PadLeft(14, ' ') + "\n";
                        richTextBox.AppendText(_line);
                    }
                    richTextBox.AppendText(rs.m_divideLine);
                    if (tr.m_nStatus == tran.s_tranCancel)
                    {
                        _line = "취소 사유 : " + cancelReason;
                        richTextBox.AppendText(_line);
                        return;
                    }
                    if (flag)
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
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void RichTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }
    }
}
