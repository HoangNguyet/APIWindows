using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.module
{
    public class Srtn
    {
        public List<data.ketQua> ket_qua_thuat_toan(List<data.tienTrinh> tien_trinh)
        {
            bool flags = false;
            var untils = new module.untils();
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
                //Tim tien trinh co thoi gian thuc thi ngan nhat trong hang doi
                int index = untils.tien_trinh_thuc_thi_ngan_nhat(hang_doi,flags:flags);
                //Lay tien trinh nay ra va thuc thi 1 don vi thoi gian
                var a = hang_doi[index];
                thoi_gian_bat_dau += 1;
                hang_doi.RemoveAt(index);
                kq = untils.tien_trinh_moi_den(tien_trinh_cp, hang_doi, thoi_gian_bat_dau);
                tien_trinh_cp = kq.ElementAt(0).Key;
                hang_doi = kq.ElementAt(0).Value;
                // Xet tien trinh hien tai
                //Neu thoi gian thuc thi be hon hoac bang quantum thi xem trong hang doi con tien trinh nao khong
                //Neu khong chay tien trinh co thoi gian den ngan nhat trong danh sach hien co
                if (a.thoi_gian_thuc_thi == 1)
                {
                    danh_sach_gant.Add(new data.tienTrinh()
                    {
                        ten_tien_trinh = a.ten_tien_trinh,
                        thoi_gian_den = a.thoi_gian_den,
                        thoi_gian_thuc_thi = a.thoi_gian_thuc_thi,
                        thoi_gian_con_lai_ban_dau = a.thoi_gian_con_lai_ban_dau,
                        mau_sac = a.mau_sac,
                    });
                    if (hang_doi.Count == 0 && tien_trinh_cp.Count != 0)
                    {
                        //Cap nhat moi
                        thoi_gian_bat_dau = untils.thoi_gian_den_ngan_nhat_dau_tien(tien_trinh_cp);
                        kq = untils.tien_trinh_moi_den(tien_trinh_cp, hang_doi, thoi_gian_bat_dau);
                        tien_trinh_cp = kq.ElementAt(0).Key;
                        hang_doi = kq.ElementAt(0).Value;
                    }
                    flags = false;
                }
                else
                {
                    //Luu thong tin tien trinh vua thuc thi
                    danh_sach_gant.Add(new data.tienTrinh()
                    {
                        ten_tien_trinh = a.ten_tien_trinh,
                        thoi_gian_den = a.thoi_gian_den,
                        thoi_gian_thuc_thi = 1,
                        thoi_gian_con_lai_ban_dau = a.thoi_gian_con_lai_ban_dau,
                        mau_sac = a.mau_sac,
                    });
                    //Luu thong tin tien trinh hien tai va them vao cuoi hang doi
                    hang_doi.Add(new data.tienTrinh()
                    {
                        ten_tien_trinh = a.ten_tien_trinh,
                        thoi_gian_den = a.thoi_gian_den,
                        thoi_gian_thuc_thi = a.thoi_gian_thuc_thi - 1,
                        thoi_gian_con_lai_ban_dau = a.thoi_gian_con_lai_ban_dau,
                        mau_sac = a.mau_sac,
                    });
                    flags = true;
                }
            }
            return untils.addTime(danh_sach_gant);
        }
    }
}
