using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace APIWin.module
{
    public static class ConvertsFileTime
    {
        public static DateTime getTime(System.Runtime.InteropServices.ComTypes.FILETIME file)
        {
            DateTime dt = new DateTime();
            long lowDateTime = file.dwLowDateTime;
            long highDateTime = file.dwHighDateTime;

            long longDate =  (highDateTime << 32) | lowDateTime;

            try
            {
                dt = DateTime.FromFileTime(longDate);
            }
            catch
            {
                
            }
            return dt;
        }
    }
}
