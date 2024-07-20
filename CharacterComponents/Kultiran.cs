using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents;

public sealed class Kultiran : ICharacterComponent
{
  public string Name => "Kul'tiran";
  
  public List<Ability> GetAbilities()
  {
    return new List<Ability>
    {
      new()
      {
        Name = "Haymaker",
        Frequency = Frequency.Rarely
      }
    };
  }
}