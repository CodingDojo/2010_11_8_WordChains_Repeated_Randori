using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class ChainBuilder
    {
        private MutationFinder finder = new MutationFinder(new MutationChecker());

        internal IList<string> Build(string start, string end, List<string> list)
        {
            var availableMutations = finder.GetAllMutations(start, list);

            if (availableMutations.Contains(end))
            {
                return new List<string>() { start, end };
            }

            foreach (string mutation in availableMutations)
            {
              

                var result = Build(mutation, end, list);
                if (result.Any())
                {
                    List<string> chain = new List<string>(){start};
                    chain.AddRange(result);
                    return chain;
                }
            }

            return new List<string>();


        }
    }
}
