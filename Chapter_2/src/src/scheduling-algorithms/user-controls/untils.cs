using Guna.UI2.WinForms;
using src.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.user_controls
{
    public class untils
    {
        public void hien_thi_ket_qua(Guna2DataGridView dg, List<data.ketQua> ket_qua, Label lb, string thoi_gian_cho_tb)
        {
            ket_qua.ForEach(kq =>
            {
                dg.Rows.Add(kq.ten_tien_trinh, kq.thoi_gian_luu_lai, kq.thoi_gian_cho);
            });
            lb.Text = thoi_gian_cho_tb;
        }
        public void hien_thi_gant(FlowLayoutPanel panel, List<data.ketQua> ket_qua)
        {
            if (ket_qua.Count() > 0)
            {
                for (int i = 0; i < ket_qua.Count; i++)
                {
                    if (i == 0)
                    {
                        var a = new gant(ket_qua[0], -1);
                        a.Margin = new Padding(0, 0, 0, 0);
                        panel.Controls.Add(a);
                    }
                    else
                    {
                        int n = i;
                        var thoi_gian_hoan_thanh_ = Int32.Parse(ket_qua[--n].thoi_gian_hoan_thanh);
                        var thoi_gian_bat_dauu_ = Int32.Parse(ket_qua[i].thoi_gian_bat_dau);
                        var a = new gant(ket_qua[i], thoi_gian_hoan_thanh_);
                        if (thoi_gian_bat_dauu_ > thoi_gian_hoan_thanh_)
                        {
                            a.Margin = new Padding((thoi_gian_bat_dauu_ - thoi_gian_hoan_thanh_)*70, 0, 0, 0);
                        }
                        else
                        {
                            a.Margin = new Padding(0, 0, 0, 0);
                        }
                        panel.Controls.Add(a);
                    }
                }
            }
        }
    }

}