using System.Diagnostics.CodeAnalysis;
using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Services;

/// <summary>
/// A pool of abilities and hotkeys that can be allocated.
/// </summary>
public sealed class AbilityHotkeyPool
{
  public required List<Ability> Abilities { get; init; }
  
  public required List<Hotkey> Hotkeys { get; init; }

  public void Remove(Ability ability, Hotkey hotkey)
  {
    Abilities.Remove(ability);
    Hotkeys.Remove(hotkey);
  }
  
  /// <summary>
  /// Outputs a hotkey if it has been reserved for an ability of this type.
  /// </summary>
  public bool TryGetReservedHotkey(Ability ability, [NotNullWhen(true)] out Hotkey? hotkey)
  {
    hotkey = Hotkeys.FirstOrDefault(x =>
      x.ReservedForAbilityType != AbilityType.Other && x.ReservedForAbilityType == ability.AbilityType);
    return hotkey != null;
  }
}