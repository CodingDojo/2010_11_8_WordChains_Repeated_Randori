using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class ChainBuilder
    {
        internal IList<string> Build(string p, string p_2)
        {
            return new List<string>() { "cat", "dog"};
        }
    }
}
