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
    public static class RenameFileP
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFile(string lpExistingFileName, string lpNewFileName);
        public static void RenameFile(string sourceFilePath, string newFileName)
        {
            if (File.Exists(sourceFilePath))
            {
                string directory = Path.GetDirectoryName(sourceFilePath);
                string newFilePath = Path.Combine(directory, newFileName);

                if (MoveFile(sourceFilePath, newFilePath))
                {
                    MessageBox.Show("Tệp đã được đổi tên thành công.");
                }
                else
                {
                    MessageBox.Show("Đổi tên tệp thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tệp nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
