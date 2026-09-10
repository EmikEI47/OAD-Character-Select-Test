using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Knight : Entity.Character
{
    public Knight(string name) : base(name, CharacterClass.Knight)
    {
        Health = 120;
        Strength = 15;
        Intelligence = 6;
        Agility = 7;
    }

    public int Attack()
    {
        return Strength * 3;
    }

    public string SpecialAbility()
    {
        return "Sword Slash";
    }
}
