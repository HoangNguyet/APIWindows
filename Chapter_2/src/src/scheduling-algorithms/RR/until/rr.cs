using src.data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms.RR.until
{
    public static class rr
    {
        public static List<result_after_algorithm> algorithm(List<data.Process> processes,int quantum)
        {
            processes = processes_(processes, quantum);
            List<result_after_algorithm> result = new List<result_after_algorithm>();
            if (processes.Count > 0)
            {
                result = untils.addTime(processes);
            }
            return result;
        }

        public static List<data.Process> processes_(List<data.Process> processes,int quantum)
        {
            var process_cp = new List<data.Process>(processes);
            var pro = new List<data.Process>();
            var hang_doi= sleepSort(processes);
            while(hang_doi.Count > 0)
            {
                var tmp = hang_doi[0];
                if (tmp.BurstTime < quantum)
                {
                    pro.Add(tmp);
                    hang_doi.RemoveAt(0);
                }
                else
                {
                    var temp = new data.Process {
                        Name = tmp.Name, ArrivalTime = tmp.ArrivalTime, BurstTime = tmp.BurstTime - quantum, thoi_gian_con_lai_ban_dau = tmp.thoi_gian_con_lai_ban_dau,
                    };
                    var haha = new data.Process { Name = tmp.Name, ArrivalTime = tmp.ArrivalTime, BurstTime = quantum, thoi_gian_con_lai_ban_dau = tmp.thoi_gian_con_lai_ban_dau };
                    pro.Add(haha);
                    hang_doi.RemoveAt(0);
                    hang_doi.Add(temp);
                }
            }
            return pro;
        }
        public static List<data.Process> sleepSort(List<data.Process> pr)
        {
            var temp = new List<data.Process>();
            pr.ForEach(p =>
            {
                Thread.Sleep(p.ArrivalTime);
                temp.Add(p);

            });
            return temp;
        }

        public static bool in_(List<result_after_algorithm> a,string name)
        {
            for(int i= 0; i < a.Count; i++)
            {
                if (a[i].name == name) return true;
            }
            return false;
        }
        public static List<result_after_algorithm> filter(List<result_after_algorithm> rl)
        {
            var rls = new List<result_after_algorithm>();
            for( int i = rl.Count - 1; i >= 0; i--)
            {
                if (!in_(rls, rl[i].name))
                {
                    rls.Add(rl[i]);
                }
            }
            return rls;
        }
    }
}
