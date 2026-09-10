using CharacterSelectTest.Domain.Character;

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

        Assert.AreEqual(95, witcher.Health);
        Assert.AreEqual(9, witcher.Strength);
        Assert.AreEqual(8, witcher.Intelligence);
        Assert.AreEqual(15, witcher.Agility);
    }

    [TestMethod]
    public void TestWitcherAttack()
    {
        var witcher = new Witcher("Witcher");

        Assert.AreEqual(45, witcher.Attack());
    }

    [TestMethod]
    public void TestWitcherSpecialAbility()
    {
        var witcher = new Witcher("Witcher");

        Assert.AreEqual("Signs", witcher.SpecialAbility());
    }
}
