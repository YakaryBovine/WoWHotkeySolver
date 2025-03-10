﻿using WoWHotkeySolver.Enums;
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
        Frequency = Frequency.Constant,
        Type = AbilityType.SecondaryBuilder,
        Slot = AbilitySlot.Hostile,
        Child = new Ability
        {
          Name = "Rake (Fluid Form)",
          Frequency = Frequency.Constant
        }
      },
      new()
      {
        Name = "Mangle",
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
        Name = "Ironfur",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Swipe",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Growl",
        Frequency = Frequency.Semifrequent,
        Type = AbilityType.Taunt,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Maul",
        Frequency = Frequency.Constant,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Raze",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
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
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.SecondaryBuilder
      },
      new()
      {
        Name = "Pulverize",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Rage of the Sleeper",
        Frequency = Frequency.Semifrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Lunar Beam",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Survival Instincts",
        Frequency = Frequency.Rarely,
        Type = AbilityType.PersonalDefensive
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
        Name = "Berserk",
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
        Name = "Frenzied Regeneration",
        Frequency = Frequency.Frequent
      },
    };
    return abilities;
  }
}