using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class WitcherTest
{
    [TestMethod]
    public void TestWitcherCreation()
    {
        var witcher = new Witcher("Witcher");

        Assert.IsNotNull(witcher);
    }

    [TestMethod]
    public void TestWitcherStats()
    {
        var witcher = new Witcher("Witcher");

        Assert.AreEqual(110, witcher.Health);
        Assert.AreEqual(13, witcher.Strength);
        Assert.AreEqual(10, witcher.Intelligence);
        Assert.AreEqual(12, witcher.Agility);
    }

    [TestMethod]
    public void TestWitcherAttack()
    {
        var witcher = new Witcher("Witcher");

        Assert.AreEqual(39, witcher.Attack());
    }

    [TestMethod]
    public void TestWitcherSpecialAbility()
    {
        var witcher = new Witcher("Witcher");

        Assert.AreEqual("Signs", witcher.SpecialAbility());
    }
}
