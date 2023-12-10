﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.user_controls
{
    public partial class fcfs : Form
    {
        private List<data.tienTrinh> tien_trinh;
        public fcfs(List<data.tienTrinh> tien_trinh)
        {
            InitializeComponent();
            this.tien_trinh = tien_trinh;
        }

        private void fcfs_Load(object sender, EventArgs e)
        {
            var _fcfs = new module.fcfs();
            var until = new untils();
            var untlil_module = new module.untils();
            var ket_qua = _fcfs.ket_qua_thuat_toan(tien_trinh);
            until.hien_thi_ket_qua(result,ket_qua,tg_cho_tb,untlil_module.thoi_gian_cho_trung_binh(ket_qua));
            until.hien_thi_gant(bieuDoGant, ket_qua);
        }
    }
}
