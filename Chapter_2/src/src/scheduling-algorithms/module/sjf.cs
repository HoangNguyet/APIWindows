using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.scheduling_algorithms.module
{
    public class sjf
    {
        public List<data.ketQua> ket_qua_thuat_toan(List<data.tienTrinh> tien_trinh)
        {
            var untils = new untils();
            var hang_doi = new List<data.tienTrinh>();
            var danh_sach_gant = new List<data.tienTrinh>();
            var tien_trinh_cp = new List<data.tienTrinh>(untils.sap_xep_khi_ngu(tien_trinh));
            int thoi_gian_bat_dau = untils.thoi_gian_den_ngan_nhat_dau_tien(tien_trinh_cp);
            //them tien trinh vao hang doi va xoa khoi danh sach
            var kq = untils.tien_trinh_moi_den(tien_trinh_cp, hang_doi, thoi_gian_bat_dau);
            tien_trinh_cp = kq.ElementAt(0).Key;
            hang_doi = kq.ElementAt(0).Value;
            while (hang_doi.Count > 0)
            {
                var index = untils.tien_trinh_thuc_thi_ngan_nhat(hang_doi);
                var tt_thuc_thi_ht = hang_doi[index];
                //Thuc thi
                thoi_gian_bat_dau += tt_thuc_thi_ht.thoi_gian_thuc_thi;
                danh_sach_gant.Add(new data.tienTrinh()
                {
                    ten_tien_trinh = tt_thuc_thi_ht.ten_tien_trinh,
                    thoi_gian_den = tt_thuc_thi_ht.thoi_gian_den,
                    thoi_gian_thuc_thi = tt_thuc_thi_ht.thoi_gian_thuc_thi,
                    thoi_gian_con_lai_ban_dau = tt_thuc_thi_ht.thoi_gian_con_lai_ban_dau,
                    mau_sac = tt_thuc_thi_ht.mau_sac,
                });
                //Xoa khoi hang doi
                hang_doi.RemoveAt(index);
                //them tien trinh vao hang doi va xoa khoi danh sach
                kq = untils.tien_trinh_moi_den(tien_trinh_cp, hang_doi, thoi_gian_bat_dau);
                tien_trinh_cp = kq.ElementAt(0).Key;
                hang_doi = kq.ElementAt(0).Value;
                //Cho tien trinh moi
                if (hang_doi.Count == 0 && tien_trinh_cp.Count != 0)
                {
                    //Cap nhat moi
                    thoi_gian_bat_dau = untils.thoi_gian_den_ngan_nhat_dau_tien(tien_trinh_cp);
                    kq = untils.tien_trinh_moi_den(tien_trinh_cp, hang_doi, thoi_gian_bat_dau);
                    tien_trinh_cp = kq.ElementAt(0).Key;
                    hang_doi = kq.ElementAt(0).Value;
                }
            }
            return untils.addTime(danh_sach_gant);
        }
    }
}
