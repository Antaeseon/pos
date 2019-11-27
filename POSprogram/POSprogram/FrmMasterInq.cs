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
    public partial class FrmMasterInq : Form
    {
        private string path;
        private string line;
        List<singleItem> itemList = new List<singleItem>();
        private bool flag = false;
        System.IO.StreamReader file;
        public FrmMasterInq(string _path)
        {
            InitializeComponent();
            path = _path;
        }
        private void init()
        {
            try
            {
                this.ActiveControl = itemIdTxt;
                itemList = fileReadFunction.getSingleItemList(path);
                for(int i = 0; i < itemList.Count; i++)
                {
                    itemGrid.Rows.Add(itemList[i].m_sItemId, itemList[i].m_sItemName, itemList[i].m_nItemPrice);
                }
                /*Hashtable hashtable = new Hashtable();
                file =
                    new System.IO.StreamReader(path);
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
                    itemGrid.Rows.Add(result[0], result[1], result[2]);
                    itemList.Add(new singleItem() { sItemId = result[0], nItemName = result[1],
                        nItemPrice = Convert.ToInt32(result[2]) });
                }
                if (itemList.Count == 0)
                {
                    throw new Exception("아이템 mst가 비어있습니다.");
                }
                file.Close();*/
            }
            catch(ArgumentException nx)
            {
                MessageBox.Show(nx.Message);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                //file.Close();
                return;
            }
        }

        private void masterInqForm_Load(object sender, EventArgs e)
        {
            init();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = -1;
                for (int i = 0; i < itemGrid.Rows.Count; i++)
                {
                    if (itemIdTxt.Text == itemGrid.Rows[i].Cells[0].Value.ToString())
                    {
                        index = i;
                        break;
                    }
                }

                if (itemIdTxt.Text == "")
                {
                    MessageBox.Show("상품ID를 입력해주세요.");
                    this.ActiveControl = itemIdTxt;
                    return;
                }
                if (index == -1)
                {
                    MessageBox.Show("상품ID가 존재하지 않습니다.");
                    itemGrid.Rows[0].Selected = true;
                    itemGrid.FirstDisplayedCell = itemGrid.Rows[0].Cells[0];
                    this.ActiveControl = itemIdTxt;
                    itemIdTxt.Text = "";
                    return;
                }
                itemGrid.Rows[index].Selected = true;
                itemGrid.FirstDisplayedCell = itemGrid.Rows[index].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("인덱스에 문제가 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
