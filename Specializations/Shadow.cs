using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Specializations;

public static class Shadow
{
  public static List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Mindgames",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Devouring Plague",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Dispersion",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Mind Flay",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Mind Blast",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Vampiric Touch",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Void Eruption/Void Bolt",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Void Torrent",
        Frequency = Frequency.Sometimes
      },
    };
    abilities.AddRange(Priest.GetAbilities());
    return abilities;
  }
}