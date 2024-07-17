using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Priest : ICharacterClass
{
  public string Name => "Priest";
  
  public ICharacterComponent Core { get; } = new PriestCore();

  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new Shadow(),
    new Holy()
  };
}