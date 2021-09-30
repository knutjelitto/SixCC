using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.GT
{
    internal static class Txt
    {
        public static int txtcasecmp(string t1, string t2)
        {
            return string.Compare(t1, t2, true);
        }
        public static int txtcmp(string t1, string t2)
        {
            return string.Compare(t1, t2, false);
        }
    }
}
