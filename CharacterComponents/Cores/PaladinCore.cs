using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public sealed class PaladinCore : ICharacterComponent
{
  public string Name => "Paladin";

  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Lay on Hands",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Divine Steed",
        Frequency = Frequency.Semifrequent,
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Crusader Strike/Flash of Light",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Hammer of Wrath/Word of Glory",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Rebuke/Cleanse",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Interrupt
      },
      new()
      {
        Name = "Divine Toll",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Blessing of Protection",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Judgement/Holy Light",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Consecration",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Blessing of Sacrifice",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Hammer of Justice/Blessing of Freedom",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Stun
      },
      new()
      {
        Name = "Repentence/Blinding Light",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Divine Shield",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      }
    };
    abilities.AddRange(new Shared().GetAbilities());
    return abilities;
  }
}