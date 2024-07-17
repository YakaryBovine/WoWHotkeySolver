using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents;

public sealed class Shared : ICharacterComponent
{
  public string Name => "Shared";
  
  public List<Ability> GetAbilities()
  {
    return new List<Ability>
    {
      new()
      {
        Name = "Healthstone",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Healthstone
      },
      new()
      {
        Name = "Healing Potion",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.HealingPotion
      },
      new()
      {
        Name = "Combat Potion",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.CombatPotion
      },
      new()
      {
        Name = "Trinket",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Trinket
      },
      new()
      {
        Name = "Opie Menu",
        Frequency = Frequency.AlmostNever,
        AbilityType = AbilityType.OpieMenu
      }
    };
  }
}