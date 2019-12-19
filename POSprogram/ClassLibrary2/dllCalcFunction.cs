using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class dllCalcFunction
    {
        static public uint getIntNum(string num)
        {
            string t = num.Replace(",", "");
            return Convert.ToUInt32(t);
        }

        static public int getIntNumber(string num)
        {
            string t = num.Replace(",", "");
            return Convert.ToInt32(t);
        }

        static public string getCommaString(int num)
        {
            string t = string.Format("{0:#,##0}", num);
            return t;
        }

    }
}
