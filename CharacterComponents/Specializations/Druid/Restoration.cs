﻿using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

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
        Name = "Wild Growth",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Swiftmend",
        Frequency = Frequency.Frequent,
        Type = AbilityType.MainSpender,
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
        Name = "Efflorescence",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Skull Bash",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Hostile
      }
    };
    return abilities;
  }
}