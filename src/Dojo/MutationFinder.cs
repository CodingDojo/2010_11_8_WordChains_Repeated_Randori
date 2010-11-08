using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class MutationFinder
    {
        private IMutationChecker checker;

        public MutationFinder(IMutationChecker checker)
        {
            // TODO: Complete member initialization
            this.checker = checker;
        }

        internal List<string> GetAllMutations(string p, List<string> list)
        {
            checker.IsMutation("aa", "bb");
            return list;
        }
    }
}
