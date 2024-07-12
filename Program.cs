using WoWHotkeySolver;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Services;
using WoWHotkeySolver.Specializations;

var solverService = new SolverService
{
  Abilities = Shadow.GetAbilities(),
  Hotkeys = new List<Hotkey>
  {
    new()
    {
      Key = "q",
      Convenience = Convenience.Staple
    },
    new()
    {
      Key = "e",
      Convenience = Convenience.Staple
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
      Convenience = Convenience.Average
    },
    new()
    {
      Key = "4",
      Convenience = Convenience.Average
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
      Convenience = Convenience.Incredible,
      ReservedForAbilityType = AbilityType.Dispel
    },
    new()
    {
      Key = "c",
      Convenience = Convenience.Incredible
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
      ReservedForAbilityType = AbilityType.AoE
    },
    new()
    {
      Key = "z",
      Convenience = Convenience.Good
    },
    new()
    {
      Key = "x",
      Convenience = Convenience.Bad
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
      Key = "5",
      Convenience = Convenience.Bad,
      ReservedForAbilityType = AbilityType.Movement
    },
    new()
    {
      Key = "`",
      Convenience = Convenience.Terrible,
      AllowShiftModifier = false,
      ReservedForAbilityType = AbilityType.Trinket
    },
    new()
    {
      Key = "1",
      Modifier = Modifier.Control,
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.PersonalDefensive,
    },
    new()
    {
      Key = "2",
      Modifier = Modifier.Control,
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.PersonalDefensive,
    },
    new()
    {
      Key = "3",
      Modifier = Modifier.Control,
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.PersonalDefensive,
    },
    new()
    {
      Key = "4",
      Modifier = Modifier.Control,
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.HealingPotion,
    },
    new()
    {
      Key = "5",
      Modifier = Modifier.Control,
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.Healthstone,
    },
    new()
    {
      Key = "6",
      Modifier = Modifier.Control,
      Convenience = Convenience.Average,
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
      Key = "h",
      Convenience = Convenience.Bad
    }
  }
};

Console.WriteLine(solverService.Solve());