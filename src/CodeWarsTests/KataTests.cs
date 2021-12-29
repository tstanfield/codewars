using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace CodeWars
{

    [TestFixture]
    public class SolutionTest
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(1666, "MDCLXVI")]
        public void TestToRoman(int input, string expected)
        {                     
            string actual = RomanNumerals.ToRoman(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        [TestCase("MCMXC", 1990)]
        [TestCase("MMVIII", 2008)]
        [TestCase("MDCLXVI", 1666)]
        public void TestFromRoman(string input, int expected)
        {
            int actual = RomanNumerals.FromRoman(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
