using System;
namespace Dojo
{
    interface IMutationChecker
    {
        bool IsMutation(string word1, string word2);
    }
}
