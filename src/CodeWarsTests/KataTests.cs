using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace CodeWars
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("It should return correct text")]
        public void SampleTest()
        {
            Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
