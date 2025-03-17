using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Priest;

public sealed class Shadow : ICharacterComponent
{
  public string Name => "Shadow";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Mind Flay/Mind Spike",
        Frequency = Frequency.Constant,
        Slot = AbilitySlot.Hostile,
        Type = AbilityType.PrimaryBuilder
      },
      new()
      {
        Name = "Dispersion",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Void Eruption/Void Bolt",
        Frequency = Frequency.Infrequent,
        Slot = AbilitySlot.Hostile,
      },
      new()
      {
        Name = "Devouring Plague",
        Frequency = Frequency.Frequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Void Torrent",
        Frequency = Frequency.Semifrequent,
        Slot = AbilitySlot.Hostile
      },
      new()
      {
        Name = "Shadow Crash",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Power Word: Shield",
        Frequency = Frequency.Rarely,
        Slot = AbilitySlot.Friendly
      }
    };
    return abilities;
  }
}