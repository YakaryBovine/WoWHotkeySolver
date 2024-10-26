using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class HolyPaladin : ICharacterComponent
{
  public string Name => "Holy";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Holy Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Light of Dawn",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Aura Mastery",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Holy Prism/Barrier of Faith",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Hand of Divinity",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Beacon of Faith/Beacon of Virtue/Shield of the Righteous",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Avenging Wrath/Avenging Crusader",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Tyr's Deliverence",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Blessing of Summer",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Hand of Reckoning",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Divine Protection",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      }
    };
    return abilities;
  }
}