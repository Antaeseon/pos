using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using funcLibrary;
using WpfCustomControlLibrary1;
namespace PosProject
{
    public partial class Main : Form
    {
        private List<singleItem> itemList = new List<singleItem>();
        private List<discount> disList = new List<discount>();
        private List<refTb> refList = new List<refTb>();
        private List<tran> tranList = new List<tran>();
        private List<TcpClient> clientList = new List<TcpClient>();
        private cellInfo grid = new cellInfo();
        private posInfo pos = new posInfo();
        private string line;
        private mainVariable mv = new mainVariable();
        public byte[] sendBuffer;
        TcpListener server = null; // 서버
        TcpClient clientSocket = null; // 소켓

        public Main()
        {
            InitializeComponent();
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Parse(pos.m_sIp), pos.m_nPort); // 서버 접속 IP, 포트
            clientSocket = default(TcpClient); // 소켓 설정
            server.Start(); // 서버 시작
            while (true)
            {
                try
                {
                    clientSocket = server.AcceptTcpClient(); // client 소켓 접속 허용
                    clientList.Add(clientSocket); // cleint 리스트에 추가
                    sendDataGrid();
                    Client h_client = new Client(); // 클라이언트 추가
                    h_client.OnDisconnected += new Client.DisconnectedHandler(h_client_OnDisconnected);
                    h_client.OnReceived += new Client.MessageDisplayHandler(OnReceived);
                    h_client.startClient(clientSocket, clientList);
                }
                catch (SocketException se) { break; }
                catch (Exception ex) { break; }
            }
            clientSocket.Close(); // client 소켓 닫기
            server.Stop(); // 서버 종료
        }

        void h_client_OnDisconnected(TcpClient clientSocket) // cleint 접속 해제 핸들러
        {
            if (clientList.Contains(clientSocket))
                clientList.Remove(clientSocket);
        }

        private void OnReceived(string message)
        {
            SendMessageAll(message);
        }
        
