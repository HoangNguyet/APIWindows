using APIWin.data;
using APIWin.module;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIWin.ControlUser
{
    public partial class ControlFolder : Form
    {
        private string _PathFto;
        public ControlFolder(string pathFto)
        {
            InitializeComponent();
            _PathFto = pathFto;
        }

        private void ControlFolder_Load(object sender, EventArgs e)
        {
            if(PAThFileCp.pathFile == "" || PAThFileCp.pathFile == null)
            {
                PasteX.Enabled = false;
            }
            else
            {
                PasteX.Enabled=true;
            }
        }

        private void PasteX_Click(object sender, EventArgs e)
        {
            this.Hide();
            CpFile.CopyFileEX(PAThFileCp.pathFile, _PathFto);
        }

        private void CreateFileX_Click(object sender, EventArgs e)
        {
            this.Hide();
            String newFile = Interaction.InputBox("Create File");
            CreateFil.CreateFile(_PathFto, newFile);

        }
    }
}
