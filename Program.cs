using WoWHotkeySolver;
using WoWHotkeySolver.Enums;

var solverService = new SolverService
{
  Abilities = new List<Ability>()
  {
    new()
    {
      Name = "Flash Heal",
      Frequency = Frequency.Constant
    },
    new()
    {
      Name = "Smite",
      Frequency = Frequency.Constant
    },
    new()
    {
      Name = "Shadow Word: Pain",
      Frequency = Frequency.Frequent
    },
    new()
    {
      Name = "Circle of Healing",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Holy Fire",
      Frequency = Frequency.Frequent
    },
    new()
    {
      Name = "Holy Word: Chastise",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Holy Word: Sanctify",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Purify",
      Frequency = Frequency.Constant,
      AbilityType = AbilityType.Dispel
    },
    new()
    {
      Name = "Holy Word: Serenity",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Prayer of Healing",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Prayer of Mending",
      Frequency = Frequency.Constant
    },
    new()
    {
      Name = "Holy Nova",
      Frequency = Frequency.Constant
    },
  },
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
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "g",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "c",
      Convenience = Convenience.Easy
    },
    new()
    {
      Key = "z",
      Convenience = Convenience.Easy
    },
  }
};

Console.WriteLine(solverService.Solve());