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
    new()
    {
      Name = "Divine Hymn",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Psychic Scream",
      Frequency = Frequency.Sometimes,
      AbilityType = AbilityType.Stun
    },
    new()
    {
      Name = "Guardian Spirit",
      Frequency = Frequency.Sometimes,
      AbilityType = AbilityType.ExternalDefensive
    },
    new()
    {
      Name = "Fade",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Angelic Feather",
      Frequency = Frequency.Frequent,
      AbilityType = AbilityType.Movement
    },
    new()
    {
      Name = "Leap of Faith",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Levitate",
      Frequency = Frequency.AlmostNever
    },
    new()
    {
      Name = "Mass Dispel",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Mind Soothe",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Power Infusion",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Opie Menu",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Power Word: Shield",
      Frequency = Frequency.AlmostNever
    },
    new()
    {
      Name = "Renew",
      Frequency = Frequency.AlmostNever
    },
    new()
    {
      Name = "Shadowfiend",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Lightwell",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Symbol of Hope",
      Frequency = Frequency.Rarely
    },
    new()
    {
      Name = "Divine Word",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Power Word: Life",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Dispel Magic",
      Frequency = Frequency.Sometimes
    },
    new()
    {
      Name = "Shackle Undead",
      Frequency = Frequency.AlmostNever
    },
    new()
    {
      Name = "Mind Control/Dominate Mind",
      Frequency = Frequency.AlmostNever
    },
    new()
    {
      Name = "Halo/Divine Star",
      Frequency = Frequency.Frequent
    },
    new()
    {
      Name = "Apotheosis/Holy Word: Salvation",
      Frequency = Frequency.Rarely
    }
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