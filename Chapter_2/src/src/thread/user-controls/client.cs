using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.thread.user_controls
{
    public partial class client : UserControl
    {
        private TcpClient client_;
        private NetworkStream stream;
        private Thread receiveThread;
        TextBox textBoxMessage;
        Button buttonSend;
        TextBox textBoxReceived;
        Button buttonConnect;
        public client()
        {
            InitializeComponent();
        }
        private void ConnectToServer()
        {
            try
            {
                client_ = new TcpClient($"127.0.0.{h.a}", 8080);
                stream = client_.GetStream();

                receiveThread = new Thread(new ThreadStart(ReceiveData));
                receiveThread.Start();
                LogMessage("Connected to server");
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}");
            }
        }

        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    byte[] message = new byte[4096];
                    int bytesRead = stream.Read(message, 0, message.Length);
                    string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                    LogMessage($"Server: {data}\n");
                }
                catch (Exception ex)
                {
                    LogMessage($"Error: {ex.Message}\n");
                    break;
                }
            }
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(LogMessage), message);
                return;
            }

            richTextBox1.AppendText($"{message}\r\n");
        }

        private void client_Load(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                string dataToSend = txtMessage.Text;
                byte[] dataBytes = Encoding.ASCII.GetBytes(dataToSend);
                stream.Write(dataBytes, 0, dataBytes.Length);
                LogMessage($"You: {dataToSend}\n");
                txtMessage.Text = "";
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}\n");
            }
        }
    }
}
