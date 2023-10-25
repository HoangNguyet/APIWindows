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
using Microsoft.Win32.SafeHandles;
using APIWin;
using System.Diagnostics;
using APIWin.module;
using static APIWin.module.WIN32_DATA;

namespace APIWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = TxTPath.Text;
            List<listString.StringValue> list = new List<listString.StringValue>();
            List<WIN32_FIND_DATA> fileContaner = new List<WIN32_FIND_DATA>();
            fileContaner = SearchFile.getFile(path);
            foreach(var item in  fileContaner)
            {
                listString.StringValue temp = new listString.StringValue(item.cFileName);
                list.Add(temp);
            }
            data.DataSource = list;
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string nameFile = data.Rows[index].Cells[0].Value.ToString();
            String pathName = TxTPath.Text +"\\"+ nameFile;
            OpenFile.OpenFileEX(pathName);
        }
    }
}
