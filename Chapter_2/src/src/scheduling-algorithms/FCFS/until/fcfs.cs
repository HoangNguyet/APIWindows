using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.data;

namespace src.scheduling_algorithms.FCFS
{
    public static class fcfs {

        public static List<result_after_algorithm> algorithm(List<data.Process> processes)
        {
            List<result_after_algorithm> result = new List<result_after_algorithm>();
            if (processes.Count > 0)
            {
                // Sắp xếp tiến trình theo thời gian đến
                processes.Sort((p1, p2) => p1.ArrivalTime.CompareTo(p2.ArrivalTime));
                //int totalTurnaroundTime = 0;
                result = untils.addTime(processes);
            }
            return result;
        }
    }
}
