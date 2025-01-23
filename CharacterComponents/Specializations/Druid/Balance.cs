using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Balance : ICharacterComponent
{
  public string Name => "Balance";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Starfire",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Wrath",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Regrowth",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Sunfire",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Starsurge",
        Frequency = Frequency.Frequent,
        Type = AbilityType.MainSpender,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Starfall",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Solar Beam",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Hostile
      }
    };
    return abilities;
  }
}