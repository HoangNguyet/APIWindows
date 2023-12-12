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
    public partial class send_message : Form
    {
        private string ten_ = "Client1";
        public send_message()
        {
            InitializeComponent();
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void send_message_Load(object sender, EventArgs e)
        {
            ten.Text = ten_;
        }
    }
}
