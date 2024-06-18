using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TCPchat
{
    public partial class Form1 : Form
    {
        private Socket clientSocket;

        public Form1()
        {
            InitializeComponent();
            clientSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress serverIP = IPAddress.Parse(textBox1.Text);
                int serverPort = int.Parse(textBox2.Text);
                IPEndPoint serverEndPoint = new IPEndPoint(serverIP, serverPort);
                clientSocket.BeginConnect(serverEndPoint, new AsyncCallback(onConnecting), clientSocket);
                richTextBox2.Text += "Connected to server" + serverEndPoint.ToString() + "\n";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void onConnecting(IAsyncResult asyncResult)
        {
            Socket client = (Socket)asyncResult.AsyncState;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Send(Encoding.UTF8.GetBytes(richTextBox1.Text));
                richTextBox1.Text = "";

            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
