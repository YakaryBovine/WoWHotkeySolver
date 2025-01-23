using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Druid;

public sealed class CatForm : ICharacterComponent
{
  public string Name => "Cat Form";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Shred",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Rake",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Rip",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Ferocious Bite",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.MainSpender
      },
      new()
      {
        Name = "Primal Wrath",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Swipe",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Thrash",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Tiger's Fury",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Convoke",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Feral Frenzy",
        Frequency = Frequency.Infrequent
      },
    };
    return abilities;
  }
}