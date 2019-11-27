using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PosProject
{
    public partial class FrmItem : Form

    {

        List<singleItem> itemList = new List<singleItem>();
        string line;
        //델리게이트 선언
        public delegate void FormSendDataHandler(string itemId, string itemNum);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;
        public FrmItem()
        {
            InitializeComponent();
        }

        private void itemForm_Load(object sender, EventArgs e)
        {
            clear();
            try
            {
                Hashtable hashtable = new Hashtable();
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"item.mst");
                while ((line = file.ReadLine()) != null)
                {
                    char sep = ',';
                    string[] result = line.Split(sep);

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == "")
                        {
                            MessageBox.Show("item 마스터 파일 문자열에 공백이 있습니다.");
                            this.Close();
                        }
                    }

                    if (result.Length != 3)
                    {
                        MessageBox.Show("상품 마스터 파일 문자열이 잘못되었습니다.");
                        this.Close();
                    }
                    if (Convert.ToInt32(result[2]) <= 0)
                    {
                        MessageBox.Show(result[0] + " 상품의 가격이 0원 이하입니다.");
                        this.Close();
                    }
                    if (hashtable.ContainsKey(result[0]))
                    {
                        MessageBox.Show(result[0] + " 상품의 키가 중복됩니다.");
                        this.Close();
                    }
                    hashtable.Add(result[0], true);
                    itemList.Add(new singleItem() { m_sItemId = result[0], m_sItemName = result[1], m_nItemPrice = Convert.ToInt32(result[2]) });
                }
                file.Close();

                int cnt = itemList.Count;
                string[] data = new string[cnt];
                
                for(int i = 0; i < cnt; i++)
                {
                    data[i] = itemList[i].m_sItemId;
                }
                itemIdBox.Items.AddRange(data);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            ////////////
            /*System.IO.StreamReader file =
            new System.IO.StreamReader(@"item.mst");
            while ((line = file.ReadLine()) != null)
            {
                char sep = ',';
                string[] result = line.Split(sep);
                itemList.Add(new singleItem() { itemNum = result[0], itemName = result[1], price = Convert.ToInt32(result[2]) });
            }

            file.Close();*/
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (itemList.Exists(x => x.m_sItemId == itemIdBox.Text))
            {
                try
                {
                    if (itemNum.Text == "")
                    {
                        this.ActiveControl = itemNum;
                        MessageBox.Show("상품 수량을 입력해주세요");
                        return;
                    }
                    if (Convert.ToInt32(itemNum.Text) <= 0)
                    {
                        MessageBox.Show("수량을 1개 이상 입력해주세요");
                        return;
                    }
                    this.FormSendEvent(itemIdBox.Text, itemNum.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("상품수량 입력이 올바르지 않습니다.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("상품번호가 존재하지 않습니다.");
                this.ActiveControl = itemIdBox;
                itemIdBox.SelectAll();
            }
        }

        private void itemNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void clear()
        {
            itemName.Text = "";
        }

        private void itemNum_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (itemNum.Text == "")
            {
                return;
            }
            bool flag = int.TryParse(itemNum.Text, out i);
            if (!flag)
            {
                MessageBox.Show("잘못된 입력입니다.");
                itemNum.Text = "";
            }
        }

        private void itemIdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = itemList.FindIndex(it => it.m_sItemId == itemIdBox.Text);
                if (index == -1)
                {
                    itemName.Text = "Not Exist";
                }
                else
                {
                    itemName.Text = itemList[index].m_sItemName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}