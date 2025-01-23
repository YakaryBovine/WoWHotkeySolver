using System.Diagnostics.CodeAnalysis;
using System.Text;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Collections;

/// <summary>
/// A map of hotkeys assigned to abilities.
/// </summary>
public sealed class HotkeyAssignments
{
  public required string Title { get; init; }
  
  private readonly Dictionary<(Hotkey Hotkey, AbilitySlot Slot), Ability> _hotkeys = new();
  
  /// <summary>
  /// Assigns a hotkey to an ability, but only if neither have been assigned already.
  /// </summary>
  public bool TryAssign(Ability ability, (Hotkey Hotkey, AbilitySlot Slot) hotkeyInSlot)
  {
    if (_hotkeys.ContainsKey(hotkeyInSlot))
      return false;
    
    //Todo: insanity, so bad
    if (_hotkeys.ContainsKey((hotkeyInSlot.Hotkey, AbilitySlot.All)))
      return false;

    //Todo: surely not...
    if (hotkeyInSlot.Slot == AbilitySlot.All)
    {
      if (_hotkeys.ContainsKey((hotkeyInSlot.Hotkey, AbilitySlot.Dead)))
        return false;
      
      if (_hotkeys.ContainsKey((hotkeyInSlot.Hotkey, AbilitySlot.Friendly)))
        return false;
      
      if (_hotkeys.ContainsKey((hotkeyInSlot.Hotkey, AbilitySlot.Hostile)))
        return false;
    }

    if (_hotkeys.ContainsValue(ability))
      return false;

    _hotkeys.Add(hotkeyInSlot, ability);

    return true;
  }
  
  /// <summary>
  ///   Gets the hotkey solution for the specified ability, regardless of which <see cref="ICharacterComponent" />
  ///   it was assigned to.
  /// </summary>
  public bool TryGetAssignment(Ability ability, [NotNullWhen(true)] out (Hotkey Hotkey, AbilitySlot AbilitySlot)? assignment)
  {
    var solutionKvp = _hotkeys.FirstOrDefault(x => x.Value.Equals(ability));

    if (solutionKvp.Value == null)
    {
      assignment = null;
      return false;
    }

    assignment = solutionKvp.Key;
    return true;
  }

  public override string ToString()
  {
    var stringBuilder = new StringBuilder();
    AppendHotkeys(stringBuilder);

    return stringBuilder.ToString();
  }

  private void AppendHotkeys(StringBuilder stringBuilder)
  {
    stringBuilder.AppendLine($"----{Title}----");
    var sortedAbilityHotkeys = _hotkeys
      .OrderBy(x => x.Key.Hotkey.Modifier)
      .ThenBy(x => x.Key.Hotkey.Convenience)
      .ThenBy(x => x.Key.Hotkey.Key);

    foreach (var (hotkeyAndSlot, ability) in sortedAbilityHotkeys)
      stringBuilder.AppendLine($"{ability.Name}: {hotkeyAndSlot.Hotkey.ToString()} {hotkeyAndSlot.Slot.ToFriendlyString()}");
  }
}