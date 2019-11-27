using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PosProject
{
    class Client
    {
        TcpClient clientSocket = null;
        public List<TcpClient> lClientList = null;
        public void startClient(TcpClient clientSocket, List<TcpClient> clientList)
        {
            this.clientSocket = clientSocket;
            this.lClientList = clientList;

            Thread t_hanlder = new Thread(sendMessage);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
        }

        public delegate void DisconnectedHandler(TcpClient clientSocket);
        public event DisconnectedHandler OnDisconnected;

        public delegate void MessageDisplayHandler(string message);
        public event MessageDisplayHandler OnReceived;

        private void sendMessage()
        {
            NetworkStream stream = null;
            try
            {
                byte[] buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;

                while (true)
                {
                    stream = clientSocket.GetStream();
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                    if (OnReceived != null)
                        OnReceived(msg);
                }
            }
            catch (SocketException se)
            {
                Trace.WriteLine(string.Format("sendMessage - SocketException : {0}", se.Message));
                if (clientSocket != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(clientSocket);

                    clientSocket.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("sendMessage - Exception : {0}", ex.Message));
                if (clientSocket != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(clientSocket);
                    clientSocket.Close();
                    stream.Close();
                }
            }
        }
    }
}
