using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace src
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void thay_mau_color(Guna2Button button1, Guna2Button button2, Guna2Button button3) {
            button1.Checked = true;
            button2.Checked = false;
            button3.Checked = false;
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            thay_mau_color(btnThread, btnProcess, btnAlgorithm);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            thay_mau_color(btnProcess,btnThread, btnAlgorithm);
        }

        private void btnAlgorithm_Click(object sender, EventArgs e)
        {
            thay_mau_color(btnAlgorithm, btnProcess, btnThread);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
