using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo
{
    class MutaionChecker : Dojo.IMutationChecker
    {
        public bool IsMutation(string word1, string word2)
        {

            if (word1.Equals(word2) || word1.Length != word2.Length)
                return false;

            int differences = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                    differences++;
            }

            return differences == 1;

            

        }
    }
}
