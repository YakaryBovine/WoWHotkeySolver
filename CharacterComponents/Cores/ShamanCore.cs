using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public sealed class ShamanCore : ICharacterComponent
{
  public string Name => "Shaman";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Ancestral Guidance",
        Frequency = Frequency.Rarely,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Astral Shift",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Capacitor Totem",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Stun
      },
      new()
      {
        Name = "Earthbind Totem",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Earth Elemental",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Earth Shield",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Thunderstorm",
        Frequency = Frequency.Infrequent
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
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Spirit Walk/Gust of Wind",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Wind Shear/Cleanse Spirit",
        Frequency = Frequency.Infrequent,
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
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Ghost Wolf",
        Frequency = Frequency.Infrequent
      },
    };
    abilities.AddRange(new Shared().GetAbilities());
    abilities.AddRange(new Kultiran().GetAbilities());
    return abilities;
  }
}