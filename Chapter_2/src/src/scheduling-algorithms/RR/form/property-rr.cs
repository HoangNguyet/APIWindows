using src.data;
using src.scheduling_algorithms.FCFS;
using src.scheduling_algorithms.RR.until;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.RR.form
{
    public partial class property_rr : Form
    {
        private List<data.Process> processes = new List<data.Process>();
        private int quantum;
        public property_rr(List<data.Process> _process,int quantum_)
        {
            processes=_process;
            quantum=quantum_;
            InitializeComponent();
        }

        private void property_rr_Load(object sender, EventArgs e)
        {
            List<result_after_algorithm> rl = new List<result_after_algorithm>();
            rl =rr.algorithm(processes, quantum);
            string time_ = untils.thoi_gian_cho_trung_binh(rr.filter(rl));
            untils.renderGant(rl, flowLayoutPanel1);
            untils.renderResult(dataGridView1, time,rr.filter(rl), time_);
            labelquantum.Text = quantum.ToString();
        }
    }
}
