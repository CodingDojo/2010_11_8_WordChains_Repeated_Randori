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
        public void ChainBuilder_ForInmutableWords_ReturnsEmptyChain()
        {
            ChainBuilder chainBuilder = new ChainBuilder();
            
            IList<string> result = chainBuilder.Build("cat","dog", new List<string>());

            Assert.That(result.Count, Is.EqualTo(0));

        }


        [Test]
        public void ChainBuilder_DictionaryWithTwoWords_ReturnsValidChain()
        {
            ChainBuilder builder = new ChainBuilder();

            var result = builder.Build("cat", "bat", new List<string>() { "cat", "bat"});

            Assert.That(result[0], Is.EqualTo("cat"));

            Assert.That(result[1], Is.EqualTo("bat"));
        }

        [Test]
        public void ChainBuilder_DictionaryWithOneValidChain_ReturnsOneValidChain()
        {
            ChainBuilder builder = new ChainBuilder();

            var result = builder.Build("cat", "cog", new List<string>() { "cat","cot","cog" });

            Assert.That(result[0], Is.EqualTo("cat"));
            Assert.That(result[1], Is.EqualTo("cot"));
            Assert.That(result[2], Is.EqualTo("cog"));
        }



    }
}
