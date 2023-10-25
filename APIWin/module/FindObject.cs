using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace APIWin.module
{
    public  class FindObject
    {
        public static WIN32_DATA.WIN32_FIND_DATA getFileX(List<WIN32_DATA.WIN32_FIND_DATA> Files,string nameFile)
        {
            WIN32_DATA.WIN32_FIND_DATA file = new WIN32_DATA.WIN32_FIND_DATA();
            Files.ForEach(x =>
            {
                if(x.cFileName == nameFile)
                {
                    file = x;
                    return;
                }

            });
            return file;
        }
    }
}
