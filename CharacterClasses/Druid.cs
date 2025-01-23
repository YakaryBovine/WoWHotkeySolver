using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations.Druid;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Druid : ICharacterClass
{
  public string Name => "Druid";

  public ICharacterComponent Core { get; } = new DruidCore();

  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new Restoration(),
    new BearForm(),
    new Balance(),
    new CatForm()
  };
}