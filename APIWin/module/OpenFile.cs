using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIWin.module
{
    public static class OpenFile
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
        public static void OpenFileEX(string filePath)
        {
            if (File.Exists(filePath))
            {
                ShellExecute(IntPtr.Zero, "open", filePath, null, null, 1);
            }
            else
            {
                MessageBox.Show("Tệp không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
