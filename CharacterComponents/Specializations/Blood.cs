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
        Name = "Dark Command",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Taunt
      },
      new()
      {
        Name = "Death Strike",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Blood Boil",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Dancing Rune Weapon",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Death's Caress",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Tombstone",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Vampiric Blood",
        Frequency = Frequency.Infrequent
      },
    };
    return abilities;
  }
}