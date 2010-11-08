using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Dojo
{
    [TestFixture]
    public class ChainBuilderTest
    {
        [Test]
        public void ChainBuilder_ForTwoWords_ReturnsChainOfWords()
        {
            ChainBuilder chainBuilder = new ChainBuilder();
            
            IList<string> result = chainBuilder.Build("cat","dog");

            Assert.That(result.Count, Is.GreaterThan(1));

        }
    }
}
