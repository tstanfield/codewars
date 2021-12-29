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
        public void FixedTest()
        {
            Assert.That(Kata.Lcm(new List<int> { }), Is.EqualTo(1));            
            Assert.That(Kata.Lcm(new List<int> { 1071, 462 }), Is.EqualTo(23562));
            Assert.That(Kata.Lcm(new List<int> { 2, 5 }), Is.EqualTo(10));
            Assert.That(Kata.Lcm(new List<int> { 2, 3, 4 }), Is.EqualTo(12));
            Assert.That(Kata.Lcm(new List<int> { 9 }), Is.EqualTo(9));
        }
    }
}
