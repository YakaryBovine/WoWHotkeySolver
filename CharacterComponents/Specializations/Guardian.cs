using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Guardian : ICharacterComponent
{
  public string Name => "Guardian";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Mangle",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Ironfur",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Thrash",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Swipe",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Growl",
        Frequency = Frequency.Semifrequent,
        AbilityType = AbilityType.Taunt
      },
      new()
      {
        Name = "Maul",
        Frequency = Frequency.Constant,
        AbilityType = AbilityType.MainSpender
      },
    };
    return abilities;
  }
}