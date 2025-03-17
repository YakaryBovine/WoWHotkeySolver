using WoWHotkeySolver.CharacterComponents.Priest;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Priest : ICharacterClass
{
  public string Name => "Priest";
  
  public ICharacterComponent Core { get; } = new PriestCore();

  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new Shadow(),
    new Holy(),
    new Discipline()
  };
}