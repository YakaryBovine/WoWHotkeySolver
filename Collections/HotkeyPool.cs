using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Collections;

/// <summary>
/// A pool of transformed, sanitized keyboard hotkeys.
/// </summary>
public sealed class HotkeyPool
{
  public List<Hotkey> Hotkeys { get; }

  public HotkeyPool(List<Hotkey> hotkeys) => Hotkeys = TransformAndOrderHotkeys(hotkeys);

  /// <summary>
  /// Gets all <see cref="Hotkey"/> reserved for a particular ability type, if any.
  /// </summary>
  public IEnumerable<Hotkey> GetReservedHotkey(AbilityType abilityType) =>
    Hotkeys.Where(x => x.ReservedForAbilityType == abilityType);

  private static List<Hotkey> TransformAndOrderHotkeys(List<Hotkey> hotKeys)
  {
    var myHotkeys = new List<Hotkey>();
    myHotkeys.AddRange(hotKeys);
    myHotkeys.AddRange(hotKeys.Where(x => x is { AllowShiftModifier: true, Modifier: Modifier.None }).Select(h => new Hotkey
    {
      Key = $"{h.Key}",
      Convenience = h.Convenience.ApplyModifierPenalty(),
      AllowShiftModifier = false,
      Modifier = Modifier.Shift,
      ReservedForAbilityType = AbilityType.Other
    }));
    return myHotkeys.OrderBy(x => x.Convenience).ToList();
  }
}