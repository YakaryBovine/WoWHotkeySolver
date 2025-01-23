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
        Type = AbilityType.Movement
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
        Type = AbilityType.Interrupt
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
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Blessing of Sacrifice",
        Frequency = Frequency.Frequent,
        Type = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Hammer of Justice/Blessing of Freedom",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.Stun
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
        Type = AbilityType.PersonalDefensive
      }
    };
    abilities.AddRange(new Shared().GetAbilities());
    return abilities;
  }
}