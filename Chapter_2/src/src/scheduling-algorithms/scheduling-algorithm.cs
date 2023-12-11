using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using src.scheduling_algorithms.user_controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace src.scheduling_algorithms
{
    public partial class scheduling_algorithm : UserControl
    {
        private untils untl = new untils();
        public scheduling_algorithm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            data.Rows.Add($"P{data.Rows.Count}",txtThoiGianDen.Value,txtThoiGianThucThi.Value);
            txtThoiGianDen.Value = 0;
            txtThoiGianThucThi.Value = 0;
            txtThoiGianDen.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in data.Rows)
            {
                if (row.Selected)
                {
                    untl.hien_thi_ra_datagridview(data, "moew moew", row.Index);
                    break;
                }

            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            untl.hien_thi_ra_datagridview(data, "xoa_het", 99);
        }

        private void scheduling_algorithm_Load(object sender, EventArgs e)
        {
            opption.Text = "FCFS";
        }

        private void run_Click(object sender, EventArgs e)
        {
            switch(opption.Text)
            {
                case "FCFS":
                    untl.hien_thi_ket_qua(new fcfs(untl.them_vao_danh_sach(data)));
                    break;
                case "RR":
                    string quantum = Interaction.InputBox("Quatum");
                    try
                    {
                        int q = Int32.Parse(quantum);
                        if (q <= 0)
                        {
                            break;
                        }
                        untl.hien_thi_ket_qua(new rr(untl.them_vao_danh_sach(data),q));
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập quantum là một số nguyên dương vào trước khi thực hiện thuật toán RR","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    break;
                case "SJF":
                    untl.hien_thi_ket_qua(new sjf(untl.them_vao_danh_sach(data)));
                    break;
                case "SRTN":
                    untl.hien_thi_ket_qua(new srtn(untl.them_vao_danh_sach(data)));
                    break;
            }
        }
    }
}
