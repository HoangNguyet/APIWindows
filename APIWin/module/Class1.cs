using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APIWin.module
{
    internal class Class1
    {
        [DllImport("kernel32.dll",
           CharSet = CharSet.Unicode,
           CallingConvention = CallingConvention.StdCall,
           SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(
                   [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName,
                   [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName,
                   [MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);
    }
}
