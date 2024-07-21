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
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Frost Shock",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Chain Lightning",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Lightning Bolt",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.MainSpender
      },
      new()
      {
        Name = "Crash Lightning",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Feral Spirit",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.ShortPrimaryCooldown
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
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Elemental Blast",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Ice Strike",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Primordial Wave",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Doom Winds",
        Frequency = Frequency.Infrequent
      }
    };
    return abilities;
  }
}