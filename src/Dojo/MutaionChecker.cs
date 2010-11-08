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

            int differences = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != p_2[i])
                    differences++;
            }

            return differences == 1;

            

        }
    }
}
