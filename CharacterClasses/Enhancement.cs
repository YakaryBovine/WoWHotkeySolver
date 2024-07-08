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
        Name = "Earthbind Totem",
        Frequency = Frequency.Rarely
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
        Name = "Chain Lightning",
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
        Name = "Purge/Greater Purge",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Dispel
      },
      new()
      {
        Name = "Spirit Walk/Gust of Wind",
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
        Name = "Stormstrike/Healing Surge",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Lava Lash",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Sundering",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Haymaker",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Earth Elemental",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Earth Shield",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Thunderstorm",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Totemic Projection",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Totemic Recall",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Wind Rush Totem/Earthgrab Totem",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Elemental Blast",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Ice Strike",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Primordial Wave",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Windfury Totem",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Doom Winds",
        Frequency = Frequency.Sometimes
      }
    };
    abilities.AddRange(Shared.GetAbilities());
    return abilities;
  }
}