using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Druid;

public sealed class Balance : ICharacterComponent
{
  public string Name => "Balance";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Starfire",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Wrath",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Rejuvenation",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Regrowth",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Sunfire",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Starsurge",
        Frequency = Frequency.Frequent,
        Type = AbilityType.MainSpender,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Starfall",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Solar Beam",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Celestial Alignment",
        Frequency = Frequency.Rarely,
        Type = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Convoke the Spirits",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Flap",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Force of Nature/Warrior of Elune",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Stellar Flare",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "New Moon",
        Frequency = Frequency.Semifrequent
      }
    };
    return abilities;
  }
}