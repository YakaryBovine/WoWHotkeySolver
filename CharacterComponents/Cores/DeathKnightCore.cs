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
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Blinding Sleet",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Stun
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
        Name = "Death and Decay",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.AoE
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
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Empower Rune Weapon/Raise Dead",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Icebound Fortitude",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Lichborne",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Anti-Magic Shell",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Mind Freeze",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Interrupt
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
    };
    abilities.AddRange(new Shared().GetAbilities());
    abilities.AddRange(new Kultiran().GetAbilities()); 
    return abilities;
  }
}