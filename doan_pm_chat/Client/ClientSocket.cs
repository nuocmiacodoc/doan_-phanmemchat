using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Client
{
    class ClientSocket
    {
        private TcpClient tcpClient;
        private NetworkStream stm;
        private byte[] byteSend;
        private byte[] byteReceive;
        private string ipServer;
        private int port;

        public void initTCPClient(string IP, int Port)
        {
            ipServer = IP;
            port = Port;
            tcpClient = new TcpClient();
            byteReceive = new byte[100];
        }

        public void connectToServer()
        {
            tcpClient.Connect(ipServer, port);
            stm = tcpClient.GetStream();
        }

        public void sendData(string data)
        {
            byteSend = Encoding.ASCII.GetBytes(data);
            stm.Write(byteSend, 0, byteSend.Length);
        }

        public string receiveData()
        {
            byteReceive = new byte[100];
            stm.Read(byteReceive, 0, 100);
            string str = Encoding.ASCII.GetString(byteReceive);
            return str;
        }

        public void closeConnection()
        {
            tcpClient.Close();
        }

    }
}
