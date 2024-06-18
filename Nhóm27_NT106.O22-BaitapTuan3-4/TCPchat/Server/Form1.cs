using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Server
{
    public partial class Form1 : Form
    {
        private Socket serverSocket;
        private bool started = false;
        private int port = 5000;
        private byte[] buffer = new byte[2048];
        private delegate void SafeCallDelegate(string text);

        public Form1()
        {
            InitializeComponent();
            serverSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (started)
                {
                    started = false;
                    button1.Text = "Listen on port 5000";
                    serverSocket.Close();
                }
                else
                {
                    button1.Text = "Listening on port 5000";
                    listen();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listen()
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse(textBox1.Text), port));
            serverSocket.Listen(10);
            started = true;
            UpdateChatHistoryThreadSafe("Start listening at ");
            serverSocket.BeginAccept(new AsyncCallback(onAccepting), serverSocket);

        }
        public void onAccepting(IAsyncResult ar)
        {
            Socket serverSocket = (Socket)ar.AsyncState;
            Socket clientSocket = serverSocket.EndAccept(ar);
            UpdateChatHistoryThreadSafe("Accept connection from " + clientSocket.RemoteEndPoint.ToString());
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(onReceive), clientSocket);
            

        }
        public void onReceive(IAsyncResult ar)
        {
            Socket clientSocket = (Socket)ar.AsyncState;
            int readbytes = clientSocket.EndReceive(ar);
            string s = Encoding.UTF8.GetString(buffer);
            UpdateChatHistoryThreadSafe(s + "\n");
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(onReceive), clientSocket);

        }
        void readFromSocket(Socket clientSocket)
        {
            while (started && clientSocket != null)
            {
                int readbytes = clientSocket.Receive(buffer);
                string s = Encoding.UTF8.GetString(buffer);
                UpdateChatHistoryThreadSafe(s + "\n");
            }
        }
        private void UpdateChatHistoryThreadSafe(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
                richTextBox1.Invoke(d, new object[] { text });

            }
            else
            {
                richTextBox1.Text += text + "\n";
            }
        }
    }
}
