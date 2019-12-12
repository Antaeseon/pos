using System;
using System.Collections.Generic;
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
    /// Window3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window3 : Window
    {
        private string message;
        private List<tran> tranList = new List<tran>();
        private List<singleItem> singleList = new List<singleItem>();
        private tran tr = new tran();
        private int tranIndex;

        public Window3(string _message="", int st = -1)
        {

            InitializeComponent();
            tranIndex = st;
            message = _message;
            DisplayText(message);
        }

        private void DisplayText(string text)
        {
            /*TextBlock txtNumber = new TextBlock();
            txtNumber.Name = "txtNumber";
            txtNumber.Text = "1776";
            apanel.Children.Add(txtNumber);
            apanel.RegisterName(txtNumber.Name, txtNumber);*/

            // Create the Grid
            Grid DynamicGrid = new Grid();
            DynamicGrid.Width = 360;
            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Left;
            DynamicGrid.VerticalAlignment = VerticalAlignment.Top;

            // Create Columns
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();
            ColumnDefinition gridCol4 = new ColumnDefinition();

            gridCol1.Width = new GridLength(1, GridUnitType.Star);
            gridCol2.Width = new GridLength(1, GridUnitType.Star);
            gridCol3.Width = new GridLength(1, GridUnitType.Star);
            gridCol4.Width = new GridLength(1, GridUnitType.Star);

            DynamicGrid.ColumnDefinitions.Add(gridCol1);
            DynamicGrid.ColumnDefinitions.Add(gridCol2);
            DynamicGrid.ColumnDefinitions.Add(gridCol3);
            DynamicGrid.ColumnDefinitions.Add(gridCol4);

            // Create Rows
            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(20);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(20);
            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(20);
            RowDefinition gridRow4 = new RowDefinition();
            gridRow4.Height = new GridLength(20);

            DynamicGrid.RowDefinitions.Add(gridRow1);
            DynamicGrid.RowDefinitions.Add(gridRow2);
            DynamicGrid.RowDefinitions.Add(gridRow3);
            DynamicGrid.RowDefinitions.Add(gridRow4);

            // Add first column header
            TextBlock nameBlk = new TextBlock();
            nameBlk.Text = "상 품 명";
            nameBlk.FontSize = 12;
            nameBlk.FontWeight = FontWeights.Bold;
            nameBlk.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(nameBlk, 0);
            Grid.SetColumn(nameBlk, 0);
            // Add second column header
            TextBlock numBlk = new TextBlock();
            numBlk.Text = "수 량";
            numBlk.FontSize = 12;
            numBlk.FontWeight = FontWeights.Bold;
            numBlk.VerticalAlignment = VerticalAlignment.Top;
            numBlk.HorizontalAlignment = HorizontalAlignment.Right;
            Grid.SetRow(numBlk, 0);
            Grid.SetColumn(numBlk, 1);
            // Add third column header
            TextBlock priceBlk = new TextBlock();
            priceBlk.Text = "단 가";
            priceBlk.FontSize = 12;
            priceBlk.FontWeight = FontWeights.Bold;
            priceBlk.VerticalAlignment = VerticalAlignment.Top;
            priceBlk.HorizontalAlignment = HorizontalAlignment.Right;
            Grid.SetRow(priceBlk, 0);
            Grid.SetColumn(priceBlk, 2);
            // Add third column header
            TextBlock totalBlk = new TextBlock();
            totalBlk.Text = "금 액";
            totalBlk.FontSize = 12;
            totalBlk.FontWeight = FontWeights.Bold;
            totalBlk.VerticalAlignment = VerticalAlignment.Top;
            totalBlk.HorizontalAlignment = HorizontalAlignment.Right;
            Grid.SetRow(totalBlk, 0);
            Grid.SetColumn(totalBlk, 3);

            //// Add column headers to the Grid

            DynamicGrid.Children.Add(nameBlk);
            DynamicGrid.Children.Add(numBlk);
            DynamicGrid.Children.Add(priceBlk);
            DynamicGrid.Children.Add(totalBlk);



            if (tranIndex != -1)
            {
                for (int i = 0; i < tr.m_lItem.Count; i++)
                {
                    int nextItemIndex = i * 6;
                    if (tr.m_lItem[i].sTranItemStatus == sendMessage.s_hold.ToString())
                    {
                        continue;
                    }
                    //int iNum = Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemNum]);
                    //int iPrice = Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemPrice]);
                    //int itotal = iNum * iPrice;
                    int sIndex = singleList.FindIndex(it => it.m_sItemId == tr.m_lItem[i].sTranItemId);
                    int iPrice = singleList[sIndex].m_nItemPrice;
                    int itotal = tr.m_lItem[i].nTranItemNum * iPrice;
                    // Create first Row
                    TextBlock nameTxt = new TextBlock();
                    nameTxt.Text = singleList[sIndex].m_sItemName;
                    nameTxt.FontSize = 12;
                    Grid.SetRow(nameTxt, i+1);
                    Grid.SetColumn(nameTxt, 0);

                    TextBlock numTxt = new TextBlock();
                    numTxt.Text = tr.m_lItem[i].nTranItemNum.ToString();
                    numTxt.FontSize = 12;
                    numTxt.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(numTxt, i + 1);
                    Grid.SetColumn(numTxt, 1);

                    TextBlock priceTxt = new TextBlock();
                    priceTxt.Text = calcFunction.getCommaString(Convert.ToInt32(iPrice));
                    priceTxt.FontSize = 12;
                    priceTxt.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(priceTxt, i + 1);
                    Grid.SetColumn(priceTxt, 2);

                    TextBlock totalTxt = new TextBlock();
                    totalTxt.Text = calcFunction.getCommaString(itotal);
                    totalTxt.FontSize = 12;
                    totalTxt.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(totalTxt, i + 1);
                    Grid.SetColumn(totalTxt, 3);

                    // Add first row to Grid
                    DynamicGrid.Children.Add(nameTxt);
                    DynamicGrid.Children.Add(numTxt);
                    DynamicGrid.Children.Add(priceTxt);
                    DynamicGrid.Children.Add(totalTxt);
                }

                /*richTextBox.AppendText("==================================================\n");
                if (tr.m_nStatus == tran.s_tranHold)
                {
                    _line = "거래보류상품\n\n";
                    richTextBox.AppendText(_line);
                    return;
                }
                else if (tr.m_nStatus == tran.s_tranFinish)
                {
                    _line = "거래완료상품\n\n";
                    richTextBox.AppendText(_line);
                }
                else if (tr.m_nStatus == tran.s_tranCancel)
                {
                    _line = "거래취소상품\n";
                    string cancelReason = "";
                    richTextBox.AppendText(_line);
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
                    _line = "취소 사유 : " + cancelReason;
                    richTextBox.AppendText(_line);
                    return;
                }
                else if (tr.m_nStatus == tran.s_tranRecover)
                {
                    _line = "거래복원상품\n\n";
                    richTextBox.AppendText(_line);
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
                richTextBox.AppendText(_line);*/
                sangPanel.Children.Add(DynamicGrid);

                return;
            }

            try
            {
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
                    //int sIndex = singleList.FindIndex(it => it.m_sItemId == tr.m_lItem[i].sTranItemId);

                    TextBlock nameTxt = new TextBlock();
                    nameTxt.Text = result[nextItemIndex + sendMessage.c_itemName];
                    nameTxt.FontSize = 12;
                    Grid.SetRow(nameTxt, i + 1);
                    Grid.SetColumn(nameTxt, 0);

                    TextBlock numTxt = new TextBlock();
                    numTxt.Text = result[nextItemIndex + sendMessage.c_itemNum];
                    numTxt.FontSize = 12;
                    numTxt.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(numTxt, i + 1);
                    Grid.SetColumn(numTxt, 1);

                    TextBlock priceTxt = new TextBlock();
                    priceTxt.Text = calcFunction.getCommaString(Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemPrice]));
                    priceTxt.FontSize = 12;
                    priceTxt.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(priceTxt, i + 1);
                    Grid.SetColumn(priceTxt, 2);

                    TextBlock totalTxt = new TextBlock();
                    totalTxt.Text = calcFunction.getCommaString(itotal);
                    totalTxt.FontSize = 12;
                    totalTxt.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetRow(totalTxt, i + 1);
                    Grid.SetColumn(totalTxt, 3);

                    // Add first row to Grid
                    DynamicGrid.Children.Add(nameTxt);
                    DynamicGrid.Children.Add(numTxt);
                    DynamicGrid.Children.Add(priceTxt);
                    DynamicGrid.Children.Add(totalTxt);
                }
                /*richTextBox.AppendText("==================================================\n");
                int priceIndex = 6 * Convert.ToInt32(result[0]) + 1;
                int discountIndex = 6 * Convert.ToInt32(result[0]) + 2;
                int receiveIndex = 6 * Convert.ToInt32(result[0]) + 3;
                int totalIndex = 6 * Convert.ToInt32(result[0]) + 4;

                _line = "합계 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[priceIndex])).PadLeft(13, ' ') + "\n";
                richTextBox.AppendText(_line);

                _line = "할인 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[discountIndex])).PadLeft(13, ' ')
                    + " 받은 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[receiveIndex])).PadLeft(13, ' ') + "\n";
                richTextBox.AppendText(_line);

                _line = "결제 금액 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[totalIndex])).PadLeft(13, ' ')
                  + " 거스름 돈 :".PadRight(9, ' ') + calcFunction.getCommaString(Convert.ToInt32(result[receiveIndex])
                  - Convert.ToInt32(result[totalIndex])).PadLeft(13, ' ') + "\n";
                richTextBox.AppendText(_line);*/
                sangPanel.Children.Add(DynamicGrid);

            }
            catch (Exception ex)
            {
            }
        }
        }
}
