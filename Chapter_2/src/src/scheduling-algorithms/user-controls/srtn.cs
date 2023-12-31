﻿using src.scheduling_algorithms.module;
using System;
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
    public partial class srtn : Form
    {
        private List<data.tienTrinh> tien_trinh = new List<data.tienTrinh>();
        public srtn(List<data.tienTrinh> tien_trinh)
        {
            InitializeComponent();
            this.tien_trinh = tien_trinh;
        }

        private void srtn_Load(object sender, EventArgs e)
        {
            var _srtn = new module.Srtn();
            var until = new untils();
            var temp = new List<data.ketQua>();
            var untlil_module = new module.untils();
            var ket_qua = _srtn.ket_qua_thuat_toan(tien_trinh);
            until.hien_thi_ket_qua(result, untlil_module.ket_qua_sau_khi_loc(ket_qua), tg_cho_tb,
                untlil_module.thoi_gian_cho_trung_binh(untlil_module.ket_qua_sau_khi_loc(ket_qua)));
            until.hien_thi_gant(bieuDoGant, untlil_module.gop_ket_qua_lai(ket_qua));
        }
    }
}
