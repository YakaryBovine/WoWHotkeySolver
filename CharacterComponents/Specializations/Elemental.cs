﻿using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.CharacterComponents.Specializations;

public sealed class Elemental : ICharacterComponent
{
  public string Name => "Elemental";
  
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
        Name = "Chain Lightning",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Lightning Bolt",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Lava Burst",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Spiritwalker's Grace",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Earth Shock",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.MainSpender
      },
      new()
      {
        Name = "Earthquake",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Fire Elemental",
        Frequency = Frequency.Infrequent,
        AbilityType = AbilityType.ShortPrimaryCooldown
      },
      new()
      {
        Name = "Primordial Wave",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Stormkeeper",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Elemental Blast",
        Frequency = Frequency.Infrequent
      },
      new()
      {
        Name = "Frost Shock",
        Frequency = Frequency.Semifrequent
      },
      new()
      {
        Name = "Nature's Swiftness",
        Frequency = Frequency.Infrequent
      }
    };
    return abilities;
  }
}