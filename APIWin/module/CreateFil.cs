using Microsoft.Win32.SafeHandles;
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
    public static class CreateFil
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct CreateFileArgs
        {
            public

        string InFileName;
            public UInt32 InDesiredAccess;
            public UInt32 InShareMode;
            public IntPtr InSecurityAttributes;
            public UInt32 InCreationDisposition;
            public UInt32 InFlagsAndAttributes;
            public IntPtr InTemplateFile;
        }

        [DllImport("kernel32.dll",
            CharSet = CharSet.Unicode,
            SetLastError = true,
            CallingConvention = CallingConvention.StdCall)]
        public

        static

        extern IntPtr CreateFile(
            [MarshalAs(UnmanagedType.LPWStr)] string InFileName,
            UInt32 InDesiredAccess,
            UInt32 InShareMode,
            IntPtr InSecurityAttributes,
            UInt32 InCreationDisposition,
            UInt32 InFlagsAndAttributes,
            IntPtr InTemplateFile);

        public static void CreateFile(string path,string nameFile)
        {
            CreateFileArgs args = new CreateFileArgs();
            args.InFileName = Path.Combine(path, nameFile);
            args.InDesiredAccess = 0;
            args.InShareMode = 0;
            args.InCreationDisposition = 1;
            args.InTemplateFile = IntPtr.Zero;

            try
            {
                IntPtr handle = CreateFile(args.InFileName, args.InDesiredAccess, args.InShareMode, args.InSecurityAttributes, args.InCreationDisposition, args.InFlagsAndAttributes , args.InTemplateFile);
                MessageBox.Show("Tạo file thành công");
            }
            catch
            {
                MessageBox.Show("Tạo file thất bại");
            }
        }

    }
}
