﻿using WoWHotkeySolver;
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
    new()
    {
      Key = "`",
      Convenience = Convenience.Moderate
    },
    new()
    {
      Key = "ctrl 1",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.HealingPotion,
      AllowShiftModifier = false
    },
    new()
    {
      Key = "ctrl 2",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.Healthstone,
      AllowShiftModifier = false
    },
    new()
    {
      Key = "ctrl 3",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.PersonalDefensive,
      AllowShiftModifier = false
    },
    new()
    {
      Key = "ctrl 6",
      Convenience = Convenience.Easy,
      ReservedForAbilityType = AbilityType.CombatPotion,
      AllowShiftModifier = false
    },
  }
};

Console.WriteLine(solverService.Solve());