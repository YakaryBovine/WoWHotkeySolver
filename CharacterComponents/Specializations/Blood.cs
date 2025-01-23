using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Blood : ICharacterComponent
{
  public string Name => "Blood";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Heart Strike",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Marrowrend",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Reaper's Mark",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Dark Command",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Taunt
      },
      new()
      {
        Name = "Death Strike",
        Frequency = Frequency.Frequent,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Blood Boil",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Dancing Rune Weapon",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Death's Caress",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Tombstone",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Bonestorm",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Vampiric Blood",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Death Coil",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Gorefiend's Grasp",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Blooddrinker/Consumption",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Blood Tap",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Rune Tap",
        Frequency = Frequency.AlmostNever
      }
    };
    return abilities;
  }
}