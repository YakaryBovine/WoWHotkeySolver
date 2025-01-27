using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Druid;

public sealed class Restoration : ICharacterComponent
{
  public string Name => "Restoration";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Lifebloom",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Rejuvenation",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.PrimaryBuilder
      },
      new()
      {
        Name = "Regrowth",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.SecondaryBuilder
      },
      new()
      {
        Name = "Starfire",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.SecondaryBuilder,
        Child = new Ability
        {
          Name = "Rake (Fluid Form)",
          Frequency = Frequency.Constant,
          Slot = AbilitySlot.Hostile
        }
      },
      new()
      {
        Name = "Wrath",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.PrimaryBuilder,
        Child = new Ability
        {
          Name = "Shred (Fluid Form)",
          Frequency = Frequency.Constant,
          Slot = AbilitySlot.Hostile
        }
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
        Name = "Wild Growth",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Swiftmend",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Ironbark",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ExternalDefensive,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Cenarion Ward",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Flourish",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Tranquility",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Nature's Swiftness",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Grove Guardians/Nourish",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Overgrowth",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Invigorate",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Efflorescence",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Skull Bash",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Incarnation/Convoke the Spirits",
        Frequency = Frequency.Rarely,
        Type = AbilityType.ShortPrimaryCooldown
      },
    };
    return abilities;
  }
}