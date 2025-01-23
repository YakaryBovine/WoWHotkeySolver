using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Frost : ICharacterComponent
{
  public string Name => "Frost";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Dark Command",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Death Coil",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Death Strike",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Frost Strike",
        Frequency = Frequency.Constant,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Obliterate",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Howling Blast",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Glacial Advance",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Frostwyrm's Fury",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Pillar of Frost",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Remorseless Winter",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Breath of Sindragosa",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Reaper's Mark",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Frostscythe",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Horn of Winter",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Chill Streak",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Empower Rune Weapon",
        Frequency = Frequency.Rarely
      }
    };
    return abilities;
  }
}