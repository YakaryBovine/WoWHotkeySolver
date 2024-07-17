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
        Name = "Shadow Word: Pain/Vampiric Touch/Power Word: Shield",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Mind Blast/Holy Fire/Power Infusion",
        Frequency = Frequency.Constant
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
        Frequency = Frequency.Rarely,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Angelic Feather",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Mass Dispel",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Shadowfiend/Leap of Faith",
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
      },
      new()
      {
        Name = "Shadow Word: Death/Power Word: Life",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Vampiric Embrace",
        Frequency = Frequency.Sometimes
      }
    };
    return abilities;
  }
}