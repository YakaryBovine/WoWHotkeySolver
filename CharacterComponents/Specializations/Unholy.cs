using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Unholy : ICharacterComponent
{
  public string Name => "Frost";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Dark Command",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Death Strike",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Death Coil",
        Frequency = Frequency.Constant,
        AbilityType = AbilityType.MainSpender
      },
      new()
      {
        Name = "Apocalypse",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Dark Transformation",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Army of the Dead/Raise Abomination",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Summon Gargoyle",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Unholy Assault",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Unholy Blight",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Epidemic",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Scourge Strike/Clawing Shadows",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Festering Strike",
        Frequency = Frequency.Constant
      },
    };
    return abilities;
  }
}