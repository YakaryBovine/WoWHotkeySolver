using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Holy : ICharacterComponent
{
  public string Name => "Holy";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Apotheosis/Holy Word: Salvation",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Lightwell",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Symbol of Hope",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Divine Word",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Power Word: Life",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Holy Nova",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Divine Hymn",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Prayer of Healing",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Prayer of Mending",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Holy Word: Chastise/Guardian Spirit",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Holy Word: Sanctify",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Circle of Healing",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Shackle Undead/Holy Word: Serenity",
        Frequency = Frequency.Infrequent
      }
    };
    return abilities;
  }
}