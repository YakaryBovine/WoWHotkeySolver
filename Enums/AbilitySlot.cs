namespace WoWHotkeySolver.Enums;

/// <summary>
/// Abilities in different "slots" have different cast conditions, allowing multiple to be assigned to the same hotkey.
/// </summary>
public enum AbilitySlot
{
  /// <summary>
  /// Uniquely, takes up EVERY slot.
  /// </summary>
  All,

  Hostile,
  Friendly,
  Dead
}