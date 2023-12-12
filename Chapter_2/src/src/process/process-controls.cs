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

namespace src.process
{
    public partial class process_controls : UserControl
    {
        public process_controls()
        {
            InitializeComponent();
        }

        private void process_controls_Load(object sender, EventArgs e)
        {
            var list_process = Process.GetProcesses();
            guna2DataGridView1.Rows.Clear();
            foreach ( var process in list_process )
            { 
                guna2DataGridView1.Rows.Add(process.Id, process.ProcessName,process.MainWindowTitle,
                    process.PagedMemorySize64/(1024*1024),process.VirtualMemorySize64/(1024*1024),process.HandleCount);
            }
        }

        private void guna2DataGridView1_MouseHover(object sender, EventArgs e)
        {
            process_controls_Load(sender, e);
        }
    }
}
