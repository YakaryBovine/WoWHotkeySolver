using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Models;

public record Ability
{
  public required string Name { get; init; }
  
  public required Frequency Frequency { get; init; }
  
  public AbilityType Type { get; init; }

  public AbilitySlot Slot { get; init; } = AbilitySlot.All;

  /// <summary>
  /// An ability that can be thought of as an extension of this one, so it should be on the same key but with a Shift
  /// modifier.
  /// </summary>
  public Ability? Child { get; init; }
}