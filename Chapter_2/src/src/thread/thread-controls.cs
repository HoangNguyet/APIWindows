using src.thread.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection.Emit;
using System.Timers;

namespace src.thread
{
    public partial class thread_controls : UserControl
    {
        public struct about_client{
            public string ten_client;
            public List<string> message;
            public string imagePath;
            public string imageServer;
        };
        List<about_client> danh_sach_client = new List<about_client>();
        public thread_controls()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();


        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                        
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        /*void Send(Socket client)
        {
            if (client != null && txbMessage.Text != string.Empty)
                client.Send(Serialize(txbMessage.Text));
        }*/
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);


                    //forreach là khi client nhắn thì cả server và các client khác đều nhận đc.
                    /*foreach(Socket item in clientList)
                    {
                        if(item != null && item != client)
                            item.Send(Serialize(message));
                    }*/

                        /*IPEndPoint localIpEndPoint = a.LocalEndPoint as IPEndPoint;
                        MessageBox.Show(localIpEndPoint.Address.ToString());*/
                    string tin_nhan_duoc_den_server = message;
                    int a = tin_nhan_duoc_den_server.IndexOf(",");
                    string name_client = tin_nhan_duoc_den_server.Substring(0, a);
                    string mess = (tin_nhan_duoc_den_server.Substring(a+1));
                    if (mess != "*&&&&&^^#%@^$^$&@^$&^^$&@^*^*@$*^$*@^$*@^$@&&&")
                    {
                        for (int i = 0; i < danh_sach_client.Count; i++)
                        {
                            if (name_client == danh_sach_client[i].ten_client)
                            {
                                danh_sach_client[i].message.Add($"Client1,{mess}");
                                
                                if(ten.Text == name_client)
                                {
                                    if (this.InvokeRequired)
                                    {
                                        this.BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            if (name_client[0] == 'C')
                                            {
                                                flowMessage.Controls.Add(new user_controls2(danh_sach_client[i].imagePath, mess, "not here"));
                                            }
                                            else
                                            {
                                                flowMessage.Controls.Add(new user_controls2(danh_sach_client[i].imageServer, mess, "here"));
                                            }
                                        });
                                    }
                                }

                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < danh_sach_client.Count; i++)
                        {
                            if (name_client == danh_sach_client[i].ten_client)
                            {
                                danh_sach_client.RemoveAt(i);
                            }
                        }
                        if(danh_sach_client.Count == 2)
                        {
                            danh_sach_client.RemoveAt(1);
                        }
                    }
                    if (danh_sach_client.Count == 0)
                    {
                        about_message.Visible = false;
                    }
                        AddMessage(message, name_client);

                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
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
        void AddMessage(string s,string name_client)
        {
            if (danh_sach_client.Count >= 0)
            {
                while (flowClient.Controls.Count != 0)
                {
                    flowClient.Controls.RemoveAt(0);
                }
                foreach(var a in danh_sach_client)
                {
                    string mss = mss_(a);
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            var u_client = new UserClient(imagePath: a.imagePath, messgae: mss, client_name: a.ten_client);
                            u_client.click__ += delegate (object sender, EventArgs e) { sender_client(sender, e, a); };
                            flowClient.Controls.Add(u_client);
                        });
                    }
                }
            }
        }

        private string mss_(about_client a)
        {
            string mss = "";
            if (a.message.Count > 0)
            {
                mss = a.message[a.message.Count - 1].Substring(a.message[a.message.Count - 1].IndexOf(",") + 1);
            }
            return mss;
        }

        List<int> ints = new List<int>() { 4,5,6,7,8,9};
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            var rand = new Random();
            if(ints.Count == 0) { ints = new List<int>() { 4, 5, 6, 7, 8, 9 }; }
            var b = rand.Next(0, ints.Count - 1);
            var c = ints[b];
            ints.RemoveAt(b);
            string name_client = $"Client{danh_sach_client.Count}";
            if(danh_sach_client.Count <2) {
                name_client = $"Client{danh_sach_client.Count+1}";
            }
            string img_client = $@"..\..\data\img-interface\user{c}.png";
            var l = new about_client()
            {
                ten_client = name_client,
                imagePath = img_client,
                message = new List<string>(),
                imageServer = $@"..\..\data\img-interface\server.png",
            };
            danh_sach_client.Add(l);
            Thread t = new Thread(() =>
            {
                var a = new send_message("Server", $@"..\..\data\img-interface\server.png", "client",name_client,img_client);
                a.ShowDialog();
            });
            t.Start();
            var u_client = new UserClient(imagePath: img_client, messgae: "", client_name: name_client);
            u_client.click__ += delegate (object s, EventArgs ev) { sender_client(sender, e, l); };
            flowClient.Controls.Add(u_client);
            if (flowClient.Controls.Count == 2)
            {
                var g = new about_client()
                {

                    ten_client = "All Client",
                    imagePath = @"..\..\data\img-interface\group.png",
                    message = new List<string>(),
                    imageServer = $@"..\..\data\img-interface\server.png",
                };
                danh_sach_client.Add(g);
                u_client = new UserClient(imagePath: $@"..\..\data\img-interface\group.png", messgae: "", client_name: "All Client");
                var a = danh_sach_client[danh_sach_client.Count - 1];
                u_client.click__ += delegate (object s, EventArgs ev) { sender_client(sender, e, g); };
                flowClient.Controls.Add(u_client);
            }
        }
        void sender_client(object sender,EventArgs e,about_client a)
        {
            if (danh_sach_client.Count >= 0)
            {
                about_message.Visible = true;
                render(a);
            }
        }
        private void render(about_client a)
        {
            avatar.Image = Image.FromFile(a.imagePath);
            ten.Text = a.ten_client.ToString();
            flowMessage.Controls.Clear();
            foreach(var mss in a.message)
            {
                string ten = "";
                string m = "";
                if (mss == "" || mss == null) {}
                else
                {
                    int i = mss.IndexOf(",");
                    ten = mss.Substring(0, i);
                    m = mss.Substring(i + 1);
                }
                if (ten[0] == 'C')
                {
                    flowMessage.Controls.Add(new user_controls2(a.imagePath,m,"not here"));
                }
                else if(ten == ""|| ten ==null)
                {
                    
                }
                else
                {
                    flowMessage.Controls.Add(new user_controls2(a.imageServer, m, "here"));
                }
            }
        }
        void Send(Socket client)
        {
            if (client != null && txtMessage.Text != string.Empty)
                client.Send(Serialize(txtMessage.Text));
        }
        private void send_client_Click(object sender, EventArgs e)
        {
            flowMessage.Controls.Add(new user_controls2($@"..\..\data\img-interface\server.png", txtMessage.Text, "here"));
            int index = 0;
            for(int i = 0; i < danh_sach_client.Count; i++)
            {
                if(ten.Text == danh_sach_client[i].ten_client)
                {
                    danh_sach_client[i].message.Add($"Server,{txtMessage.Text}");
                    index = i;
                    break;
                    
                }
                
            }
            flowClient.Controls.Clear();
            foreach(var a in danh_sach_client)
            {
                string mss = "";
                if(a.message.Count > 0)
                {
                    mss = a.message[a.message.Count - 1].Substring(a.message[a.message.Count - 1].IndexOf(",")+1);
                }
                var b = new UserClient(a.imagePath,mss,a.ten_client);
                b.click__ += delegate (object s, EventArgs ev) { sender_client(sender, e, a); };
                flowClient.Controls.Add(b);
            }

            if (index == 2)
            {
                foreach (var socket in clientList)
                {
                    socket.Send(Serialize($"Server,{txtMessage.Text}"));
                }
            }
            else
            {
                int index_socket = index <= 1 ? index : index - 1;
                IPEndPoint localIpEndPoint = clientList[index_socket].LocalEndPoint as IPEndPoint;
                clientList[index_socket].Send(Serialize($"Server,{txtMessage.Text}"));
            }
            txtMessage.Text = "";
        }

        private void thread_controls_Load(object sender, EventArgs e)
        {

        }
    }

}
