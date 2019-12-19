using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace Client
{
    public partial class Client : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        dllPosInfo ps = new dllPosInfo();
        public static bool isConnected { get; set; }
        public Client()
        {
            InitializeComponent();
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }
        
        private void InitSocket()
        {
            while (!isConnected)
            {
                try
                {
                    clientSocket = new TcpClient();
                    clientSocket.Connect(ps.m_sIp, ps.m_nPort);
                    isConnected = true;
                    stream = clientSocket.GetStream();
                    Thread t_handler = new Thread(GetMessage);
                    t_handler.IsBackground = true;
                    t_handler.Start();
                }
                catch
                {
                    clientSocket.Close();
                    isConnected = false;
                }
            }
        }

        private void clear()
        {
            try
            {
                this.Invoke(new Action(delegate ()
                {
                    cItemGrid.DataSource = null;
                    cItemGrid.Rows.Clear();
                    cItemGrid.Refresh();
                    priceLbl.Text = "0";
                    discountLbl.Text = "0";
                    receiveLbl.Text = "0";
                    totalLbl.Text = "0";
                    restLbl.Text = "";
                }));
            }
            catch (Exception ex)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            this.cItemGrid.Font = new System.Drawing.Font("tahoma", 10, System.Drawing.FontStyle.Regular);
            cItemGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cItemGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cItemGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void GetMessage()
        {
            try
            {
                while (true)
                {
                    stream = clientSocket.GetStream();
                    int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                    byte[] buffer = new byte[BUFFERSIZE];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                    DisplayText(message);
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(delegate ()
                {
                    isConnected = false;
                    Thread t = new Thread(InitSocket);
                    t.IsBackground = true;
                    t.Start();
                }));
            }
        }

        private void DisplayText(string text)
        {
            try
            {
                //연결된 클라이언트가 보낸 데이터 수신
                string[] result = text.Split(',');
                clear();
                for (int i = 0; i < Convert.ToInt32(result[sendMessage.c_totalItemNum]); i++)
                {
                    int nextItemIndex = i * 6;
                    this.Invoke(new Action(delegate ()
                    {
                        this.cItemGrid.Rows.Add(result[nextItemIndex + sendMessage.c_itemId], result[nextItemIndex + sendMessage.c_itemName],
                            result[nextItemIndex + sendMessage.c_itemNum], result[nextItemIndex + sendMessage.c_itemPrice],
                            Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemNum]) 
                            * Convert.ToInt32(result[nextItemIndex + sendMessage.c_itemPrice]));
                        if (result[nextItemIndex + 6] == sendMessage.s_hold.ToString())
                        {
                            for (int ii = 0; ii < 5; ii++)
                            {
                                cItemGrid.Rows[cItemGrid.Rows.Count - 1].Cells[ii].Style.Font = new System.Drawing.Font(cItemGrid.Rows[cItemGrid.Rows.Count - 1].Cells[ii].Value.ToString(), 10, System.Drawing.FontStyle.Strikeout);
                            }
                        }
                    }));
                }
                int priceIndex = 6 * Convert.ToInt32(result[0]) + 1;
                int discountIndex = 6 * Convert.ToInt32(result[0]) + 2;
                int receiveIndex = 6 * Convert.ToInt32(result[0]) + 3;
                int totalIndex = 6 * Convert.ToInt32(result[0]) + 4;

                this.Invoke(new Action(delegate ()
                {
                    priceLbl.Text = dllCalcFunction.getCommaString(Convert.ToInt32(result[priceIndex]));
                    discountLbl.Text = dllCalcFunction.getCommaString(Convert.ToInt16(result[discountIndex]));
                    receiveLbl.Text = dllCalcFunction.getCommaString(Convert.ToInt32(result[receiveIndex]));
                    totalLbl.Text = dllCalcFunction.getCommaString(Convert.ToInt32(result[totalIndex]));
                    restLbl.Text = dllCalcFunction.getCommaString(Convert.ToInt32(result[totalIndex]) 
                        - Convert.ToInt32(result[receiveIndex]));
                    if (restLbl.Text == totalLbl.Text)
                    {
                        restLbl.Text = "";
                    }
                }));

                if (cItemGrid.Rows.Count == 0)
                {
                    return;
                }

                this.Invoke(new Action(delegate ()
                {
                    cItemGrid.CurrentCell = cItemGrid.Rows[cItemGrid.Rows.Count - 1].Cells[1];
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(delegate ()
                {
                    Close();
                }));
            }
        }

        private void cItemGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            cItemGrid.Columns[3].DefaultCellStyle.Format = "N0";
            cItemGrid.Columns[4].DefaultCellStyle.Format = "N0";
            cItemGrid.Columns[3].ValueType = typeof(string);
            cItemGrid.Columns[4].ValueType = typeof(string);
        }
    }
}
