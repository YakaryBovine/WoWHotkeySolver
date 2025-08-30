using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Monk;

public sealed class Mistweaver : ICharacterComponent
{
  public string Name => "Mistweaver";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Life Cocoon",
        Frequency = Frequency.Constant,
        Type = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Summon Jade Serpent Statue",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Enveloping Mist",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Renewing Mist",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.SecondaryBuilder
      },
      new()
      {
        Name = "Revival/Restoral",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Mana Tea",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Reawaken",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Dead
      },
      new()
      {
        Name = "Sheilun's Gift",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Jadefire Stomp",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Rushing Wind Kick",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Celestial Conduit",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Crackling Jade Lightning",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
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