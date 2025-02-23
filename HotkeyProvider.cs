using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver;

public static class HotkeyProvider
{
  public static List<Hotkey> GetAllHotkeys()
  {
    return new List<Hotkey>
    {
      new()
      {
        Key = "q",
        Convenience = Convenience.Staple,
        ReservedForAbilityType = AbilityType.SecondaryBuilder
      },
      new()
      {
        Key = "e",
        Convenience = Convenience.Staple,
        ReservedForAbilityType = AbilityType.PrimaryBuilder
      },
      new()
      {
        Key = "1",
        Convenience = Convenience.Average
      },
      new()
      {
        Key = "2",
        Convenience = Convenience.Average
      },
      new()
      {
        Key = "3",
        Convenience = Convenience.Average,
        ReservedForAbilityType = AbilityType.Form1
      },
      new()
      {
        Key = "4",
        Convenience = Convenience.Average,
        ReservedForAbilityType = AbilityType.Form2
      },
      new()
      {
        Key = "5",
        Convenience = Convenience.Bad,
        ReservedForAbilityType = AbilityType.Movement
      },
      new()
      {
        Key = "f",
        Convenience = Convenience.Good,
        ReservedForAbilityType = AbilityType.Taunt
      },
      new()
      {
        Key = "r",
        Convenience = Convenience.Incredible
      },
      new()
      {
        Key = "c",
        Convenience = Convenience.Incredible,
        ReservedForAbilityType = AbilityType.MainSpender
      },
      new()
      {
        Key = "v",
        Convenience = Convenience.Incredible,
        ReservedForAbilityType = AbilityType.Interrupt
      },
      new()
      {
        Key = "g",
        Convenience = Convenience.Average,
        ReservedForAbilityType = AbilityType.AoE,
        AllowShiftModifier = false
      },
      new()
      {
        Key = "z",
        Convenience = Convenience.Good
      },
      new()
      {
        Key = "x",
        Convenience = Convenience.Bad,
        ReservedForAbilityType = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Key = "b",
        Convenience = Convenience.Average,
        ReservedForAbilityType = AbilityType.Stun
      },
      new()
      {
        Key = "t",
        Convenience = Convenience.Average,
        ReservedForAbilityType = AbilityType.ExternalDefensive
      },
      new()
      {
        Key = "`",
        Convenience = Convenience.Atrocious,
        AllowShiftModifier = false,
        ReservedForAbilityType = AbilityType.Trinket
      },
      new()
      {
        Key = "1",
        Modifier = Modifier.Control,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.PersonalDefensive,
      },
      new()
      {
        Key = "2",
        Modifier = Modifier.Control,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.PersonalDefensive,
      },
      new()
      {
        Key = "3",
        Modifier = Modifier.Control,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.PersonalDefensive,
      },
      new()
      {
        Key = "4",
        Modifier = Modifier.Control,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.HealingPotion,
      },
      new()
      {
        Key = "5",
        Modifier = Modifier.Control,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.Healthstone,
      },
      new()
      {
        Key = "6",
        Modifier = Modifier.Control,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.CombatPotion,
      },
      new()
      {
        Key = "`",
        Modifier = Modifier.Shift,
        Convenience = Convenience.Bad,
        ReservedForAbilityType = AbilityType.OpieMenu,
      },
      new()
      {
        Key = "g",
        Modifier = Modifier.Shift,
        Convenience = Convenience.Atrocious,
        ReservedForAbilityType = AbilityType.AoETargeted,
      },
      new()
      {
        Key = "h",
        Convenience = Convenience.Bad
      },
    };
  }
}