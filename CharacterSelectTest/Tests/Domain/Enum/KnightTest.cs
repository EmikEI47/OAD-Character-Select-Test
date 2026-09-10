using CharacterSelectTest.Domain.Character;

[TestClass]
public class KnightTest
{
    [TestMethod]
    public void TestKnightCreation()
    {
        var knight = new Knight("Knight");

        Assert.IsNotNull(knight);
    }

    [TestMethod]
    public void TestKnightStats()
    {
        var knight = new Knight("Knight");

        Assert.AreEqual(120, knight.Health);
        Assert.AreEqual(15, knight.Strength);
        Assert.AreEqual(6, knight.Intelligence);
        Assert.AreEqual(7, knight.Agility);
    }

    [TestMethod]
    public void TestKnightAttack()
    {
        var knight = new Knight("Knight");

        Assert.AreEqual(45, knight.Attack());
    }

    [TestMethod]
    public void TestKnightSpecialAbility()
    {
        var knight = new Knight("Knight");

        Assert.AreEqual("Sword Slash", knight.SpecialAbility());
    }
}