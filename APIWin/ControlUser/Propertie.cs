using APIWin.module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIWin.ControlUser
{
    public partial class Propertie : Form
    {
        private string _name = String.Empty;
        WIN32_DATA.WIN32_FIND_DATA _file = new WIN32_DATA.WIN32_FIND_DATA();
        string _namePath;
        public Propertie(string name,WIN32_DATA.WIN32_FIND_DATA file,string namePath)
        {
            InitializeComponent();
            _name = name;
            _file = file;
            _namePath = namePath;
        }

        private void Propertie_Load(object sender, EventArgs e)
        {
            this.Text = _name;
            string sizeZ = null;
            double s = _file.nFileSizeLow;
            if(s> 1024)
            {
                sizeZ = ((Math.Round(s / 1024,1)).ToString() + " KB (") + s.ToString() + " bytes)"; ;
            }
            else
            {
                sizeZ = (s.ToString() + " bytes (") + s.ToString() + " bytes)"; ;
            }
            nameFile.Text = _file.cFileName;
            path.Text = _namePath;
            SizeX.Text = sizeZ;
            DateTime dt = new DateTime();
            DateTime d = ConvertsFileTime.getTime(_file.ftCreationTime);
            DateTime dAccessed = ConvertsFileTime.getTime(_file.ftLastAccessTime);
            if (d == dt)
            {
                CreatedX.Text = "";
                AccassedX.Text = "";
            }
            else
            {
                CreatedX.Text = d.ToString();
                AccassedX.Text=dAccessed.ToString();
            }
        }
    }
}
