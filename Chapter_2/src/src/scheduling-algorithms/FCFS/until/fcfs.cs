using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.data;

namespace src.scheduling_algorithms.FCFS
{
    public static class fcfs {

        public static List<result_after_algorithm> algorithm(List<Process> processes)
        {
            List<result_after_algorithm> result = new List<result_after_algorithm>();
            if (processes.Count > 0)
            {
                // Sắp xếp tiến trình theo thời gian đến
                processes.Sort((p1, p2) => p1.ArrivalTime.CompareTo(p2.ArrivalTime));
                //int totalTurnaroundTime = 0;
                int currentTime = 0; // Thời gian bắt đầu dùng CPU
                //lbResult.Text = "Kết quả lịch trình FCFS:\r\n";

                foreach (var process in processes)
                {
                    if (currentTime < process.ArrivalTime)
                    {
                        currentTime = process.ArrivalTime;
                    }
                    int waitTime = currentTime - process.ArrivalTime;
                    //int turnaroundTime = waitTime + process.BurstTime;

                    //totalTurnaroundTime += turnaroundTime;
                    //lbResult.Items.Add($"{process.Name}: Thời gian bắt đầu = {currentTime}, Thời gian chờ =
                    //{waitTime}\r\n, Thời gian hoàn thành = {currentTime + process.BurstTime}\n, Thời gian lưu lại
                    //= {currentTime + process.BurstTime - process.ArrivalTime}\r\n");
                    
                    result.Add(new result_after_algorithm {
                        name = process.Name, thoi_gian_cho = waitTime.ToString(),
                        thoi_gian_bat_dau = currentTime.ToString(),
                        thoi_gian_hoan_thanh = (currentTime + process.BurstTime).ToString(),
                        thoi_gian_luu_lai = (currentTime + process.BurstTime - process.ArrivalTime).ToString(),
                    });
                    currentTime += process.BurstTime;
                }
            }
            return result;
        }
        public static string thoi_gian_cho_trung_binh(List<result_after_algorithm> result)
        {
            double time_= 0;
            result.ForEach(waitime =>
            {
                time_ += Convert.ToInt32(waitime.thoi_gian_cho);
            });
            time_ = Math.Round(time_/result.Count,3);
            return time_.ToString();
        }
    }
}
