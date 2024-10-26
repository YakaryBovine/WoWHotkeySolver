using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Retribution : ICharacterComponent
{
  public string Name => "Retribution";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Blade of Justice",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Divine Storm",
        Frequency = Frequency.Frequent
      }
    };
    return abilities;
  }
}