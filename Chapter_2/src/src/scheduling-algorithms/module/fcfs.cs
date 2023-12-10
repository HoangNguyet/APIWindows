using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.scheduling_algorithms.module
{
    public class fcfs
    {
        public List<data.ketQua> ket_qua_thuat_toan(List<data.tienTrinh> tien_trinh)
        {
            var ketQua = new List<data.ketQua>();
            if (tien_trinh.Count > 0)
            {
                // Sắp xếp tiến trình theo thời gian đến
                tien_trinh.Sort((p1, p2) => p1.thoi_gian_den.CompareTo(p2.thoi_gian_den));
                //int totalTurnaroundTime = 0;
                var untl = new untils();
                ketQua = untl.addTime(tien_trinh);
            }
            return ketQua;
        }
    }
}
