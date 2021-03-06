﻿using System;
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
            MutationChecker checker = new MutationChecker();

            bool result = checker.IsMutation("cog", "cot");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsMutation_TwoWordsDifferInLength_ReturnsFalse()
        {
            MutationChecker checker = new MutationChecker();

            bool result = checker.IsMutation("asdf", "jkl");

            Assert.That(result, Is.False);
        }


        [Test]
        public void IsMutation_TwoEqualWords_ReturnsFalse()
        {
            MutationChecker checker = new MutationChecker();

            bool result = checker.IsMutation("eins", "eins");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsMutation_MoreThanOneCharacterDiffers_ReturnsFalse()
        {
            MutationChecker checker = new MutationChecker();

            bool result = checker.IsMutation("eins", "eimß");

            Assert.That(result, Is.False);
        }

    }
}
