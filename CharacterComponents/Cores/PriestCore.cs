using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public sealed class PriestCore : ICharacterComponent
{
  public string Name => "Priest";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Flash Heal",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.PrimaryBuilder
      },
      new()
      {
        Name = "Shadow Word: Pain",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Power Word: Shield",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Mind Blast",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.SecondaryBuilder
      },
      new()
      {
        Name = "Psychic Scream",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Stun
      },
      new()
      {
        Name = "Fade",
        Frequency = Frequency.Rarely,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Angelic Feather",
        Frequency = Frequency.Frequent,
        Type = AbilityType.Movement
      },
      new()
      {
        Name = "Mass Dispel",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Shadowfiend",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Power Infusion",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Dispel Magic",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Leap of Faith",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Mind Control/Dominate Mind",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Halo/Divine Star",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Desperate Prayer",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Shadow Word: Death",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Power Word: Life",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Vampiric Embrace",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Shackle Undead",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Silence/Purify",
        Frequency = Frequency.Frequent,
        Type = AbilityType.Interrupt
      }
    };
    abilities.AddRange(new Shared().GetAbilities());
    return abilities;
  }
}