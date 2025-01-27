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
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.PrimaryBuilder,
        Child = new Ability
        {
          Name = "Mangle (Fluid Form)",
          Frequency = Frequency.Constant,
          Slot = AbilitySlot.Hostile
        }
      },
      new()
      {
        Name = "Rake",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.SecondaryBuilder,
        Child = new Ability
        {
          Name = "Thrash (Fluid Form)",
          Frequency = Frequency.Constant,
          Slot = AbilitySlot.Hostile
        }
      },
      new()
      {
        Name = "Rip",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Ferocious Bite",
        Frequency = Frequency.Frequent,
        Type = AbilityType.MainSpender,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Primal Wrath",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Swipe",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Thrash",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Tiger's Fury",
        Frequency = Frequency.Semifrequent
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
        Name = "Feral Frenzy",
        Frequency = Frequency.Infrequent,
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
        Name = "Adaptive Swarm",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      }
    };
    return abilities;
  }
}