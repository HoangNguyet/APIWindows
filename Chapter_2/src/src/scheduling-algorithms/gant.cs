using src.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.scheduling_algorithms
{
    public partial class gant : UserControl
    {
        private result_after_algorithm rl;
        private string flags;
        public gant(result_after_algorithm _rl,string _flags)
        {
            rl = _rl;
            flags = _flags;
            InitializeComponent();
        }
        private Color _cl;
        private string _tg_hoan_thanh;
        [Category("setColor")]
        public Color Cl
        {
            get { return _cl;  }
            set { _cl = value; panel1.BackColor = value; }
        }
        [Category("setTime")]
        public string Time
        {
            get { return _tg_hoan_thanh; }
            set { _tg_hoan_thanh = value; label1.Text = value; }
        }

        private void gant_Load(object sender, EventArgs e)
        {
            List<int> cl = randomColor();
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(cl[0])))), ((int)(((byte)(cl[1])))), ((int)(((byte)(cl[2])))));;
            label3.Text = rl.name;
            label2.Text = rl.thoi_gian_hoan_thanh;
            switch (flags)
            {
                case "first":
                    label1.Text = rl.thoi_gian_bat_dau;
                    break;
                default:
                    label1.Text = "";
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private List<int> randomColor()
        {
            List<int> cl = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 3; i++)
            {
                cl.Add(rd.Next(0,255));
            }
            return cl;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
