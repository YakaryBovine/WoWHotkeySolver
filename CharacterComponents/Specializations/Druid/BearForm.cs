using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations.Druid;

public sealed class BearForm : ICharacterComponent
{
  public string Name => "Guardian";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Thrash",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Mangle",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Ironfur",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Swipe",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Growl",
        Frequency = Frequency.Semifrequent,
        Type = AbilityType.Taunt
      },
      new()
      {
        Name = "Maul/Raze",
        Frequency = Frequency.Constant,
        Type = AbilityType.MainSpender
      },
      new()
      {
        Name = "Regrowth",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Friendly
      },
      new()
      {
        Name = "Pulverize",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Rage of the Sleeper",
        Frequency = Frequency.Semifrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Lunar Beam",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Moonfire",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Survival Instincts",
        Frequency = Frequency.AlmostNever,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Skull Bash",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt,
        Slot = AbilitySlot.Hostile
      }
    };
    return abilities;
  }
}