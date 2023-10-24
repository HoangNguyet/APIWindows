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
            List<WIN32_FIND_DATA> temp = new List<WIN32_FIND_DATA>();
            WIN32_FIND_DATA findData;
            WIN32_FIND_DATA findData1;

            FINDEX_INFO_LEVELS findInfoLevel = FINDEX_INFO_LEVELS.FindExInfoBasic;
            FINDEX_INFO_LEVELS findInfoLevel1 = FINDEX_INFO_LEVELS.FindExInfoBasic;

            int additionalFlags = 0;


            string pattern = $"{path}\\*.*";
            string pattern1 = $"{path}\\*.";


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
                    fileContaner.Add(findData);

                }
                while (FindNextFile(hFile, out findData));

            }
            IntPtr hFile1 = FindFirstFileEx(
            pattern1,
            findInfoLevel1,
            out findData1,
            FINDEX_SEARCH_OPS.FindExSearchNameMatch,
            IntPtr.Zero,
            additionalFlags);
            if (hFile1.ToInt32() != -1)
            {
                do
                {
                    temp.Add(findData1);

                }
                while (FindNextFile(hFile1, out findData1));

            }
            for (int i = 0; i < fileContaner.Count; i++)
            {
                foreach (var item in temp)
                {
                    if (fileContaner[i].cFileName == item.cFileName)
                    {
                        fileContaner.RemoveAt(i);
                    }
                }
            }
            return fileContaner;
        }
    }
}