        public void SendMessageAll(string message)
        {
            try
            {
                foreach (var lst in clientList)
                {
                    TcpClient client = lst;
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = null;
                    buffer = Encoding.Unicode.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                    stream.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buttonClear()
        {
            tableLayoutPanel2.Visible = false;
            mv.m_bAdminAccess1 = false;
            mv.m_bAdminAccess2 = false;
            mv.m_bAdminFlag = false;
            ///logOutBtn.Visible = false;
            //selectCancelBtn.Visible = false;
            //allCancelBtn.Visible = false;
            //recoverBtn.Visible = false;
            adminBtn.Visible = false;
            adminOffBtn.Visible = false;
        }

        private void clear()
        {
            mv.m_bPayProgress = false;
            mv.m_nTotalMoney = 0;
            mv.m_nReceiveMoney = 0;
            priceLbl.Text = "0";
            discountLbl.Text = "0";
            totalLbl.Text = "0";
            receiveLbl.Text = "0";
            restLbl.Text = "";
            itemGrid.DataSource = null;
            itemGrid.Rows.Clear();
            itemGrid.Refresh();
        }

        private void init()
        {
            clear();
            buttonClear();
            this.itemGrid.Font = new System.Drawing.Font("tahoma", 10, System.Drawing.FontStyle.Regular);
            try
            {
                itemList = fileReadFunction.getSingleItemList();
                disList = fileReadFunction.getDiscountList();
                refList = fileReadFunction.GetRefTb();
                tranList = fileReadFunction.getTranList();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            var ll = from single in itemList
                     join re in refList on single.m_sItemId equals re.m_sItemId
                     join dis in disList on re.m_sDiscountId equals dis.m_sDiscountId
                     select new
                     {
                         iNumber = single.m_sItemId,
                         iDisNum = dis.m_sDiscountId,
                         iPrice = single.m_nItemPrice,
                         iCategory = dis.m_nCategory,
                         iDiscnt = dis.m_nDiscount
                     };
            try
            {
                Hashtable hashtable = new Hashtable();
                foreach (var jo in ll)
                {
                    if (jo.iCategory == discount.s_categoryPrice)
                    {
                        if (jo.iPrice <= jo.iDiscnt)
                        {
                            MessageBox.Show(jo.iDisNum + " 행사상품의 할인 가격이 제품 가격보다 높습니다.");
                            this.Close();
                        }
                    }
                    if (hashtable.ContainsKey(jo.iNumber + "," + jo.iDisNum))
                    {
                        MessageBox.Show(jo.iNumber + " 행사상품의 키가 중복됩니다.");
                        this.Close();
                    }
                    hashtable.Add(jo.iNumber + "," + jo.iDisNum, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void posScreen_Load(object sender, EventArgs e)
        {
            init();
            adminBtn1.FlatStyle = FlatStyle.Flat;
            adminBtn1.FlatAppearance.BorderColor = BackColor;
            adminBtn1.FlatAppearance.MouseOverBackColor = BackColor;
            adminBtn1.FlatAppearance.MouseDownBackColor = BackColor;
            adminBtn2.FlatStyle = FlatStyle.Flat;
            adminBtn2.FlatAppearance.BorderColor = BackColor;
            adminBtn2.FlatAppearance.MouseOverBackColor = BackColor;
            adminBtn2.FlatAppearance.MouseDownBackColor = BackColor;
            itemGrid.Columns[grid.m_cItemNum].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            itemGrid.Columns[grid.m_cItemPrice].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            itemGrid.Columns[grid.m_cItemTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            switch (s)
            {
                case "지정취소":
                    selectCancel();
                    break;
                case "일괄취소":
                    allCancel();
                    break;
                case "보류/복원":
                    recover();
                    break;
                case "관리자Off":
                    buttonClear();
                    break;
                case "상품등록":
                    enroll();
                    break;
                case "상품조회":
                    inquireItem();
                    break;
                case "결제":
                    pay();
                    break;
                case "행사조회":
                    inquireDis();
                    break;
                case "관리자":
                    admin();
                    break;
                case "관리자off":
                    buttonClear();
                    break;
                case "거래조회":
                    openTran();
                    break;
                default:
                    break;
            }
        }

        private void enroll()
        {
            if (itemGrid.Rows.Count == 99)
            {
                MessageBox.Show("상품은 99개까지 등록 가능합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mv.m_bPayProgress)
            {
                MessageBox.Show("결제중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmItem dlg = new FrmItem();
            dlg.FormSendEvent += new FrmItem.FormSendDataHandler(getItemNumber);
            dlg.ShowDialog();
        }

        private void getItemNumber(object itemId, object itemNum)
        {
            try
            {
                //itemForm에서 델리게이트로 이벤트 발생하면 현재 함수 Call
                mv.m_bInGrid = false;
                string getNum = itemId.ToString(); //아이템의 id를 받는다.
                int index = itemList.FindIndex(it => it.m_sItemId == getNum); //해당 아이템의 인덱스
                int rowIndex = itemGrid.Rows.Count; //dataGridView의 row 숫자

                if (Convert.ToInt32(itemNum.ToString()) > 2000000000 / itemList[index].m_nItemPrice)
                {
                    MessageBox.Show("합계 금액이 20억을 초과합니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rowIndex != 0)
                {
                    if (getNum == itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemId].Value.ToString()
                        && itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemStatus].Value.ToString() == "0")
                    {
                        int sPlusItemNum = Convert.ToInt32(itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemNum].Value);
                        int nGidItemPrice = Convert.ToInt32(itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemPrice].Value);
                        sPlusItemNum += Convert.ToInt32(itemNum.ToString());
                        if (sPlusItemNum >= 1000)
                        {
                            //MessageBox.Show("상품 수량은 999까지 가능합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //return;

                            var message = itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemName].Value.ToString() + "의 수량을 " + itemNum.ToString() + "만큼 등록하시겠습니까?";
                            var title = "물품 추가";
                            var result = MessageBox.Show(
                                message,                  // the message to show
                                title,                    // the title for the dialog box
                                MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                                MessageBoxIcon.Question); // show a question mark icon
                            switch (result)
                            {
                                case DialogResult.Yes:
                                    mv.m_bInGrid = false;
                                    break;
                                case DialogResult.No:
                                    mv.m_bInGrid = true;
                                    return;
                                default:
                                    break;
                            }
                            uint payNum = Convert.ToUInt32(itemNum.ToString()) * Convert.ToUInt32(nGidItemPrice) + calcFunction.getIntNum(priceLbl.Text);
                            if (payNum > 2000000000
                                || payNum < 0)
                            {
                                MessageBox.Show("합계 금액이 20억을 초과합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            var message = itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemName].Value.ToString() + "의 수량을 " + sPlusItemNum + "로 변경하시겠습니까?";
                            var title = "물품 추가";
                            var result = MessageBox.Show(
                                message,                  // the message to show
                                title,                    // the title for the dialog box
                                MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                                MessageBoxIcon.Question); // show a question mark icon
                            switch (result)
                            {
                                case DialogResult.Yes:
                                    mv.m_bInGrid = true;
                                    break;
                                case DialogResult.No:
                                    return;
                                default:
                                    break;
                            }

                            uint payNum = Convert.ToUInt32(itemNum.ToString()) * Convert.ToUInt32(nGidItemPrice) + calcFunction.getIntNum(priceLbl.Text);
                            if (payNum > 2000000000
                                || payNum < 0)
                            {
                                MessageBox.Show("합계 금액이 20억을 초과합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemNum].Value = sPlusItemNum.ToString();
                            itemGrid.Rows[rowIndex - 1].Cells[grid.m_cItemTotal].Value = (sPlusItemNum * nGidItemPrice).ToString();
                            mv.m_bInGrid = true;
                        }
                    }
                }
                uint tmp = Convert.ToUInt32(itemNum) * Convert.ToUInt32(itemList[index].m_nItemPrice) + calcFunction.getIntNum(priceLbl.Text);
                if (tmp > 2000000000 || tmp < 0)
                {
                    MessageBox.Show("합계 금액이 20억을 초과합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (mv.m_bInGrid == false)
                {
                    itemGrid.Rows.Add(getNum.ToString(), itemList[index].m_sItemName,
                    itemNum.ToString(), itemList[index].m_nItemPrice, (Convert.ToInt32(itemNum.ToString()) * Convert.ToInt32(itemList[index].m_nItemPrice)).ToString(),tran.s_itemStatusNormal.ToString());
                }
                //int sum = Convert.ToInt32(priceLbl.Text);
                //sum = sum + (Convert.ToInt32(itemList[index].price) * Convert.ToInt32(itemNum.ToString()));
                //priceLbl.Text = sum.ToString();
                calculate();
                itemGrid.CurrentCell = itemGrid.Rows[itemGrid.Rows.Count - 1].Cells[grid.m_cItemName];
                sendDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculate()
        {
            try
            {
                var ll = from single in itemList
                         join re in refList on single.m_sItemId equals re.m_sItemId
                         join dis in disList on re.m_sDiscountId equals dis.m_sDiscountId
                         select new
                         {
                             iNumber = single.m_sItemId,
                             iName = single.m_sItemName,
                             iPrice = single.m_nItemPrice,
                             iCategory = dis.m_nCategory,
                             iDiscnt = dis.m_nDiscount,
                         };
                var joinList = ll.ToList();
                double disPrice = 0;
                //int totalSum = 0;
                int sum = 0;
                int countCancel = 0;
                for (int rows = 0; rows < itemGrid.RowCount; rows++)
                {
                    if (itemGrid.Rows[rows].Cells[grid.m_cItemStatus].Value.ToString() == tran.s_itemStatusCancel.ToString())
                    {
                        countCancel++;
                        continue;
                    }
                    sum += (Convert.ToInt32(itemGrid.Rows[rows].Cells[grid.m_cItemTotal].Value.ToString()));
                    string gItemId = itemGrid.Rows[rows].Cells[grid.m_cItemId].Value.ToString();
                    int gItemNum = Convert.ToInt32(itemGrid.Rows[rows].Cells[grid.m_cItemNum].Value.ToString());
                    int gPrice = Convert.ToInt32(itemGrid.Rows[rows].Cells[grid.m_cItemNum].Value.ToString());
                    int gItemPrice = Convert.ToInt32(itemGrid.Rows[rows].Cells[grid.m_cItemPrice].Value.ToString());

                    var disStruc = from single in joinList
                                   where single.iNumber == gItemId
                                   select single;

                    foreach (var it in disStruc)
                    {
                        if (it.iCategory == discount.s_categoryPrice) //금액
                        {
                            disPrice -= (gItemNum * it.iDiscnt);
                        }
                        if (it.iCategory == discount.s_categoryPercent) //할인
                        {
                            disPrice -= (gItemNum * gItemPrice) * (it.iDiscnt / 100.0);
                        }
                        if (it.iCategory == discount.s_categoryNplus1) // n쁠원
                        {
                            disPrice -= ((gItemNum / (it.iDiscnt + 1))) * gItemPrice;
                        }
                    }
                    disPrice = (disPrice + disPrice % 10); //1원 단위를 없애는 역할
                    discountLbl.Text = calcFunction.getCommaString(Convert.ToInt32(disPrice));
                }
                if (itemGrid.Rows.Count == countCancel)
                {
                    discountLbl.Text = "0";
                }
                //priceLbl.Text = sum.ToString();
                priceLbl.Text = calcFunction.getCommaString(sum);
                mv.m_nTotalMoney = sum + Convert.ToInt32(disPrice);
                totalLbl.Text = calcFunction.getCommaString(mv.m_nTotalMoney);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pay()
        {

            if (mv.m_bAdminFlag)
            {
                MessageBox.Show("관리자 모드입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (priceLbl.Text == "0")
            {
                MessageBox.Show("상품을 등록해주세요");
                return;
            }

            FrmInput _id = new FrmInput("금액을 입력하세요", "Cash");

            if (_id.ShowDialog() == DialogResult.OK)
            {
                string cashMoney = _id.Result;
                int iCash = Convert.ToInt32(cashMoney);
                int restCash = 0;
                uint receiveTotal = Convert.ToUInt32(iCash)+Convert.ToUInt32(mv.m_nReceiveMoney);
                
                if( receiveTotal> 2100000000 )
                {
                    MessageBox.Show("받은 금액이 21억 이상입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (mv.m_nReceiveMoney + iCash < mv.m_nTotalMoney)
                {
                    mv.m_bPayProgress = true;
                    //totalLbl.Text = (Convert.ToInt32(totalLbl.Text) - iCash).ToString();
                    
                    mv.m_nReceiveMoney += iCash;
                    restCash = mv.m_nTotalMoney - mv.m_nReceiveMoney;
                    receiveLbl.Text = calcFunction.getCommaString(mv.m_nReceiveMoney);
                    restLbl.Text = calcFunction.getCommaString(restCash);
                    sendDataGrid();
                }
                else // 결제 가능
                {
                    mv.m_nReceiveMoney += iCash;
                    receiveLbl.Text = calcFunction.getCommaString(mv.m_nReceiveMoney);
                    restLbl.Text = "";
                    //FrmReceipt dlg = new FrmReceipt(this, receiveMoney, totalMoney); //메인 폼과 받은돈이 얼마인지 넘겨줌
                    //dlg.ShowDialog();
                    
                    saveStatus(1, mv.m_nReceiveMoney);
                    Window1 wpfwindow = new Window1(getDataGrid());
                    ElementHost.EnableModelessKeyboardInterop(wpfwindow);
                    wpfwindow.Show();
                    clear(); //결제를 완료하면 메인 폼 화면 초기화
                    buttonClear();
                    sendDataGrid();
                }
            }
        }

        private void inquireItem()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "mst 파일(*.mst) | *.mst";
                ofd.ShowDialog();
                string path = ofd.FileName;
                FrmMasterInq dlg = new FrmMasterInq(path); //메인 폼과 받은돈이 얼마인지 넘겨줌
                dlg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void inquireDis()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "mst 파일(*.mst) | *.mst";
                ofd.ShowDialog();
                string path = ofd.FileName;
                /*System.IO.StreamReader file =
                new System.IO.StreamReader(ofd.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    MessageBox.Show(line);
                }
                file.Close();
                */
                FrmDiscount dlg = new FrmDiscount(path); //메인 폼과 받은돈이 얼마인지 넘겨줌
                dlg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void admin()
        {
            FrmLogin dlg = new FrmLogin();
            dlg.FormSendEvent += new FrmLogin.FormSendDataHandler(getAdminFlag);
            dlg.ShowDialog();
        }

        private void getAdminFlag(bool flag)
        {
            if (flag)
            {
                selectCancelBtn.Visible = true;
                allCancelBtn.Visible = true;
                recoverBtn.Visible = true;
                logOutBtn.Visible = true;
                tableLayoutPanel2.Visible = true;
                adminBtn.Visible = false;
                adminOffBtn.Visible = false;
            }
        }
        
        private void selectCancel()
        {
            try
            {
                if (mv.m_bPayProgress)
                {
                    MessageBox.Show("결제중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int ser = itemGrid.CurrentCell.RowIndex;
                string itemId = itemGrid.Rows[ser].Cells[grid.m_cItemId].Value.ToString();
                string itemName = itemGrid.Rows[ser].Cells[grid.m_cItemName].Value.ToString();
                string itemNum = itemGrid.Rows[ser].Cells[grid.m_cItemNum].Value.ToString();
                string flagNum = itemGrid.Rows[ser].Cells[grid.m_cItemStatus].Value.ToString();
                var message = "";
                if (flagNum == "0")
                {
                    message = "상품 Id : " + itemId + ", 상품 Name : " + itemName +
                        ", 상품수량 : " + itemNum + "을(를)\n지정취소 하시겠습니까?";
                }
                else
                {
                    message = "상품 Id : " + itemId + ", 상품 Name : " + itemName +
                        ", 상품수량 : " + itemNum + "을(를)\n지정취소 해제 하시겠습니까?";
                }
                var title = "지정취소";
                var result = MessageBox.Show(
                    message,                  // the message to show
                    title,                    // the title for the dialog box
                    MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                    MessageBoxIcon.Question); // show a question mark icon
                if (flagNum == "0")
                {
                    switch (result)
                    {
                        case DialogResult.Yes:
                            //itemGrid.Rows.Remove(itemGrid.Rows[ser]);
                            //itemGrid.Rows[0].Cells[1].Style.BackColor = System.Drawing.Color.Red;
                            for (int i = 1; i <= 4; i++)
                            {
                                itemGrid.Rows[ser].Cells[i].Style.Font = new System.Drawing.Font(itemGrid.Rows[ser].Cells[i].Value.ToString(), 10, System.Drawing.FontStyle.Strikeout);
                            }
                            itemGrid.Rows[ser].Cells[grid.m_cItemStatus].Value = "1";
                            calculate();
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (result)
                    {
                        case DialogResult.Yes:
                            //itemGrid.Rows.Remove(itemGrid.Rows[ser]);
                            //itemGrid.Rows[0].Cells[1].Style.BackColor = System.Drawing.Color.Red;
                            for (int i = 1; i <= 4; i++)
                            {
                                itemGrid.Rows[ser].Cells[i].Style.Font = new System.Drawing.Font(itemGrid.Rows[ser].Cells[i].Value.ToString(), 10, System.Drawing.FontStyle.Regular);
                            }
                            itemGrid.Rows[ser].Cells[grid.m_cItemStatus].Value = "0";
                            calculate();
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                if (itemGrid.Rows.Count == 0)
                {
                    clear();
                }
                sendDataGrid();
            }
            catch (Exception ex)
            {
                if (itemGrid.Rows.Count == 0)
                {
                    MessageBox.Show("등록된 물품이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("지정취소할 물품을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void allCancel()
        {
            if (mv.m_bPayProgress)
            {
                MessageBox.Show("결제중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (itemGrid.Rows.Count == 0)
            {
                MessageBox.Show("등록된 물품이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmCancel dlg = new FrmCancel();
            dlg.FormSendEvent += new FrmCancel.FormSendDataHandler(getCancelReason);
            dlg.ShowDialog();
        }

        private void openTran()
        {
            FrmTranInq dlg = new FrmTranInq();
            dlg.ShowDialog();
        }


        private void getCancelReason(int reason)
        {
            if (reason == 0)
            {
                return;
            }
            if (mv.m_nReceiveMoney != 0)
            {
                MessageBox.Show(mv.m_nReceiveMoney + "원이 반환되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            saveStatus(2, reason);
            clear();
            sendDataGrid();
        }

        private void saveStatus(int status, int receiveMoney)
        {
            try
            {
                tranList = fileReadFunction.getTranList();
                string filePath = @"tran.mst";
                FileStream fileStream = new FileStream(
                filePath,              //저장경로
                FileMode.Append,       //파일스트림 모드
                FileAccess.Write       //접근 권한
                );

                StreamWriter streamWriter = new StreamWriter(
                fileStream,            //쓸 파일스트림을 여기에다가.....
                Encoding.UTF8          //파일에다 쓸때 인코딩 객체 전달.
                );

                string strData = "";
                List<sItem> tList = new List<sItem>();
                strData += (status.ToString() + ",");
                strData += (DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + ",");
                strData += (pos.m_sPosId + ",");
                strData += (tranList.Count.ToString() + ",");
                for (int i = 0; i < itemGrid.Rows.Count; i++)
                {
                    strData += (itemGrid.Rows[i].Cells[grid.m_cItemId].Value.ToString() + ",");
                    strData += (itemGrid.Rows[i].Cells[grid.m_cItemNum].Value.ToString() + ",");
                    strData += (itemGrid.Rows[i].Cells[grid.m_cItemStatus].Value.ToString() + ",");
                    tList.Add(new sItem()
                    {
                        sTranItemId = itemGrid.Rows[i].Cells[grid.m_cItemId].Value.ToString(),
                        nTranItemNum = Convert.ToInt32(itemGrid.Rows[i].Cells[grid.m_cItemNum].Value),
                        sTranItemStatus = itemGrid.Rows[i].Cells[grid.m_cItemStatus].Value.ToString()
                    });
                }
                strData += (receiveMoney.ToString() + ",");
                strData += (calcFunction.getIntNumber(discountLbl.Text).ToString() + ",");
                strData += (calcFunction.getIntNumber(priceLbl.Text).ToString() + ",");
                strData += (mv.m_nTotalMoney.ToString() + "\n");
                streamWriter.Write(strData);
                tranList.Add(new tran()
                {
                    m_nStatus = status,
                    m_sDate = DateTime.Now.ToString("HH:mm:ss"),
                    m_sPosId = pos.m_sPosId,
                    m_sTradeId = tranList.Count.ToString(),
                    m_lItem = tList,
                    m_nReceiveMoney = receiveMoney,
                    m_nDiscountMoney = Convert.ToInt32(calcFunction.getIntNumber(discountLbl.Text).ToString()),
                    m_nPriceMoney = Convert.ToInt32(calcFunction.getIntNumber(priceLbl.Text).ToString()),
                    m_nTotalMoney = mv.m_nTotalMoney
                });
                //스트림 Writer 닫아 주세요.
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void recover()
        {
            if (mv.m_bPayProgress)
            {
                MessageBox.Show("결제중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (itemGrid.Rows.Count != 0)
            {
                if (priceLbl.Text == "0")
                {
                    MessageBox.Show("보류할 상품이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var message = "상품을 보류하시겠습니까?";
                var title = "상품 보류";
                var result = MessageBox.Show(
                    message,                  // the message to show
                    title,                    // the title for the dialog box
                    MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                    MessageBoxIcon.Question); // show a question mark icon
                switch (result)
                {
                    case DialogResult.Yes:
                        saveStatus(0, 0);
                        clear();
                        sendDataGrid();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                tranList = fileReadFunction.getTranList();
                FrmRecover dlg = new FrmRecover();
                dlg.FormSendEvent += new FrmRecover.FormSendDataHandler(getTradeId);
                dlg.Show();
            }
        }

        private void getTradeId(string tradeId)
        {
            try
            {
                int index = tranList.FindIndex(it => it.m_sTradeId == tradeId);
                tran tempT = tranList[index];
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
                            , 999 * itemList[ItemIndex].m_nItemPrice, 0);
                    }
                    if (itemNum % 999 > 0)
                    {
                        itemGrid.Rows.Add(itemId, itemList[ItemIndex].m_sItemName, itemNum % 999,
                        itemList[ItemIndex].m_nItemPrice
                        , (itemNum % 999) * itemList[ItemIndex].m_nItemPrice, 0);
                    }
                }

                calculate();
                itemGrid.CurrentCell = itemGrid.Rows[itemGrid.Rows.Count - 1].Cells[grid.m_cItemName];
                sendDataGrid();
                string textFile = @"tran.mst";
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
                        streamWriter.WriteLine("3" + line.Substring(1));
                    }
                    else
                    {
                        streamWriter.WriteLine(line);
                    }
                }
                file.Close();
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mv.m_bAdminAccess1 = true;
            if (mv.m_bAdminFlag)
                return;

            if (mv.m_bAdminAccess1 && mv.m_bAdminAccess2)
            {
                adminBtn.Visible = true;
                adminOffBtn.Visible = true;
                mv.m_bAdminFlag = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mv.m_bAdminAccess2 = true;
            if (mv.m_bAdminFlag)
                return;
            if (mv.m_bAdminAccess1 && mv.m_bAdminAccess2)
            {
                adminBtn.Visible = true;
                adminOffBtn.Visible = true;
                mv.m_bAdminFlag = true;
            }
        }
        private void sendDataGrid()
        {
            try
            {
                string sendData = getDataGrid();
                SendMessageAll(sendData);
            }
            catch (Exception ex)
            {

            }
        }

        private string getDataGrid()
        {
            try
            {
                int rCount = itemGrid.Rows.Count;
                string sendData = rCount.ToString() + ",";
                for (int i = 0; i < rCount; i++)
                {
                    sendData += itemGrid.Rows[i].Cells[grid.m_cItemId].Value + ",";
                    sendData += itemGrid.Rows[i].Cells[grid.m_cItemName].Value + ",";
                    sendData += itemGrid.Rows[i].Cells[grid.m_cItemNum].Value + ",";
                    sendData += itemGrid.Rows[i].Cells[grid.m_cItemPrice].Value + ",";
                    sendData += itemGrid.Rows[i].Cells[grid.m_cItemTotal].Value + ",";
                    sendData += itemGrid.Rows[i].Cells[grid.m_cItemStatus].Value + ",";
                }
                sendData += calcFunction.getIntNum(priceLbl.Text).ToString() + ",";
                sendData += calcFunction.getIntNumber(discountLbl.Text).ToString() + ",";
                sendData += calcFunction.getIntNum(receiveLbl.Text).ToString() + ",";
                sendData += calcFunction.getIntNum(totalLbl.Text).ToString() + ",";
                return sendData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        private void itemGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            itemGrid.Columns[grid.m_cItemPrice].DefaultCellStyle.Format = "N0";
            itemGrid.Columns[grid.m_cItemTotal].DefaultCellStyle.Format = "N0";
            itemGrid.Columns[grid.m_cItemPrice].ValueType = typeof(string);
            itemGrid.Columns[grid.m_cItemTotal].ValueType = typeof(string);
        }
    }
}