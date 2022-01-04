using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace CodeWars
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void KataTest()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
            Assert.AreEqual("elloHay orldway !", Kata.PigIt("Hello world !"));
        }
    }
}
