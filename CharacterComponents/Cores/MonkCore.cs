using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public class MonkCore : ICharacterComponent
{
  public string Name => "Monk";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Diffuse Magic",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Blackout Kick",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Expel Harm",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Fortifying Brew",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Dampen Harm",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Leg Sweep",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Stun
      },
      new()
      {
        Name = "Paralysis",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Resuscitate",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Dead
      },
      new()
      {
        Name = "Ring of Peace/Song of Chi'ji",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Rising Sun Kick",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Roll/Chi Torpedo",
        Frequency = Frequency.Frequent,
        Type = AbilityType.Movement
      },
      new()
      {
        Name = "Spear Hand Strike",
        Frequency = Frequency.Frequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Spinning Crane Kick",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Tiger Palm",
        Frequency = Frequency.Constant,
        Type = AbilityType.PrimaryBuilder,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Tiger's Lust",
        Frequency = Frequency.Rarely,
        Type = AbilityType.Movement,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Touch of Death",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Transcendence",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Transcendence: Transfer",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Vivify",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.PrimaryBuilder
      },
      new()
      {
        Name = "Detox",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.Interrupt
      },
      new()
      {
        Name = "Invoke Celestial",
        Frequency = Frequency.Rarely
      },
    };
    abilities.AddRange(new Shared().GetAbilities());
    return abilities;
  }
}