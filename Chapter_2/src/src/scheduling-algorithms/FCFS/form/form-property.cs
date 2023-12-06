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
            // 

            Panel panel1 = new Panel();


            /*this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(31, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 42);
            this.panel1.TabIndex = 6;
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);*/

        }
    }
}
