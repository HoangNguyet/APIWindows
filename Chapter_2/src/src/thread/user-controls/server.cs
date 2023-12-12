using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace src.thread.user_controls
{
    public partial class server : UserControl
    {
        private TcpListener server_;
        private TcpClient client;
        private NetworkStream stream;
        private Thread listenerThread;
        public server()
        {
            InitializeComponent();
        }
        private void StartServer()
        {
            listenerThread = new Thread(new ThreadStart(ListenForClients));
            listenerThread.Start();
            LogMessage("Server is listening...");
        }

        private void ListenForClients()
        {
            try
            {
                server_ = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                server_.Start();

                while (true)
                {
                    client = server_.AcceptTcpClient();
                    stream = client.GetStream();

                    byte[] message = new byte[4096];
                    int bytesRead;

                    while ((bytesRead = stream.Read(message, 0, message.Length)) != 0)
                    {
                        string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                        LogMessage($"Client: {data}\n");

                        //byte[] response = Encoding.ASCII.GetBytes($"Server received: {data}");
                        byte[] response = Encoding.ASCII.GetBytes("");
                        stream.Write(response, 0, response.Length);
                    }

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}");
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

        private void server_Load(object sender, EventArgs e)
        {
            StartServer();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
