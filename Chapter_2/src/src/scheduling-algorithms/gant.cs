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
        public gant()
        {
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
    }
}
