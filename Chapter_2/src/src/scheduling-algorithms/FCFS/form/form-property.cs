using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using src.data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.FCFS.form
{
    public partial class form_property : Form
    {
        private List<Process> processs = new List<Process>();
        public form_property(List<Process> _process)
        {
            processs = _process;
            InitializeComponent();
        }

        private void form_property_Load(object sender, EventArgs e)
        {
            List<result_after_algorithm> rl = new List<result_after_algorithm>();
            rl = fcfs.algorithm(processs);
            string time_ = fcfs.thoi_gian_cho_trung_binh(rl);
            until.renderResult(dataGridView1,time, rl,time_);

        }
    }
}
