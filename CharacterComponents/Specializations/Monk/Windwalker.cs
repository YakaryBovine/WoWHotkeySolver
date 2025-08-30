using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Monk;

public sealed class Windwalker : ICharacterComponent
{
  public string Name => "Windwalker";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Fists of Fury",
        Frequency = Frequency.Semifrequent,
        Type = AbilityType.MainSpender,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Crackling Jade Lightning",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Flying Serpent Kick",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Storm, Earth, and Fire",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Strike of the Windlord",
        Frequency = Frequency.Rarely,
        Type = AbilityType.ShortPrimaryCooldown,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Touch of Karma",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Whirling Dragon Punch",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Slicing Winds",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Provoke",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Hostile
      }
    };
    return abilities;
  }
}