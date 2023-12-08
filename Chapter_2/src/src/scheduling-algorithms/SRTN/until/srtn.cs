using src.data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.scheduling_algorithms.SJF.until;
using System.Reflection;
using System.Windows.Forms;
using src.scheduling_algorithms.RR.until;

namespace src.scheduling_algorithms.SRTN.until
{
    public class srtn
    {
        public static List<result_after_algorithm> algorithm(List<data.Process> proc)
        {
            List<result_after_algorithm> result = new List<result_after_algorithm>();
            var processes = thu_tu_chay_tien_trinh(proc);
            if (processes.Count > 0)
            {
                result = untils.addTime(processes);
            }
            return result;
        }
        public static List<data.Process> thu_tu_chay_tien_trinh(List<data.Process> processes)
        {
            int thoi_gian_hoan_thanh = 0;
            var list = new List<data.Process>();
            var hh = new List<data.Process>();
            if (processes.Count != 0 || processes != null)
            {
                var quen = rr.sleepSort(processes);
                for(int i=0;i<quen.Count;i++)
                {
                    if (quen[i].ArrivalTime == quen[0].ArrivalTime) {
                        hh.Add(quen[i]);
                    }
                }
                int index = sjf.thoi_gian_thuc_thi_ngan_nhat(hh);
                thoi_gian_hoan_thanh = quen[index].ArrivalTime;
                while (quen.Count > 0)
                {
                    var a = quen[index];
                    a.BurstTime -= 1;
                    thoi_gian_hoan_thanh += 1;
                    list.Add(new data.Process
                    {
                        Name = a.Name,
                        ArrivalTime = a.ArrivalTime,
                        BurstTime = 1,
                        thoi_gian_con_lai_ban_dau = a.thoi_gian_con_lai_ban_dau,
                    });
                    if(a.BurstTime <= 0)
                    {
                        quen.RemoveAt(index);
                    }
                    if (quen.Count != 0)
                    {
                        index = thoi_gian_thuc_thi_ngan_nhat_trong_hang_doi(quen, thoi_gian_hoan_thanh);
                    }
                }
            }
            return list;
        }
        public static int thoi_gian_thuc_thi_ngan_nhat_trong_hang_doi(List<data.Process> list,int time)
        {
            int index = 0;
            int min = 99999999;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ArrivalTime <= time)
                {
                    if (list[i].BurstTime < min)
                    {
                        index = i;
                        min = list[i].BurstTime;
                    }
                }
            }
            return index;
        }
        public static List<data.result_after_algorithm> gop__gant_lai(List<data.result_after_algorithm> list) {
            var temp = new List<result_after_algorithm> ();

            for (int i = 0; i < list.Count; i++)
            {
                var a = list[i];
                int j = i + 1;
                while (j < list.Count)
                {
                    if(a.name == list[j].name && i==0)
                    {
                        list[j].thoi_gian_bat_dau = list[0].thoi_gian_bat_dau;
                    }
                    else if(a.name != list[j].name)
                    {
                        i = j;
                        temp.Add(list[j-1]);
                        break;
                    }
                    if(j==list.Count - 1)
                    {
                        i = j;
                        temp.Add(list[j]);
                    }
                    j=j + 1;
                }
            }

            return temp;
        }
    }
}
