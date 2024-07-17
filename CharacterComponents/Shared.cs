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
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.Healthstone
      },
      new()
      {
        Name = "Healing Potion",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.HealingPotion
      },
      new()
      {
        Name = "Combat Potion",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.CombatPotion
      },
      new()
      {
        Name = "Trinket",
        Frequency = Frequency.Sometimes,
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