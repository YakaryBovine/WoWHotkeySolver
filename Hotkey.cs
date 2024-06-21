﻿using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver;

public sealed class Hotkey
{
  public required string Key { get; init; }
  
  public required Convenience Convenience { get; init; }

  /// <summary>If true, the hotkey is also available in its shift-modifier version.</summary>
  public bool AllowShiftModifier { get; init; } = true;
  
  public AbilityType ReservedForAbilityType { get; init; }
}