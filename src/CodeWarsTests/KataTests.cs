using System;
using CodeWars;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
}