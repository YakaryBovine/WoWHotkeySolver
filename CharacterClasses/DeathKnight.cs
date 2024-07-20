using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class DeathKnight : ICharacterClass
{
  public string Name => "Death Knight";
  
  public ICharacterComponent Core { get; } = new DeathKnightCore();
  
  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new Blood(),
    new Frost(),
    new Unholy()
  };
}