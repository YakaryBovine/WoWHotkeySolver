using System.Diagnostics.CodeAnalysis;
using System.Text;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Collections;

/// <summary>
/// A map of hotkeys assigned to abilities.
/// </summary>
public sealed class HotkeyAssignments
{
  public required string Title { get; init; }
  
  private readonly Dictionary<Ability, Hotkey> _hotkeys = new();

  /// <summary>
  /// Assigns a hotkey to an ability, but only if neither have been assigned already.
  /// </summary>
  public bool TryAssign(Ability ability, Hotkey hotkey)
  {
    if (_hotkeys.ContainsKey(ability))
      return false;

    if (_hotkeys.ContainsValue(hotkey))
      return false;
    
    _hotkeys.Add(ability, hotkey);

    return true;
  }
  
  /// <summary>
  ///   Gets the hotkey solution for the specified ability, regardless of which <see cref="ICharacterComponent" />
  ///   it was assigned to.
  /// </summary>
  public bool TryGetAssignment(Ability ability, [NotNullWhen(true)] out Hotkey? hotkey)
  {
    var solutionKvp = _hotkeys.FirstOrDefault(x => x.Key.Equals(ability));

    if (solutionKvp.Key == null)
    {
      hotkey = null;
      return false;
    }

    hotkey = solutionKvp.Value;
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
      .OrderBy(x => x.Value.Modifier)
      .ThenBy(x => x.Value.Convenience)
      .ThenBy(x => x.Value.Key);
    foreach (var (ability, hotkey) in sortedAbilityHotkeys)
      stringBuilder.AppendLine($"{ability.Name}: {hotkey.ToString()}");
  }
}