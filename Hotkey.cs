using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver;

public sealed class Hotkey
{
  public required string Key { get; init; }
  
  public required Convenience Convenience { get; init; }
  
  public AbilityType ReservedForAbilityType { get; init; }
}