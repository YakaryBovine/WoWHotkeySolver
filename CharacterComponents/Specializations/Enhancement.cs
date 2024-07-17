using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Enhancement : ICharacterComponent
{
  public string Name => "Enhancement";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Flame Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Frost Shock",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Chain Lightning",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Lightning Bolt",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Crash Lightning",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Feral Spirit",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Stormstrike/Healing Surge",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Lava Lash",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Sundering",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Elemental Blast",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Ice Strike",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Primordial Wave",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Windfury Totem",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Doom Winds",
        Frequency = Frequency.Sometimes
      }
    };
    return abilities;
  }
}