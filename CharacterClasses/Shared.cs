using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.CharacterClasses;

public static class Shared
{
  public static List<Ability> GetAbilities()
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
        Frequency = Frequency.Sometimes
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