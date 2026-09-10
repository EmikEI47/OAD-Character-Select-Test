using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Witcher : Entity.Character
{
    public Witcher(string name) : base(name, CharacterClass.Witcher)
    {
        Health = 110;
        Strength = 13;
        Intelligence = 10;
        Agility = 12;
    }

    public int Attack()
    {
        return Strength * 3;
    }

    public string SpecialAbility()
    {
        return "Signs";
    }
}
