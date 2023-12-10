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
    public partial class gant : UserControl
    {
        private data.ketQua ket_qua;
        private int lenGant = 70;
        private int thoi_gian_hoan_thanh;
        public gant(data.ketQua rl,int thoi_gian_hoan_thanh)
        {
            InitializeComponent();
            this.ket_qua = rl;
            this.thoi_gian_hoan_thanh = thoi_gian_hoan_thanh;
        }

        private void gant_Load(object sender, EventArgs e)
        {
            gantColor.BackColor = System.Drawing.ColorTranslator.FromHtml(ket_qua.mau_sac);
            nameProcess.Text = ket_qua.ten_tien_trinh;
            timeEnd.Text = ket_qua.thoi_gian_hoan_thanh;
            int a = Int32.Parse(ket_qua.thoi_gian_hoan_thanh) - Int32.Parse(ket_qua.thoi_gian_bat_dau);
            this.Size = new System.Drawing.Size(lenGant*a, 80);
            nameProcess.Location = new System.Drawing.Point(lenGant*a/2 - 45/2, 18);
            if (Int32.Parse(ket_qua.thoi_gian_bat_dau) > thoi_gian_hoan_thanh)
            {
                timeStart.Text = ket_qua.thoi_gian_bat_dau;
            }
            else
            {
                timeStart.Text = "";
            }
        }
    }
}
