using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Shaman
{
  public static IEnumerable<Ability> GetAbilities()
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
        Name = "Ghost Wolf",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Movement
      },
    };
    return abilities;
  }
}