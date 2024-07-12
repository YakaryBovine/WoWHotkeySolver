using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.CharacterClasses;

public static class Priest
{
  public static List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Shadow Word: Pain",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Psychic Scream",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.Stun
      },
      new()
      {
        Name = "Fade",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Angelic Feather",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Leap of Faith",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Levitate",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Mass Dispel",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Power Infusion",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Power Word: Shield",
        Frequency = Frequency.AlmostNever
      },

      new()
      {
        Name = "Shadowfiend",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Dispel Magic",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Shackle Undead",
        Frequency = Frequency.AlmostNever
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
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.PersonalDefensive
      }
    };
    abilities.AddRange(Shared.GetAbilities());
    return abilities;
  }
}