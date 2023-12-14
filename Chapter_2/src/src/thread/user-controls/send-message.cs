using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Http;

namespace src.thread.user_controls
{
    public partial class send_message : Form
    {
        private thread_controls.about_client thong_tin_client;
        private string ten_nguoi_nhan = "Client1";
        private string ten_nguoi_gui;
        private string anh_nguoi_nhan;
        private string anh_nguoi_gui;
        private string mode = "client";
        public send_message(string ten, string image, string mode, string ten_nguoi_gui, string anh_nguoi_gui, thread_controls.about_client thong_tin_client= new thread_controls.about_client())
        {
            InitializeComponent();
            this.ten_nguoi_nhan = ten;
            this.anh_nguoi_nhan = image;
            this.ten_nguoi_gui = ten_nguoi_gui;
            this.mode = mode;
            

            this.anh_nguoi_gui = anh_nguoi_gui;
            this.thong_tin_client = thong_tin_client;
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        IPEndPoint IP;
        Socket client;
        private void send_Click(object sender, EventArgs e)
        {
            Send(txtMessage.Text);
            AddMessage(txtMessage.Text);
        }

        void Send(string mss)
        {
            if (mss != string.Empty)
                client.Send(Serialize($"{ten_nguoi_gui},{mss}"));
        }
        private void send_message_Load(object sender, EventArgs e)
        {
            this.Text = ten_nguoi_gui;
            ten.Text = ten_nguoi_nhan;
            avatar.Image = Image.FromFile(anh_nguoi_nhan);
            if(mode != "client")
            {
                foreach (var message in thong_tin_client.message)
                {
                    string name = message.Substring(0,message.IndexOf(","));
                    string m = message.Substring(message.IndexOf(",") + 1);
                    if (name[0] == 'C')
                    {
                        flowMessage.Controls.Add(new user_controls2(thong_tin_client.imagePath, m, "not here"));
                    }
                    else
                    {
                        flowMessage.Controls.Add(new user_controls2(thong_tin_client.imageServer, m, "here"));
                    }
                }
            }
        }
        void Connect()
        {
            var rand = new Random();
            int p = rand.Next(1,255);
            IP = new IPEndPoint(IPAddress.Parse($"127.0.0.8"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
            client.Close();
        }
        void Receive()
        { 
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    int index = message.IndexOf(",");
                    string ten = message.Substring(0,index);
                    string mss = message.Substring(index+1);
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            flowMessage.Controls.Add(new user_controls2(anh_nguoi_nhan, mss, "not here"));
                        });
                    }
                }
                catch{ Close(); }
            }

        }
        void AddMessage(string s)
        {
            flowMessage.Controls.Add(new user_controls2(anh_nguoi_gui, s, "here"));
            txtMessage.Text = "";
        }
        byte[] Serialize(object obj)
        {

            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void send_message_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(mode == "client")
            {
                Send($"*&&&&&^^#%@^$^$&@^$&^^$&@^*^*@$*^$*@^$*@^$@&&&");
                Close();
            }
        }
    }
}
