﻿using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Cores;

public sealed class PriestCore : ICharacterComponent
{
  public string Name => "Priest";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Mind Flay/Flash Heal/Smite",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Shadow Word: Pain/Vampiric Touch/Power Word: Shield",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Mind Blast/Holy Fire/Heal",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Psychic Scream",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.Stun
      },
      new()
      {
        Name = "Fade",
        Frequency = Frequency.Rarely,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Angelic Feather",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Movement
      },
      new()
      {
        Name = "Mass Dispel",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Shadowfiend/Power Infusion",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Dispel Magic/Leap",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Mind Control/Dominate Mind",
        Frequency = Frequency.AlmostNever
      },
      new()
      {
        Name = "Halo/Divine Star",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Desperate Prayer",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Shadow Word: Death/Power Word: Life",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Vampiric Embrace",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Purify/Purify Disease/Silence",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Interrupt
      },
      new()
      {
        Name = "Shackle Undead/Guardian Spirit",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.ExternalDefensive
      },
      new()
      {
        Name = "Shadowmeld",
        Frequency = Frequency.AlmostNever,
        AbilityType = AbilityType.ExternalDefensive
      }
    };
    abilities.AddRange(new Shared().GetAbilities());
    return abilities;
  }
}