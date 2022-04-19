using System.Collections.Generic;
using NUnit.Framework;

namespace Anagram.Test
{
    public class AnagramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NoCharacters()
        {
            var expected = new List<string> { "" };
            Assert.That(Anagrams.Of(""), Is.EqualTo(expected));
        }
    }
}