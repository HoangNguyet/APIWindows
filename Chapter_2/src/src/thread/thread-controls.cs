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
            var server1 = new server();
            server1.BackColor = System.Drawing.Color.White;
            server1.Location = new System.Drawing.Point(4, 0);
            server1.Name = "server1";
            server1.Size = new System.Drawing.Size(780, 741);
            server1.TabIndex = 0;
            this.Controls.Add(server1);
            Thread.Sleep(1000);
            var client1 = new client();
            client1.Location = new System.Drawing.Point(800, 20);
            client1.Name = "client1";
            client1.Size = new System.Drawing.Size(946, 688);
            client1.TabIndex = 1;
            this.Controls.Add(client1);
            
        }
    }
}
