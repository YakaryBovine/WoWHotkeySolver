using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.CharacterClasses;

public static class Enhancement
{
  public static List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Ancestral Guidance",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Astral Shift",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Capacitor Totem",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.Stun
      },
      new()
      {
        Name = "Chain Lightning",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Earthbind Totem",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Flame Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Frost Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Ghost Wolf",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Healing Surge",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Healing Stream Totem",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Heroism",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Hex",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Lightning Bolt",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Purge",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Dispel
      },
      new()
      {
        Name = "Spirit Walk",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Wind Shear",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.Interrupt
      },
      new()
      {
        Name = "Crash Lightning",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Feral Spirit",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Lava Lash",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Storm Strike",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Sundering",
        Frequency = Frequency.Sometimes
      }
    };
    abilities.AddRange(Shared.GetAbilities());
    return abilities;
  }
}