using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Specializations;

public sealed class Holy : ISpecialization
{
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
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Power Word: Life",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Renew",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Guardian Spirit",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.ExternalDefensive
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
        Name = "Purify",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Dispel
      },
      new()
      {
        Name = "Holy Word: Serenity",
        Frequency = Frequency.Sometimes
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
        Name = "Holy Fire",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Holy Word: Chastise",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Holy Word: Sanctify",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Circle of Healing",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Smite",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Flash Heal",
        Frequency = Frequency.Constant
      },
    };
    abilities.AddRange(Priest.GetAbilities());
    return abilities;
  }
}