﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.scheduling_algorithms;

namespace src
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlgorithm_Click(object sender, EventArgs e)
        {

            var old = new Form1();
            using(var form = new form_scheduling_algorithm())
            {
                this.Hide();
                form.ShowDialog();
            }
            old.ShowDialog();
        }
    }
}