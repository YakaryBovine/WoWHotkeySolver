using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public class DruidCore : ICharacterComponent
{
  public string Name => "Druid";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Dash",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Wild Charge",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Movement
      },
      new()
      {
        Name = "Nature's Cure",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Barkskin",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Innervate",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Entangling Roots",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Cyclone",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Typhoon",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Incapacitating Roar/Mighty Bash",
        Frequency = Frequency.Rarely,
        Type = AbilityType.Stun,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Renewal",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Ursol's Vortex",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Stampeding Roar",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Soothe",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Hibernate",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Prowl",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Nature's Vigil",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Shadowmeld",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Rebirth",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Dead
      },
      new()
      {
        Name = "Revive",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Dead
      },
      new()
      {
        Name = "Mass Resurrection",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Dead
      },
    };
    abilities.AddRange(new Shared().GetAbilities());
    return abilities;
  }
}