using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class MutationFinderTest
    {
        [Test]
        public void GetAllMutations_EmptyDictionary_ReturnsEmptyResult()
        {
            MutationFinder finder = new MutationFinder(new MutationCheckerAlwaysFalse());
            IEnumerable<string> result = finder.GetAllMutations("", new List<string>());

            Assert.That(result.ToList().Count, Is.EqualTo(0));

        }

        [Test]
        public void GetAllMuations_NotEmptyDictionary_MutationCheckerIsCalled()
        {
            var checker = new MutationCheckerAlwaysFalse();
            MutationFinder finder = new MutationFinder(checker);

            IEnumerable<string> result = finder.GetAllMutations("cat", new List<string> { "hello", "eins" });

            Assert.That(checker.WasCalled, Is.True);
        }

        [Test]
        public void GetAllMutations_ForDictionaryOfValidMutations_ReturnAllElements()
        {
            var checker = new MutationCheckerAlwaysTrue();
            MutationFinder finder = new MutationFinder(checker);
            var sourceDict = new List<string> { "cot", "bat" };
            IEnumerable<string> result = finder.GetAllMutations("cat", sourceDict);

            Assert.That(result.ToList().Count, Is.EqualTo(sourceDict.Count));
        }

        [Test]
        public void GetAllMutations_ForDictionaryOfInValidMutations_ReturnNoElements()
        {
            var checker = new MutationCheckerAlwaysFalse();
            MutationFinder finder = new MutationFinder(checker);
            var sourceDict = new List<string> { "cot", "bat" };
            IEnumerable<string> result = finder.GetAllMutations("cat", sourceDict);

            Assert.That(result.ToList().Count, Is.EqualTo(0));
        }

        [Test(Description="Integrationtest")]
        public void GetAllMutations_ForDictionaryWithTenElementsAndThreeValidMutations_ReturnThreeElements()
        {
            var checker = new MutationChecker();
            MutationFinder finder = new MutationFinder(checker);
            var sourceDict = new List<string> { "cot", "bat", "fat", "aaa", "bbb", "ccc", "ddd", "eee", "fff", "xxx" };
            IEnumerable<string> result = finder.GetAllMutations("cat", sourceDict);

            Assert.That(result.ToList().Count, Is.EqualTo(3));
        }

    }
}
