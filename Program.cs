using WoWHotkeySolver;
using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Services;

var solverService = new SolverService
{
  Abilities = Priest.GetAbilities(),
  Hotkeys = new List<Hotkey>
  {
    new()
    {
      Key = "q",
      Convenience = Convenience.Incredible
    },
    new()
    {
      Key = "e",
      Convenience = Convenience.Incredible
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
      Convenience = Convenience.Average
    },
    new()
    {
      Key = "r",
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.Dispel
    },
    new()
    {
      Key = "c",
      Convenience = Convenience.Average
    },
    new()
    {
      Key = "v",
      Convenience = Convenience.Good
    },
    new()
    {
      Key = "g",
      Convenience = Convenience.Average
    },
    new()
    {
      Key = "c",
      Convenience = Convenience.Good
    },
    new()
    {
      Key = "z",
      Convenience = Convenience.Good
    },
    new()
    {
      Key = "x",
      Convenience = Convenience.Average
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
      Convenience = Convenience.Bad
    },
    new()
    {
      Key = "ctrl 1",
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.HealingPotion,
      AllowShiftModifier = false
    },
    new()
    {
      Key = "ctrl 2",
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.Healthstone,
      AllowShiftModifier = false
    },
    new()
    {
      Key = "ctrl 3",
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.PersonalDefensive,
      AllowShiftModifier = false
    },
    new()
    {
      Key = "ctrl 6",
      Convenience = Convenience.Average,
      ReservedForAbilityType = AbilityType.CombatPotion,
      AllowShiftModifier = false
    },
  }
};

Console.WriteLine(solverService.Solve());