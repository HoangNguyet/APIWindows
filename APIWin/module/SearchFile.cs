using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APIWin.module.WIN32_DATA;

namespace APIWin.module
{
    public static class SearchFile
    {
        public static List<WIN32_FIND_DATA> getFile(string path)
        {
            List<WIN32_FIND_DATA> fileContaner = new List<WIN32_FIND_DATA>();
            WIN32_FIND_DATA findData;

            FINDEX_INFO_LEVELS findInfoLevel = FINDEX_INFO_LEVELS.FindExInfoBasic;

            int additionalFlags = 0;


            string pattern = $"{path}\\*.*";


            IntPtr hFile = FindFirstFileEx(
            pattern,
            findInfoLevel,
            out findData,
            FINDEX_SEARCH_OPS.FindExSearchNameMatch,
            IntPtr.Zero,
            additionalFlags);
            if (hFile.ToInt32() != -1)
            {
                do
                {
                    if ((findData.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) == 0)
                    {
                        fileContaner.Add(findData);
                    }

                }
                while (FindNextFile(hFile, out findData));

            }
            return fileContaner;
        }
    }
}
