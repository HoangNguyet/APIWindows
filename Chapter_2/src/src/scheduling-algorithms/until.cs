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
    public static class until
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
    }
}
