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
        Type = AbilityType.Healthstone
      },
      new()
      {
        Name = "Healing Potion",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.HealingPotion
      },
      new()
      {
        Name = "Combat Potion",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.CombatPotion
      },
      new()
      {
        Name = "Trinket",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Trinket
      },
      new()
      {
        Name = "Opie Menu",
        Frequency = Frequency.AlmostNever,
        Type = AbilityType.OpieMenu
      }
    };
  }
}