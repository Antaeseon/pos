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
        public Window1(string _message)
        {
            InitializeComponent();
            message = _message;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayText(message);
        }

        private void DisplayText(string text)
        {
            try
            {
                string _line = "상품명".PadRight(13, ' ') + "수량".PadRight(10, ' ') + "단가".PadRight(9, ' ') + "합계".PadRight(9, ' ') + "\n";
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
                        result[nextItemIndex + sendMessage.c_itemPrice].PadLeft(11,' ')+
                        itotal.ToString().PadLeft(11,' ')+"\n";
                    richTextBox.AppendText(_line);
                }
                richTextBox.AppendText("===============================================\n");

                int priceIndex = 6 * Convert.ToInt32(result[0]) + 1;
                int discountIndex = 6 * Convert.ToInt32(result[0]) + 2;
                int receiveIndex = 6 * Convert.ToInt32(result[0]) + 3;
                int totalIndex = 6 * Convert.ToInt32(result[0]) + 4;
                _line = "합계 금액 : ".PadRight(8,' ')+ result[priceIndex].PadLeft(12,' ')+"\n";
                richTextBox.AppendText(_line);

                _line = "할인 금액 : ".PadRight(8, ' ') + result[discountIndex].PadLeft(12, ' ')
                    + "  받은 금액 : ".PadRight(8, ' ') + result[receiveIndex].PadLeft(10, ' ')+"\n";
                richTextBox.AppendText(_line);

                _line = "결제 금액 : ".PadRight(8, ' ') + result[totalIndex].PadLeft(12, ' ')
                  + "  거스름 돈 : ".PadRight(8, ' ') + (Convert.ToInt32(result[receiveIndex])
                  - Convert.ToInt32(result[totalIndex])).ToString().PadLeft(10,' ')+"\n";
                richTextBox.AppendText(_line);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
