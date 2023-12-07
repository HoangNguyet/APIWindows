using src.data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace src.scheduling_algorithms
{
    public static class untils
    {
        public static void render(DataGridView dg,List<data.Process> processs,int i,string flags)
        {
            dg.Rows.Clear();
            switch (flags){
                case "one":
                    try
                    {
                        processs.RemoveAt(i);
                    }
                    catch { };
                    break;
                default:
                    processs.Clear();
                    break;
            }
            for(int index = 0; index < processs.Count; index++)
            {
                processs[index].Name = $"P{index + 1}";
                dg.Rows.Add(processs[index].Name, processs[index].ArrivalTime, processs[index].BurstTime);
            }
        }
        public static void renderResult(DataGridView dg,Label tx,List<result_after_algorithm> rl,string time)
        {
            rl.ForEach(r =>
            {
                dg.Rows.Add(r.name,r.thoi_gian_luu_lai,r.thoi_gian_cho);
            });
            tx.Text = time;
        }

        private static void add(gant gt,FlowLayoutPanel fl)
        {
            gt.Margin = new Padding(1, 1, 1, 1);
            fl.Controls.Add(gt);
        }

        public static void renderGant(List<result_after_algorithm> rl,FlowLayoutPanel fl)
        {
            if(rl != null)
            {
                try
                {
                    var gat = new gant(rl[0], "first");
                    add(gat, fl);
                    for (int i = 1; i < rl.Count; i++)
                    {
                        var gt = new gant(rl[i], "moew moew ");
                        add(gt, fl);
                    }
                }
                catch { };
            }

        }
        public static string thoi_gian_cho_trung_binh(List<result_after_algorithm> result)
        {
            double time_ = 0;
            result.ForEach(waitime =>
            {
                time_ += Convert.ToInt32(waitime.thoi_gian_cho);
            });
            time_ = Math.Round(time_ / result.Count, 3);
            return time_.ToString();
        }
        public static List<result_after_algorithm> addTime(List<data.Process> processs)
        {
            var result = new List<result_after_algorithm>();
            int currentTime = 0; // Thời gian bắt đầu dùng CPU
                                 //lbResult.Text = "Kết quả lịch trình FCFS:\r\n";

            foreach (var process in processs)
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

                result.Add(new result_after_algorithm
                {
                    name = process.Name,
                    thoi_gian_cho = waitTime.ToString(),
                    thoi_gian_bat_dau = currentTime.ToString(),
                    thoi_gian_hoan_thanh = (currentTime + process.BurstTime).ToString(),
                    thoi_gian_luu_lai = (currentTime + process.BurstTime - process.ArrivalTime).ToString(),
                });
                currentTime += process.BurstTime;
            }
            return result;
        }
    }
}
