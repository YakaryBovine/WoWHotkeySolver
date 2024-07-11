using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class DeathKnight
{
    public static List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Raise Ally",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Abomination Limb",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Anti-Magic Shell",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Blinding Sleet",
        Frequency = Frequency.Sometimes,
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
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Death Grip",
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
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Icebound Fortitude",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Lichborne",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Mind Freeze",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Interrupt
      },
      new()
      {
        Name = "Raise Ally",
        Frequency = Frequency.Sometimes
      }
    };
    abilities.AddRange(Shared.GetAbilities());
    return abilities;
  }
}