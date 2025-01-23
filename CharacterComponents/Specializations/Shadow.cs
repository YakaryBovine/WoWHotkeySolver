using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Shadow : ICharacterComponent
{
  public string Name => "Shadow";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Dispersion",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Void Eruption/Void Bolt",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Devouring Plague",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Void Torrent",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Shadow Crash",
        Frequency = Frequency.Frequent,
        Type = AbilityType.AoE
      }
    };
    return abilities;
  }
}