using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.thread.user_controls
{
    public partial class UserClient : UserControl
    {
        string imagPath = $@"C:\Users\Le Khac Ninh 2\Desktop\APIWindows\Chapter_2\src\src\data\img-interface\user9.png";
        string message = "hi nice too meet you";
        private string client_name = "Client1";
        public UserClient()
        {
            InitializeComponent();
        }

        private void UserClient_Load(object sender, EventArgs e)
        {   
            guna2CirclePictureBox1.Image = Image.FromFile(imagPath);
            label2.Text = client_name;
            if (message.Length >= 30)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(message.Substring(0,28));
                stringBuilder.Append("...");
                label1.Text = stringBuilder.ToString();
            }
            else
            {
                label1.Text = message;
            }
        }

        private void UserClient_Click(object sender, EventArgs e)
        {
            using(var f = new send_message())
            {
                f.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserClient_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UserClient_Click(sender, e);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            UserClient_Click(sender, e);
        }
    }
}
