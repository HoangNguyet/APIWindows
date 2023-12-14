
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
    public partial class user_controls2 : UserControl
    {
        string imagPath;
        string message;
        private string xac_min;
        public user_controls2(string imagePath,string message,string xac_minh)
        {
            InitializeComponent();
            this.message = message;
            this.imagPath = imagePath;
            this.xac_min = xac_minh;
        }



        [Category("set Name")]
        private String setMesage
        {
            get { return message; }set { message = value; }
        }
        private void user_controls2_Load_1(object sender, EventArgs e)
        {
            if (xac_min == "not here")
            {
                guna2CirclePictureBox1.Location = new System.Drawing.Point(10, 11);
                label1.Location = new System.Drawing.Point(85, 22);
            }
            guna2CirclePictureBox1.Image = Image.FromFile(imagPath);
            string mss = message;
            label1.Text = mss;
            if (label1.Size.Width >= 215)
            {
                label1.Text = "";
                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                foreach (var a in mss)
                {
                    if (label1.Size.Width <= 215)
                    {
                        sb2.Append(a);
                    }
                    else
                    {
                        sb2.Append("\n");
                        sb2.Append(a);
                        sb.Append(sb2.ToString());
                        sb2 = new StringBuilder();
                        label1.Text = "";
                    }
                    label1.Text = sb2.ToString();
                }
                label1.Text = sb.ToString();
            }
            else if(xac_min != "not here")
            {
                while (label1.Size.Width <= 215)
                {
                    string name = " " + mss;
                    mss = name;
                    label1.Text = mss;
                }
            }else if(xac_min  == "not here")
            {
                label1.Text = mss;
            }
            /*if (j <= 1)
            {

            }
            else
            {
                this.Size = new System.Drawing.Size(350, 94 + (j - 1) * 24);
            }*/
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
