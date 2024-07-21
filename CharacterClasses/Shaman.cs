using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Shaman : ICharacterClass
{
  public string Name => "Shaman";

  public ICharacterComponent Core { get; } = new ShamanCore();

  public List<ICharacterComponent> Specializations { get; } = new List<ICharacterComponent>()
  {
    new Enhancement(),
    new Elemental()
  };
}