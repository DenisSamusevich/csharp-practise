using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_15
{
    static class stringExten
    {
        public static string StringfiveSymbol(this string stringUpdate)
        {
            string stringReturn = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                stringReturn += stringUpdate[i];
            }
            stringReturn = stringReturn + "...";
            return stringReturn;
        }
    }
}
