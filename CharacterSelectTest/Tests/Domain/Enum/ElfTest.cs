using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class ElfTest
{
    [TestMethod]
    public void TestElfCreation()
    {
        var elf = new Elf("Elf");

        Assert.IsNotNull(elf);
    }

    [TestMethod]
    public void TestElfStats()
    {
        var elf = new Elf("Elf");

        Assert.AreEqual(95, elf.Health);
        Assert.AreEqual(8, elf.Strength);
        Assert.AreEqual(12, elf.Intelligence);
        Assert.AreEqual(15, elf.Agility);
    }

    [TestMethod]
    public void TestElfAttack()
    {
        var elf = new Elf("Elf");

        Assert.AreEqual(45, elf.Attack());
    }

    [TestMethod]
    public void TestElfSpecialAbility()
    {
        var elf = new Elf("Elf");

        Assert.AreEqual("Elven Shot", elf.SpecialAbility());
    }
}