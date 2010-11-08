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
            this.checker = checker;
        }

        internal List<string> GetAllMutations(string p, List<string> list)
        {
            return list.Where(s => checker.IsMutation(p, s)).ToList();
        }
    }
}
