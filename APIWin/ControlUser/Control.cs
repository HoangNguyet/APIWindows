using APIWin.module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using APIWin.data;
using System.IO;

namespace APIWin.ControlUser
{
    public partial class Control : Form
    {
        private WIN32_DATA.WIN32_FIND_DATA _dataProperties = new WIN32_DATA.WIN32_FIND_DATA();
        private string _name =string.Empty;
        private string _namePath;
        public Control(string name,WIN32_DATA.WIN32_FIND_DATA dataProperties,string namePath)
        {
            InitializeComponent();
            _dataProperties = dataProperties;
            _name = name;
            _namePath = namePath;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Properti_Load(object sender, EventArgs e)
        {
            this.Text = "Control "+_name;
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Propertie pr = new Propertie(_name, _dataProperties,_namePath))
            {
                pr.ShowDialog();
            }
        }

        private void deleteFileX_Click(object sender, EventArgs e)
        {
            String notify = deteFile.deleteFileEx(_namePath);
            MessageBox.Show(notify);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            String PathFto = Interaction.InputBox("Copy to");
            if (PathFto != "")
            {
                CpFile.CopyFileEX(_namePath, PathFto);
            }
        }

        private void cp_Click(object sender, EventArgs e)
        {
            this.Close();
            PAThFileCp.pathFile = _namePath;
        }
    }
}
