﻿using System;
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
            List<string> result = finder.GetAllMutations("", new List<string>());

            Assert.That(result.Count, Is.EqualTo(0));

        }

        [Test]
        public void GetAllMuations_NotEmptyDictionary_MutationCheckerIsCalled()
        {
            var checker = new MutationCheckerAlwaysFalse();
            MutationFinder finder = new MutationFinder(checker);
            
            List<string> result = finder.GetAllMutations("cat", new List<string> { "hello", "eins" });

            Assert.That(checker.WasCalled, Is.True);
        }

        [Test]
        public void GetAllMutations_ForDictionaryOfValidMutations_ReturnAllElements()
        {
            var checker = new MutationCheckerAlwaysTrue();
            MutationFinder finder = new MutationFinder(checker);
            var sourceDict = new List<string> { "cot", "bat" };
            List<string> result = finder.GetAllMutations("cat", sourceDict);

            Assert.That(result.Count, Is.EqualTo(sourceDict.Count));
        }
    }
}
