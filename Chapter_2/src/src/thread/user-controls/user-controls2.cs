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
        string imagPath = $@"C:\Users\Le Khac Ninh 2\Desktop\APIWindows\Chapter_2\src\src\data\img-interface\user9.png";
        string message = "hi nice too meet you hi ha haha ";
        private string xac_min = "not heare";
        public user_controls2()
        {
            InitializeComponent();
        }


        private void user_controls2_Load_1(object sender, EventArgs e)
        {
            if(xac_min == "not here")
            {
                guna2CirclePictureBox1.Location = new System.Drawing.Point(10, 11);
                label1.Location = new System.Drawing.Point(85, 22);
            }
            guna2CirclePictureBox1.Image = Image.FromFile(imagPath);
            int i = 0;
            int j = 0;
            if (message.Length >= 30)
            {
                StringBuilder sb = new StringBuilder();
                while (true)
                {
                    try
                    {
                        sb.Append(message.Substring(i, 30));
                        sb.Append("\n");
                        i = i + 29;
                        j++;
                    }
                    catch { break; }
                    sb.Append(message.Substring(i));
                }
                label1.Text = sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(message);
               for (int k = message.Length; i <=30; i++)
                {
                    sb.Append(" ");
                }
               label1.Text += sb.ToString();
            }
            if (j <= 1)
            {

            }
            else
            {
                this.Size = new System.Drawing.Size(350, 94 + (j - 1) * 28);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
