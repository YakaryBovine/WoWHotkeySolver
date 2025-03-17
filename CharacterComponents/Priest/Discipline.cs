using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Priest;

public sealed class Discipline : ICharacterComponent
{
  public string Name => "Discipline";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Smite",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.PrimaryBuilder
      },
      new()
      {
        Name = "Penance",
        Frequency = Frequency.Constant,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Ultimate Penitence",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Power Word: Barrier",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Pain Suppression",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ExternalDefensive,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Renew",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Evangelism",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Power Word: Radiance",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Premonition",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Power Word: Shield",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      }
    };
    return abilities;
  }
}