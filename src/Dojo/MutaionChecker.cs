﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class MutaionChecker
    {
        internal bool IsMutation(string p, string p_2)
        {
            if (p.Equals(p_2))
                return false;
            return p.Length == p_2.Length;
        }
    }
}
