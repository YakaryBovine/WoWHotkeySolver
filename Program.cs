using WoWHotkeySolver;
using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;

var solverService = new SolverService
{
  Abilities = Priest.GetAbilities(),
  Hotkeys = new List<Hotkey>
  {
    new()
    {
      Key = "q",
      Convenience = Convenience.Trivial
    },
    new()
    {
      Key = "e",
      Convenience = Convenience.Trivial
    },
    new()
    {
      Key = "1",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "2",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "3",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "4",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "f",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "r",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.Dispel
    },
    new()
    {
      Key = "c",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "v",
      Convenience = Convenience.Trivial
    },
    new()
    {
      Key = "g",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "c",
      Convenience = Convenience.Trivial
    },
    new()
    {
      Key = "z",
      Convenience = Convenience.Trivial
    },
    new()
    {
      Key = "x",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "b",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.Stun
    },
    new()
    {
      Key = "t",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.ExternalDefensive
    },
    new()
    {
      Key = "5",
      Convenience = Convenience.Moderate,
      ReservedForAbilityType = AbilityType.Movement
    },
  }
};

Console.WriteLine(solverService.Solve());