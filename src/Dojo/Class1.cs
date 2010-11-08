using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class MutationCheckerAlwaysFalse : IMutationChecker
    {
        public bool WasCalled = false;

        #region IMutationChecker Members

        

        public bool IsMutation(string word1, string word2)
        {
            WasCalled = true;
            return false;
        }

        #endregion
    }
}
