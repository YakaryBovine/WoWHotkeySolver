using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public class DruidCore : ICharacterComponent
{
  public string Name => "Druid";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Dash",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Wild Charge",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Movement
      },
      new()
      {
        Name = "Skull Bash/Nature's Cure/Solar Beam",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Interrupt
      },
      new()
      {
        Name = "Barkskin",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Survival Instincts",
        Frequency = Frequency.Constant,
        Type = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Heart of the Wild",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Incarnation/Convoke",
        Frequency = Frequency.Rarely,
        Type = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Innervate",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Entangling Roots",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Cyclone",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Typhoon",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Incapacitating Roar/Mighty Bash",
        Frequency = Frequency.Rarely,
        Type = AbilityType.Stun
      },
      new()
      {
        Name = "Renewal",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Ursol's Vortex",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Stampeding Roar",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Soothe",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Hibernate",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Prowl",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Adaptive Swarm",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Nature's Vigil",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Shadowmeld",
        Frequency = Frequency.Rarely
      },
    };
    return abilities;
  }
}