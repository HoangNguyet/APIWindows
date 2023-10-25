using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APIWin.module
{
    public static class deteFile
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFile(string lpFileName);
        public static string deleteFileEx(string filePath)
        {
            string notify = null;
            if (DeleteFile(filePath))
            {
                notify=("File deleted successfully.");
            }
            else
            {
                int error = Marshal.GetLastWin32Error();
                notify = ("Failed to delete file. Error code: " + error);
            }
            return notify;
        }

    }
}
