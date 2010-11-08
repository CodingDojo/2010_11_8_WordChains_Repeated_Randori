using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class MutationCheckerTest
    {
        [Test]
        public void IsMutation_IsValidMutation_ReturnsTrue()
        {
            MutaionChecker checker = new MutaionChecker();

            bool result = checker.IsMutation("cog", "cot");

            Assert.That(result, Is.True);
        }
    }
}
