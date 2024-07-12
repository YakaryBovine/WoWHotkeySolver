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
      }
    };
    abilities.AddRange(Priest.GetAbilities());
    return abilities;
  }
}