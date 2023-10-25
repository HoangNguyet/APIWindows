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
    public static class CpFile
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);
        public static void CopyFileEX(string sourceFilePath, string destinationFolderPath)
        {
            if (Directory.Exists(destinationFolderPath))
            {
                string destinationFilePath = Path.Combine(destinationFolderPath, Path.GetFileName(sourceFilePath));

                if (CopyFile(sourceFilePath, destinationFilePath, false))
                {
                    MessageBox.Show("Tệp đã được sao chép thành công.");
                }
                else
                {
                    MessageBox.Show("Sao chép tệp thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thư mục đích không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
