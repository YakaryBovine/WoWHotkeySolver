using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Models;

public sealed class Hotkey
{
  public required string Key { get; init; }
  
  public required Convenience Convenience { get; init; }

  public Modifier Modifier { get; init; } = Modifier.None;
  
  /// <summary>If true, the hotkey is also available in its shift-modifier version. Defaults to true.</summary>
  public bool AllowShiftModifier { get; init; } = true;

  public AbilityType ReservedForAbilityType { get; init; }
    
  public override string ToString()
  {
    return $"{Modifier.ToFriendlyString()}{Key}";
  }
}