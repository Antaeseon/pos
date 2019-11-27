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

namespace Client
{
    public partial class Client : Form
    {
        private string sIp;
        private int nPort;
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;
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
                    clientSocket.Connect(sIp, nPort);
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
                }));
            }
            catch (Exception ex)
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cItemGrid.Font = new System.Drawing.Font("tahoma", 10, System.Drawing.FontStyle.Regular);
            posInfo ps = new posInfo();
            sIp = ps.sIp;
            nPort = ps.nPort;
            cItemGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cItemGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cItemGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cItemGrid.Columns[3].DefaultCellStyle.Format = "N0";
            cItemGrid.Columns[4].DefaultCellStyle.Format = "N0";
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
                for (int i = 0; i < Convert.ToInt32(result[0]); i++)
                {
                    int tnum = i * 6;
                    this.Invoke(new Action(delegate ()
                    {
                        this.cItemGrid.Rows.Add(result[tnum + 1], result[tnum + 2], result[tnum + 3], result[tnum + 4], Convert.ToInt32(result[tnum + 3]) * Convert.ToInt32(result[tnum + 4]));
                        if (result[tnum + 6] == "1")
                        {
                            for (int ii = 0; ii < 5; ii++)
                            {
                                cItemGrid.Rows[cItemGrid.Rows.Count - 1].Cells[ii].Style.Font = new System.Drawing.Font(cItemGrid.Rows[cItemGrid.Rows.Count - 1].Cells[ii].Value.ToString(), 10, System.Drawing.FontStyle.Strikeout);
                            }
                        }
                    }));
                }
                this.Invoke(new Action(delegate ()
                {
                    priceLbl.Text = calcFunction.getCommaString(Convert.ToInt32(result[6 * Convert.ToInt32(result[0]) + 1]));
                    discountLbl.Text = calcFunction.getCommaString(Convert.ToInt16(result[6 * Convert.ToInt32(result[0]) + 2]));
                    receiveLbl.Text = calcFunction.getCommaString(Convert.ToInt32(result[6 * Convert.ToInt32(result[0]) + 3]));
                    totalLbl.Text = calcFunction.getCommaString(Convert.ToInt32(result[6 * Convert.ToInt32(result[0]) + 4]));
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
    }
}
