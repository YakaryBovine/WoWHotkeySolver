﻿using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Models;

public sealed class Ability : IEquatable<Ability>
{
  public required string Name { get; init; }
  
  public required Frequency Frequency { get; init; }
  
  public AbilityType AbilityType { get; init; }

  public bool Equals(Ability? other)
  {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return Name == other.Name && Frequency == other.Frequency && AbilityType == other.AbilityType;
  }

  public override bool Equals(object? obj)
  {
    return ReferenceEquals(this, obj) || obj is Ability other && Equals(other);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Name, (int)Frequency, (int)AbilityType);
  }
}