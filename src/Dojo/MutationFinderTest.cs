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
            MutationFinder finder = new MutationFinder();
            List<string> result = finder.GetAllMutations("", new List<string>());

            Assert.That(result.Count, Is.EqualTo(0));

        }
    }
}
