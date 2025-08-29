using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Monk;

public sealed class Brewmaster : ICharacterComponent
{
  public string Name => "Brewmaster";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Provoke",
        Frequency = Frequency.Constant,
        Type = AbilityType.Taunt
      },
      new()
      {
        Name = "Breath of Fire",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Celestial Infusion/Celestial Brew",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Keg Smash",
        Frequency = Frequency.Constant,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Purifying Brew",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Black Ox Brew",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Exploding Keg",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Weapons of Order",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Summon Black Ox Statue",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Crackling Jade Lightning",
        Frequency = Frequency.AlmostNever,
        Slot = AbilitySlot.Hostile
      },
    };
    return abilities;
  }
}