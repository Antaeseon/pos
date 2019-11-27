using System;
using System.Collections;
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
    public partial class FrmDiscount : Form
    {
        List<singleItem> itemList = new List<singleItem>();
        List<discount> disList = new List<discount>();
        List<refTb> refList = new List<refTb>();
        string line;
        string path;
        public FrmDiscount(string _path)
        {
            InitializeComponent();
            path = _path;
        }
        private void init()
        {
            try
            {
                this.ActiveControl = idTxt;
                itemList = fileReadFunction.getSingleItemList();
                disList = fileReadFunction.getDiscountList(path);
                refList = fileReadFunction.GetRefTb();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }

            /*try
            {
                this.ActiveControl = idTxt;
                Hashtable hashtable = new Hashtable();
                file =
                    new System.IO.StreamReader(@"item.mst");
                while ((line = file.ReadLine()) != null)
                {
                    char sep = ',';
                    string[] result = line.Split(sep);
                    if (result[1] == "1" || result[1] == "2" || result[1] == "3")
                    {
                        throw new Exception("파일 형식이 잘못되었습니다.");
                    }

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == "")
                        {
                            throw new Exception("item 마스터 파일 문자열에 공백이 있습니다.");
                        }
                    }

                    if (result.Length != 3)
                    {
                        throw new Exception("상품 마스터 파일 문자열이 잘못되었습니다.");
                    }

                    if (Convert.ToInt32(result[2]) <= 0)
                    {
                        throw new Exception("상품의 가격이 0원 이하입니다.");
                    }
                    if (hashtable.ContainsKey(result[0]))
                    {
                        throw new Exception(result[0] + " 상품의 키가 중복됩니다.");
                    }
                    hashtable.Add(result[0], true);
                    itemList.Add(new singleItem()
                    {
                        sItemId = result[0],
                        nItemName = result[1],
                        nItemPrice = Convert.ToInt32(result[2])
                    });
                }
                if (itemList.Count == 0)
                {
                    throw new Exception("아이템 mst가 비어있습니다.");
                }
                file.Close();
            }
            catch (ArgumentException nx)
            {
                MessageBox.Show(nx.Message);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                file.Close();
                return;
            }

            try
            {
                file2 =
                    new System.IO.StreamReader(path);

                while ((line = file2.ReadLine()) != null)
                {
                    char sep = ',';
                    string[] result = line.Split(sep);
                    if (result.Length != 3)
                    {
                        throw new Exception("dis 마스터 파일 세미콜론 문제");
                    }

                    disList.Add(new discount()
                    {
                        sDiscountId = result[0],
                        nCategory = Convert.ToInt32(result[1]),

                        nDiscount = Convert.ToInt32(result[2])
                    });
                }
                if (disList.Count == 0)
                {
                    throw new Exception("행사 mst가 비어있습니다.");
                }
                file2.Close();
            }
            catch (ArgumentException nx)
            {
                MessageBox.Show(nx.Message);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                file2.Close();
                return;
            }
            
            try
            {
                file3 =
                    new System.IO.StreamReader(@"ref.mst");

                while ((line = file3.ReadLine()) != null)
                {
                    char sep = ',';
                    string[] result = line.Split(sep);
                    if (result.Length != 2)
                    {
                        throw new Exception("ref 마스터 파일 세미콜론 문제");
                    }

                    refList.Add(new refTb()
                    {
                        sItemId = result[0],
                        sDiscountId = result[1]
                    });
                }
                file3.Close();
            }
            catch (ArgumentException nx)
            {
                MessageBox.Show(nx.Message);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                file3.Close();
                return;
            }*/
        }

        private void discountInqForm_Load(object sender, EventArgs e)
        {
            init();
            try
            {
                var ll = from single in itemList
                         join re in refList on single.m_sItemId equals re.m_sItemId
                         join dis in disList on re.m_sDiscountId equals dis.sDiscountId
                         select new
                         {
                             iNumber = single.m_sItemId,
                             iName = single.m_sItemName,
                             iDisNum = dis.sDiscountId,
                             iPrice = single.m_nItemPrice,
                             iCategory = dis.nCategory,
                             iDiscnt = dis.nDiscount
                         };
                var joinList = ll.ToList();
                string cateString = "";
                string disString = "";
                foreach (var a in joinList)
                {
                    if (a.iCategory == 1)
                    {
                        cateString = "cash";
                        disString = "(won)";
                    }
                    if (a.iCategory == 2)
                    {
                        cateString = "percent";
                        disString = "%";
                    }
                    if (a.iCategory == 3)
                    {
                        cateString = "plus";
                        disString = "";
                    }
                    discountGrid.Rows.Add(a.iDisNum, a.iNumber, a.iName, cateString, a.iDiscnt + disString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = -1;
                for (int i = 0; i < discountGrid.Rows.Count; i++)
                {
                    if (idTxt.Text == discountGrid.Rows[i].Cells[0].Value.ToString())
                    {
                        index = i;
                        break;
                    }
                }
                if (idTxt.Text == "")
                {
                    MessageBox.Show("행사ID를 입력해주세요.");
                    return;
                }
                if (index == -1)
                {
                    MessageBox.Show("행사ID가 존재하지 않습니다.");
                    discountGrid.Rows[0].Selected = true;
                    discountGrid.FirstDisplayedCell = discountGrid.Rows[0].Cells[0];
                    return;
                }
                discountGrid.Rows[index].Selected = true;
                discountGrid.FirstDisplayedCell = discountGrid.Rows[index].Cells[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
