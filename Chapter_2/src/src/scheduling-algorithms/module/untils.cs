using src.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.module
{
    public class untils
    {
        public string thoi_gian_cho_trung_binh(List<data.ketQua> ket_qua)
        {
            double time_ = 0;
            ket_qua.ForEach(tg_cho =>

            {
                time_ += Convert.ToInt32(tg_cho.thoi_gian_cho);
            });
            time_ = Math.Round(time_ / ket_qua.Count, 3);
            return time_.ToString();
        }
        public List<data.ketQua> addTime(List<data.tienTrinh> tien_trinh)
        {
            var ket_qua  = new List<data.ketQua>();
            int thoi_gian_bat_dau = 0; // Thời gian bắt đầu dùng CPU
                                 //lbResult.Text = "Kết quả lịch trình FCFS:\r\n";
            foreach (var tien_t in tien_trinh)
            {
                if (thoi_gian_bat_dau < tien_t.thoi_gian_den)
                {
                    thoi_gian_bat_dau = tien_t.thoi_gian_den;
                }
                //int turnaroundTime = waitTime + process.BurstTime;

                //totalTurnaroundTime += turnaroundTime;
                //lbResult.Items.Add($"{process.Name}: Thời gian bắt đầu = {currentTime}, Thời gian chờ =
                //{waitTime}\r\n, Thời gian hoàn thành = {currentTime + process.BurstTime}\n, Thời gian lưu lại
                //= {currentTime + process.BurstTime - process.ArrivalTime}\r\n");


                ket_qua.Add(new data.ketQua
                {
                    ten_tien_trinh = tien_t.ten_tien_trinh,
                    thoi_gian_cho = (thoi_gian_bat_dau + tien_t.thoi_gian_thuc_thi - tien_t.thoi_gian_den - tien_t.thoi_gian_con_lai_ban_dau).ToString(),
                    thoi_gian_bat_dau = thoi_gian_bat_dau.ToString(),
                    thoi_gian_hoan_thanh = (thoi_gian_bat_dau + tien_t.thoi_gian_thuc_thi).ToString(),
                    thoi_gian_luu_lai = (thoi_gian_bat_dau +tien_t.thoi_gian_thuc_thi - tien_t.thoi_gian_den).ToString(),
                    mau_sac = tien_t.mau_sac,
                });
                thoi_gian_bat_dau += tien_t.thoi_gian_thuc_thi;
            }
            return ket_qua;
        }
        public int thoi_gian_den_ngan_nhat_dau_tien(List<data.tienTrinh> tien_trinh)
        {
            if (tien_trinh.Count > 0)
            {
                int min = tien_trinh[0].thoi_gian_den;
                for (int i = 0; i < tien_trinh.Count; i++)
                {
                    if (tien_trinh[i].thoi_gian_den<min)
                    {
                        min = tien_trinh[i].thoi_gian_den;
                    }
                }
                return min;
            }
            return -1;
        }
        public Dictionary<List<data.tienTrinh>,List<data.tienTrinh>> tien_trinh_moi_den(List<data.tienTrinh> tien_trinh,List<data.tienTrinh> hang_doi ,int thoi_gian_den)
        {
            for(int i = 0; i < tien_trinh.Count; i++)
            {
                if (tien_trinh[i].thoi_gian_den <= thoi_gian_den)
                {
                    hang_doi.Add(tien_trinh[i]);
                    tien_trinh.RemoveAt(i);
                    tien_trinh_moi_den(tien_trinh, hang_doi,thoi_gian_den);
                }
            }
            var dict = new Dictionary<List<data.tienTrinh>, List<data.tienTrinh>>();
            dict.Add(tien_trinh, hang_doi);
            return dict;
        }

        public int tien_trinh_thuc_thi_ngan_nhat(List<data.tienTrinh> hang_doi)
        {
            if(hang_doi.Count > 0)
            {
                int index = 0;
                int min = hang_doi[index].thoi_gian_thuc_thi;
                for(int i = 1; i < hang_doi.Count; i++)
                {
                    if (hang_doi[i].thoi_gian_thuc_thi < min)
                    {
                        index = i;
                        min = hang_doi[i].thoi_gian_thuc_thi;
                    }
                }
                return index;
            }

            return -1;
        }

        public List<data.tienTrinh> sap_xep_khi_ngu(List<data.tienTrinh> tien_trinh)
        {
            var kq = new List<data.tienTrinh>();
            tien_trinh.ForEach(a =>
            {
                Thread.Sleep(a.thoi_gian_den);
                kq.Add(a);
            });
            return kq;
        }


        public List<data.ketQua> gop_ket_qua_lai(List<data.ketQua> ket_qua)
        {
            var ket_qua_sau_khi_gop = new List<data.ketQua>();
            int i = 0;
            while(i< ket_qua.Count)
            {
                int j = i;
                j++;
                while(j< ket_qua.Count && ket_qua[i].ten_tien_trinh == ket_qua[j].ten_tien_trinh)
                {
                    j++;
                }
                int n = j;
                n--;
                ket_qua_sau_khi_gop.Add(new data.ketQua()
                {
                    ten_tien_trinh = ket_qua[i].ten_tien_trinh,
                    mau_sac = ket_qua[i].mau_sac,
                    thoi_gian_cho = ket_qua[n].thoi_gian_cho,
                    thoi_gian_hoan_thanh = ket_qua[n].thoi_gian_hoan_thanh,
                    thoi_gian_bat_dau = ket_qua[i].thoi_gian_bat_dau,
                    thoi_gian_luu_lai = ket_qua[n].thoi_gian_luu_lai,
                });
                i = j;
            }
            return ket_qua_sau_khi_gop;
        }
        public List<data.ketQua> ket_qua_sau_khi_loc(List<data.ketQua> ket_qua)
        {
            var sau_khi_loc = new List<data.ketQua>();
            for( int i = ket_qua.Count-1; i >= 0; i-- )
            { 
                var a = ket_qua[i];
                bool flags = false;
                sau_khi_loc.ForEach(kq =>
                {
                    if(a.ten_tien_trinh == kq.ten_tien_trinh)
                    {
                        flags = true;
                    }
                });
                if(!flags)
                {
                    sau_khi_loc.Add(new data.ketQua()
                    {
                        ten_tien_trinh = a.ten_tien_trinh,
                        mau_sac = a.mau_sac,
                        thoi_gian_cho = a.thoi_gian_cho,
                        thoi_gian_hoan_thanh = a.thoi_gian_hoan_thanh,
                        thoi_gian_bat_dau = a.thoi_gian_bat_dau,
                        thoi_gian_luu_lai = a.thoi_gian_luu_lai,
                    });
                }

            }
            return sau_khi_loc;
        }
    }
}
