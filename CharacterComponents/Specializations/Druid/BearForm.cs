using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Druid;

public sealed class BearForm : ICharacterComponent
{
  public string Name => "Guardian";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Thrash",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Mangle",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Ironfur",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Swipe",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Growl",
        Frequency = Frequency.Semifrequent,
        AbilityType = AbilityType.Taunt
      },
      new()
      {
        Name = "Maul",
        Frequency = Frequency.Constant,
        AbilityType = AbilityType.MainSpender
      },
      new()
      {
        Name = "Regrowth",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Pulverize",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Rage of the Sleeper",
        Frequency = Frequency.Semifrequent,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Lunar Beam",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Infrequent
      },
    };
    return abilities;
  }
}