using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Specializations;

public sealed class Elemental : ISpecialization
{
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Flame Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Chain Lightning",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Flame Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Lightning Bolt",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Lava Burst",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Spiritwalker's Grace",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Earth Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Earthquake",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Fire Elemental",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Primordial Wave",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Stormkeeper",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Elemental Blast",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Icefury",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Frost Shock",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Nature's Swiftness",
        Frequency = Frequency.Sometimes
      }
    };
    abilities.AddRange(Shaman.GetAbilities());
    return abilities;
  }
}