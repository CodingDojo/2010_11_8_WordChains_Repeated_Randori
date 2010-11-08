using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class MutaionChecker
    {
        internal bool IsMutation(string p, string p_2)
        {


            if (p.Equals(p_2) || p.Length != p_2.Length)
                return false;

            return true;
        }
    }
}
