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
using APIWin.ControlUser;

namespace APIWin
{
    public partial class Form1 : Form
    {
        private List<WIN32_FIND_DATA> fileContaner = new List<WIN32_FIND_DATA>();
        private string pathName;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = TxTPath.Text;
            pathName += path;
            List<listString.StringValue> list = new List<listString.StringValue>();
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
            string pathN = pathName +"\\"+ nameFile;
            OpenFile.OpenFileEX(pathN);
        }
        public static long ConvertFileTimeToLong(System.Runtime.InteropServices.ComTypes.FILETIME fileTime)
        {
            long lowDateTime = fileTime.dwLowDateTime;
            long highDateTime = fileTime.dwHighDateTime;

            return (highDateTime << 32) | lowDateTime;
        }
        private void data_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int index = e.RowIndex;
                string nameFile = data.Rows[index].Cells[0].Value.ToString();
                string pathN= pathName +"\\"+ nameFile;
                WIN32_FIND_DATA file = FindObject.getFileX(fileContaner, nameFile);
                using(ControlUser.Control pr = new ControlUser.Control(nameFile,file,pathN))
                {
                    pr.ShowDialog();
                }
            }
        }
    }
}
