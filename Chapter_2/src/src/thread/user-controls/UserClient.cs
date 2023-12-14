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
        public event EventHandler click__;
        string imagPath =@"..\..\data\img-interface\user8.png";
        string message="hi";
        private string client_name="a";
        protected virtual void click_user(EventArgs e)
        {
            if (click__ != null)
            {
                click__.Invoke(this, e);
            }
        }
        public UserClient(string imagePath,string messgae,string client_name)
        {
            InitializeComponent();
            this.imagPath = imagePath;
            this.message = messgae;
            this.client_name = client_name;
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

        private void label1_Click(object sender, EventArgs e)
        {
            click_user(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            click_user(e);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            click_user(e);
        }

        private void UserClient_Click(object sender, EventArgs e)
        {
            click_user(e);
        }
    }
}
