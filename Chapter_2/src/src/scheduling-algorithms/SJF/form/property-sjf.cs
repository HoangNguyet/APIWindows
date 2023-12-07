using src.data;
using src.scheduling_algorithms.FCFS;
using src.scheduling_algorithms.SJF.until;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.SJF.form
{
    public partial class property_sjf : Form
    {
        private List<data.Process> process = new List<data.Process>();
        public property_sjf(List<data.Process> _process)
        {
            InitializeComponent();
            process = _process;
        }

        private void property_sjf_Load(object sender, EventArgs e)
        {
            List<result_after_algorithm> rl = new List<result_after_algorithm>();
            rl = sjf.algorithm(process);
            string time_ = untils.thoi_gian_cho_trung_binh(rl);
            untils.renderResult(dataGridView1, time, rl, time_);
            untils.renderGant(rl, flowLayoutPanel1);
        }
    }
}
