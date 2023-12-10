using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms
{
    public class untils
    {
        public List<data.tienTrinh> them_vao_danh_sach(Guna2DataGridView dg)
        {
            var m = new data.mau_sac();
            var a = new List<data.tienTrinh>();
            var mau_sac = new List<string>(m.mau_);
            var random = new Random();
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {
                var index = random.Next(0, mau_sac.Count - 1);
                a.Add(new data.tienTrinh()
                {
                    ten_tien_trinh = dg.Rows[i].Cells["Column1"].Value.ToString(),
                    thoi_gian_den = Int32.Parse(dg.Rows[i].Cells["Column2"].Value.ToString()),
                    thoi_gian_thuc_thi = Int32.Parse(dg.Rows[i].Cells["Column3"].Value.ToString()),
                    thoi_gian_con_lai_ban_dau = Int32.Parse(dg.Rows[i].Cells["Column3"].Value.ToString()),
                    mau_sac = mau_sac[index],
                });
                mau_sac.RemoveAt(index);
            }
            return a;
        }
        public void hien_thi_ra_datagridview(Guna2DataGridView dg, string mode, int index)
        {
            if (mode == "xoa_het")
            {
                dg.Rows.Clear();
                return;
            }
            else
            {
                if (dg.Rows.Count == 2)
                {
                    hien_thi_ra_datagridview(dg, "xoa_het", 99);
                    return;
                }
                else
                {
                    dg.Rows.RemoveAt(index);
                    var danh_sach_tien_trinh_hien_tai = them_vao_danh_sach(dg);
                    dg.Rows.Clear();
                    for (int i = 0; i < danh_sach_tien_trinh_hien_tai.Count; i++)
                    {
                        int n = i;
                        dg.Rows.Add($"P{++n}", danh_sach_tien_trinh_hien_tai[i].thoi_gian_den, danh_sach_tien_trinh_hien_tai[i].thoi_gian_con_lai_ban_dau);
                    }
                    danh_sach_tien_trinh_hien_tai.Clear();
                    return;
                }

            }
        }
        public void hien_thi_ket_qua(Form f)
        {
            using (f)
            {
                f.ShowDialog();
            }
        }
    }
}
