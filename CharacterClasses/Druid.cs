using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Druid : ICharacterClass
{
  public string Name => "Druid";

  public ICharacterComponent Core => new DruidCore();

  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new Restoration(),
    new Guardian(),
    new Balance()
  };
}