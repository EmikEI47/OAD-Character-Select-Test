using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Elf : Entity.Character
{
    public Elf(string name) : base(name, CharacterClass.Elf)
    {
        Health = 95;
        Strength = 8;
        Intelligence = 12;
        Agility = 15;
    }

    public int Attack()
    {
        return Agility * 3;
    }

    public string SpecialAbility()
    {
        return "Elven Shot";
    }
}
