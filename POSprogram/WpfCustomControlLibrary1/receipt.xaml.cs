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
            /*DataTable dataTable = new DataTable();
            // 컬럼 생성
            dataTable.Columns.Add("ITEM_NAME", typeof(string));
            dataTable.Columns.Add("ITEM_NUM", typeof(string));
            dataTable.Columns.Add("ITEM_PRICE", typeof(string));
            dataTable.Columns.Add("ITEM_TOTAL", typeof(string));

            dataTable.Rows.Add(new string[] { "ID-01", "Name 01", "010-0001-0000" });
            dataTable.Rows.Add(new string[] { "ID-02", "Name 02", "010-0002-0000" });
            dataTable.Rows.Add(new string[] { "ID-03", "Name 03", "010-0003-0000" });
            dataTable.Rows.Add(new string[] { "ID-04", "Name 04", "010-0004-0000" });

            // DataTable의 Default View를 바인딩하기
            dataGrid.ItemsSource = dataTable.DefaultView;*/

            DisplayText(message);
        }

        private void DisplayText(string text)
        {
            try
            {
                DataTable dataTable = new DataTable();
                // 컬럼 생성
                /*dataTable.Columns.Add("ITEM_NAME", typeof(string));
                dataTable.Columns.Add("ITEM_NUM", typeof(string));
                dataTable.Columns.Add("ITEM_PRICE", typeof(string));
                dataTable.Columns.Add("ITEM_TOTAL", typeof(string));*/
                //연결된 클라이언트가 보낸 데이터 수신
                string _line = "상품명".PadRight(10, ' ') + "수량".PadRight(9, ' ') + "단가".PadRight(9, ' ') + "합계".PadRight(9, ' ') + "\n";
                richTextBox.AppendText(_line);
                string[] result = text.Split(',');
                for (int i = 0; i < Convert.ToInt32(result[0]); i++)
                {
                    int tnum = i * 6;
                    if (result[tnum + 6] == "1")
                    {
                        continue;
                    }
                    int iNum = Convert.ToInt32(result[tnum + 3]);
                    int iPrice = Convert.ToInt32(result[tnum + 4]);
                    int itotal = iNum * iPrice;
                    //formatText = String.Format("{0,5} {1,3} {2,10} {3,10}\n", result[tnum+2], result[tnum+3], result[tnum+4], itotal.ToString());
                    //richTextBox.AppendText(formatText);
                    _line = result[tnum + 2].PadRight(10, ' ') + result[tnum + 3].PadLeft(5,' ') + result[tnum + 4].PadLeft(11,' ')+
                        itotal.ToString().PadLeft(11,' ')+"\n";
                    richTextBox.AppendText(_line);
                }
                richTextBox.AppendText("===============================================\n");

                _line = "합계 금액 : ".PadRight(8,' ')+ result[6 * Convert.ToInt32(result[0]) + 1].PadLeft(12,' ')+"\n";
                richTextBox.AppendText(_line);

                _line = "할인 금액 : ".PadRight(8, ' ') + result[6 * Convert.ToInt32(result[0]) + 2].PadLeft(12, ' ')
                    + "  받은 금액 : ".PadRight(8, ' ') + result[6 * Convert.ToInt32(result[0]) + 3].PadLeft(10, ' ')+"\n";
                richTextBox.AppendText(_line);

                _line = "결제 금액 : ".PadRight(8, ' ') + result[6 * Convert.ToInt32(result[0]) + 4].PadLeft(12, ' ')
                  + "  거스름 돈 : ".PadRight(8, ' ') + (Convert.ToInt32(result[6 * Convert.ToInt32(result[0]) + 3])
                  - Convert.ToInt32(result[6 * Convert.ToInt32(result[0]) + 4])).ToString().PadLeft(10,' ')+"\n";
                richTextBox.AppendText(_line);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
