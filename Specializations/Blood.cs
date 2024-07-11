using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Specializations;

public static class Blood
{
  public static List<Ability> GetAbilities()
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
        Frequency = Frequency.Sometimes,
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
        Frequency = Frequency.Sometimes
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
        Frequency = Frequency.Sometimes
      },
    };
    abilities.AddRange(DeathKnight.GetAbilities());
    return abilities;
  }
}