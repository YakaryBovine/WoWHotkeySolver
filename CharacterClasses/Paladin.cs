using WoWHotkeySolver.CharacterComponents.Cores;
using WoWHotkeySolver.CharacterComponents.Specializations;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterClasses;

public sealed class Paladin : ICharacterClass
{
  public string Name => "Paladin";

  public ICharacterComponent Core { get; } = new PaladinCore();

  public List<ICharacterComponent> Specializations { get; } = new()
  {
    new HolyPaladin(),
    new Retribution()
  };
}