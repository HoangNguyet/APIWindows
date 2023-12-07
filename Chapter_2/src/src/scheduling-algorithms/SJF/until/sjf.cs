using src.data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.scheduling_algorithms.FCFS;
using src.scheduling_algorithms;

namespace src.scheduling_algorithms.SJF.until
{
    public static class sjf
    {
        public static List<result_after_algorithm> algorithm(List<Process> processes)
        {
            processes = sort_sij(processes);
            List<result_after_algorithm> result = new List<result_after_algorithm>();
            if (processes.Count > 0)
            {
                result = untils.addTime(processes);
            }
            return result;
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

        public static int thoi_gian_den_ngan_nhat(List<Process> processes) 
        {
            int min = Convert.ToInt32(processes[0].ArrivalTime);
            int index = 0;
           for(int i =0;i<processes.Count;i++) 
            {
                int temp = Convert.ToInt32(processes[i].ArrivalTime);
                if (temp < min)
                {
                    min = temp;
                    index = i;
                }
            }
           return index;
        }
        public static int thoi_gian_thuc_thi_ngan_nhat(List<Process>processes)
        {
            var min = Convert.ToInt32(processes[0].BurstTime);
            int index = 0;
            for (int i = 0; i < processes.Count; i++)
            {
                int temp = Convert.ToInt32(processes[i].BurstTime);
                if (temp < min)
                {
                    min = temp;
                    index = i;
                }
            }
            return index;
        }

        public static int remove_process(List<Process>process, Process quen)
        {
            int index = 0;
            for(int i = 0;i<process.Count;i++)
            {
                if (process[i].Name == quen.Name)
                {
                    index = i; break;
                }
            }
            return index;
        }

        public static List<int> tien_trinh_den(List<Process> processes,int time)
        {
            var process_quen = new List<int>();
            for(int i  =0;i<processes.Count; i++)
            {
                if (processes[i].ArrivalTime <= time)
                {
                    process_quen.Add(i);
                }
            }
            return process_quen;
        }
        public static bool da_co_trong_hang_cho_chua(List<Process> processes, string name)
        {
            foreach(var  process in processes)
            {
                if(process.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Process> sort_sij(List<Process> processes)
        {
            var list = new List<Process>();
            if (processes.Count != 0 || processes != null)
            {
                int thoi_gian_hoan_thanh = 0;
                var process_cp = new List<Process>(processes);
                var quen = new List<Process>();
                int index = 0;
                while (thoi_gian_hoan_thanh == 0 && process_cp.Count != 0)
                {
                    index = thoi_gian_den_ngan_nhat(process_cp);
                    list.Add(process_cp[index]);
                    thoi_gian_hoan_thanh += (process_cp[index].BurstTime + process_cp[index].ArrivalTime);
                    process_cp.RemoveAt(index);
                }
                bool flags = true;
                while (quen.Count > 0 || flags)
                {
                    List<int> i = tien_trinh_den(process_cp,thoi_gian_hoan_thanh);
                    foreach (var j in i)
                    {
                        if (da_co_trong_hang_cho_chua(quen, process_cp[j].Name)) { }
                        else
                        {
                            quen.Add(process_cp[j]);
                        }
                    }
                    if (quen.Count > 0)
                    {
                        int k = thoi_gian_thuc_thi_ngan_nhat(quen);
                        
                        if (process_cp.Count > 0)
                        {
                            list.Add(quen[k]);
                            index = remove_process(process_cp, quen[k]);
                            thoi_gian_hoan_thanh += process_cp[index].BurstTime;
                            process_cp.RemoveAt(index);
                        }
                        quen.RemoveAt(k);
                    }
                    flags = false;
                    if ((process_cp.Count > 0 && quen.Count == 0))
                    {
                        index = thoi_gian_den_ngan_nhat(process_cp);
                        thoi_gian_hoan_thanh += process_cp[index].ArrivalTime;
                        process_cp.RemoveAt(index);
                        flags = true;
                    }

                }
            }
            return list;
        }
    }
}
