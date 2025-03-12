using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Holy : ICharacterComponent
{
  public string Name => "Holy";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Heal",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.SecondaryBuilder
      },
      new()
      {
        Name = "Smite",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.PrimaryBuilder
      },
      new()
      {
        Name = "Apotheosis",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Lightwell",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Symbol of Hope",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Divine Word",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Holy Nova",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Divine Hymn",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Prayer of Mending",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Holy Word: Sanctify",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Holy Word: Chastise",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Holy Word: Serenity",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Premonition",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Guardian Spirit",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ExternalDefensive,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Prayer of Healing",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Renew",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      },
    };
    return abilities;
  }
}