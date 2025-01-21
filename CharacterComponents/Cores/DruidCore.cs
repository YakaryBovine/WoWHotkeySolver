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
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Skull Bash/Nature's Cure/Solar Beam",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Interrupt
      },
      new()
      {
        Name = "Barkskin",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
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
        AbilityType = AbilityType.ShortPrimaryCooldown
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
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Typhoon",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Incapacitating Roar/Mighty Bash",
        Frequency = Frequency.Rarely
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
        Name = "Revive",
        Frequency = Frequency.AlmostNever
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
    };
    return abilities;
  }
}