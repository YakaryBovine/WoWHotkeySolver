using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver;

public sealed class Ability
{
  public required string Name { get; init; }
  
  public required Frequency Frequency { get; init; }
  
  public AbilityType AbilityType { get; init; }
}