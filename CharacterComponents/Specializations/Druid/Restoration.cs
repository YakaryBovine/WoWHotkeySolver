using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Restoration : ICharacterComponent
{
  public string Name => "Restoration";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Lifebloom",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Rejuvenation",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Regrowth",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Wild Growth",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Swiftmend",
        Frequency = Frequency.Frequent,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Ironbark",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Cenarion Ward",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Flourish",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Tranquility",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Nature's Swiftness",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Grove Guardians/Nourish",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Efflorescence",
        Frequency = Frequency.Infrequent
      },
    };
    return abilities;
  }
}