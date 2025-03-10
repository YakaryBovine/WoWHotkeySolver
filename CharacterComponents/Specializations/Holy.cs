﻿using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Holy : ICharacterComponent
{
  public string Name => "Holy";
  
  public List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Apotheosis",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Lightwell",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Symbol of Hope",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Divine Word",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Holy Nova",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Divine Hymn",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Prayer of Healing",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Prayer of Mending",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Holy Word: Sanctify",
        Frequency = Frequency.Infrequent,
        Type = AbilityType.AoE
      },
      new()
      {
        Name = "Holy Word: Chastise/Holy Word: Serenity",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Premonition",
        Frequency = Frequency.Infrequent
      }
    };
    return abilities;
  }
}