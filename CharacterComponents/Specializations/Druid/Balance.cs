using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Balance : ICharacterComponent
{
  public string Name => "Balance";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Wrath",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Starfire",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Sunfire",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Starsurge",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.MainSpender
      },
      new()
      {
        Name = "Starfall",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
    };
    return abilities;
  }
}