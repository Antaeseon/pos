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
        private string ip = "127.0.0.1";
        private int port = 8000;
        private Thread listenThread; //Accept()가 블럭
        private Thread recevieThread; //Recevie() 작업
        private Socket clientSocket; //연결된 클라이언트 소켓

        public Client()
        {
            InitializeComponent();
        }

        private void clear()
        {
            try
            {
                cItemGrid.DataSource = null;
                cItemGrid.Rows.Clear();
                cItemGrid.Refresh();
            }
            catch(Exception ex)
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.IsBackground = true;
            listenThread.Start();
            clear();

        }
        private void Receive()
        {
            while (true)
            {
                //연결된 클라이언트가 보낸 데이터 수신
                byte[] receiveBuffer = new byte[512];
                int length = clientSocket.Receive(
                receiveBuffer, receiveBuffer.Length, SocketFlags.None
                );

                string msg = Encoding.UTF8.GetString(receiveBuffer);
                char sep = ',';
                string[] result = msg.Split(sep);
                clear();
                for(int i = 0; i < Convert.ToInt32(result[0]) ; i++)
                {
                    int tnum = i * 5;
                    this.Invoke(new Action(delegate ()
                    {
                        this.cItemGrid.Rows.Add(result[tnum+1], result[tnum+2], result[tnum+3], result[tnum+4],Convert.ToInt32(result[tnum+3])*Convert.ToInt32(result[tnum+4]));
                    }));
                }
                this.Invoke(new Action(delegate ()
                {
                    priceLbl.Text = result[5 * Convert.ToInt32(result[0]) + 1];
                    discountLbl.Text = result[5 * Convert.ToInt32(result[0]) + 2];
                    totalLbl.Text = result[5 * Convert.ToInt32(result[0]) + 3];
                }));
            }
        }

        private void Listen()
        {
            try
            {
                IPAddress ipaddress = IPAddress.Parse(ip);
                IPEndPoint endPoint = new IPEndPoint(ipaddress, port);

                //소켓생성
                Socket listenSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

                //바인드
                listenSocket.Bind(endPoint);

                //준비
                listenSocket.Listen(10);

                //수신대기

                clientSocket = listenSocket.Accept();
                //Receive 스레드 호출
                recevieThread = new Thread(new ThreadStart(Receive));
                recevieThread.IsBackground = true;
                recevieThread.Start(); //Receive() 호출

            }
            catch(Exception ex){

            }
        }
    }
}
