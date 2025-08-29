using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations.Monk;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Monk : ICharacterClass
{
  public string Name => "Monk";

  public ICharacterComponent Core { get; } = new MonkCore();

  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new Brewmaster(),
    new Mistweaver(),
    new Windwalker()
  };
}