using src.thread.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.thread
{
    public partial class thread_controls : UserControl
    {
        public thread_controls()
        {
            InitializeComponent();
        }

        private void thread_controls_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int quatity = Convert.ToInt32(guna2NumericUpDown1.Value);
            Thread t = new Thread(() =>
            {
                var f = new server();
                f.ShowDialog();
            });
            t.Start();
            Thread.Sleep(500);
            for (int i = 0; i < quatity; i++)
            {
                Thread k = new Thread(() =>
                {
                    var client = new send_message();
                    client.ShowDialog();
                });
                k.Start();
            };
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
