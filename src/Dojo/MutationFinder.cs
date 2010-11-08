using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class MutationFinder
    {
        private MutationCheckerAlwaysFalse checker;

        public MutationFinder(MutationCheckerAlwaysFalse checker)
        {
            // TODO: Complete member initialization
            this.checker = checker;
        }
        internal List<string> GetAllMutations(string p, List<string> list)
        {
            return new List<string>();
        }
    }
}
