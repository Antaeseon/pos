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
using ClassLibrary2;

namespace PosProject
{
    public partial class FrmDiscount : Form
    {
        List<singleItem> itemList = new List<singleItem>();
        List<discount> disList = new List<discount>();
        List<refTb> refList = new List<refTb>();
        dllCellInfo grid = new dllCellInfo();
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
        }

        private void discountInqForm_Load(object sender, EventArgs e)
        {
            init();
            try
            {
                var ll = from single in itemList
                         join re in refList on single.m_sItemId equals re.m_sItemId
                         join dis in disList on re.m_sDiscountId equals dis.m_sDiscountId
                         select new
                         {
                             iNumber = single.m_sItemId,
                             iName = single.m_sItemName,
                             iDisNum = dis.m_sDiscountId,
                             iPrice = single.m_nItemPrice,
                             iCategory = dis.m_nCategory,
                             iDiscnt = dis.m_nDiscount
                         };
                var joinList = ll.ToList();
                string cateString = "";
                string disString = "";
                foreach (var a in joinList)
                {
                    if (a.iCategory == discount.s_categoryPrice)
                    {
                        cateString = "cash";
                        disString = "(won)";
                    }
                    if (a.iCategory == discount.s_categoryPercent)
                    {
                        cateString = "percent";
                        disString = "%";
                    }
                    if (a.iCategory == discount.s_categoryNplus1)
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
