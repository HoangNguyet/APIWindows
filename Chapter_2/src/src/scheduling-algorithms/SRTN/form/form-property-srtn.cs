using src.data;
using src.scheduling_algorithms.RR.until;
using src.scheduling_algorithms.SJF.until;
using src.scheduling_algorithms.SRTN.until;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.SRTN.form
{
    public partial class form_property_srtn : Form
    {
        private List<data.Process> processes = new List<data.Process>();    
        public form_property_srtn(List<data.Process> _processes)
        {
            InitializeComponent();
            processes = _processes;
        }

        private void form_property_srtn_Load(object sender, EventArgs e)
        {
            List<result_after_algorithm> rl = new List<result_after_algorithm>();
            rl = srtn.algorithm(processes);
            string time_ = untils.thoi_gian_cho_trung_binh(rr.filter(rl));
            untils.renderResult(dataGridView1, time, rr.filter(rl), time_);
            untils.renderGant(srtn.gop__gant_lai(rl), flowLayoutPanel1);
        }
    }
}
