using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
