using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using src.scheduling_algorithms.FCFS.form;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using src.scheduling_algorithms.SJF;
using src.scheduling_algorithms.RR.until;
using src.scheduling_algorithms.SRTN.until;

namespace src.scheduling_algorithms
{
    public partial class form_scheduling_algorithm : Form
    {
        private List<data.Process> processes = new List<data.Process>();
        public form_scheduling_algorithm()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var process = new data.Process()
            {
                Name = $"P{processes.Count + 1}",
                ArrivalTime = Convert.ToInt32(boxArivealTime.Value),
                BurstTime = Convert.ToInt32(boxBurstTime.Value),
                thoi_gian_con_lai_ban_dau = Convert.ToInt32(boxBurstTime.Value),
            };
            processes.Add(process);
            dataGridView1.Rows.Add(process.Name, process.ArrivalTime, process.BurstTime);
            boxArivealTime.Text = "0";
            boxBurstTime.Text = "0";
            boxArivealTime.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Selected)
                {
                    untils.render(dataGridView1,processes,row.Index,"one");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            untils.render(dataGridView1, processes, 96, "moew moew");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
             using (var f = new form_property(processes))
             {

                 f.ShowDialog();
             };
            using (var f = new SJF.form.property_sjf(processes))
            {
                f.ShowDialog();
            }
            using (var f = new RR.form.property_rr(processes,Convert.ToInt32(txtquantum.Value)))
            {
                f.ShowDialog();
            }
            using (var f = new SRTN.form.form_property_srtn(processes))
            {
                f.ShowDialog();
            }
        }
    }
}
