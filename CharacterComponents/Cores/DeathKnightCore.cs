using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public sealed class DeathKnightCore : ICharacterComponent
{
  public string Name => "Death Knight";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Abomination Limb",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Anti-Magic Shell",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Blinding Sleet",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Stun
      },
      new()
      {
        Name = "Chains of Ice",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Control Undead",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Death and Decay (self)",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Death and Decay (cursor)",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.AoETargeted
      },
      new()
      {
        Name = "Death Grip/Raise Ally",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Death's Advance",
        Frequency = Frequency.Frequent,
        Type = AbilityType.Movement
      },
      new()
      {
        Name = "Icebound Fortitude",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Lichborne",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Mind Freeze",
        Frequency = Frequency.Frequent,
        Type = AbilityType.Interrupt
      },
      new()
      {
        Name = "Soul Reaper",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Anti-Magic Zone",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Death Pact",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Asphyxiate",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Wraith Walk",
        Frequency = Frequency.AlmostNever
      }
    };
    abilities.AddRange(new Shared().GetAbilities());
    abilities.AddRange(new Kultiran().GetAbilities()); 
    return abilities;
  }
}