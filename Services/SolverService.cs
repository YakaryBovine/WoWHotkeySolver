using System.Diagnostics.CodeAnalysis;
using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public required List<Ability> Abilities { get; init; }
  
  public required List<Hotkey> Hotkeys { get; init; }

  public string Solve()
  {
    if (Abilities.Count > Hotkeys.Count)
      return $"There aren't enough hotkeys ({Hotkeys.Count}) to cast that many abilities ({Abilities.Count}).";

    var solution = new HotkeySolution();
    var orderedAbilities = Abilities.OrderBy(x => x.Frequency).ToList();
    var orderedHotkeys = Hotkeys.OrderBy(x => x.Convenience).ToList();

    foreach (var ability in Abilities)
    {
      if (TryGetReservedHotkey(ability, out var hotkey))
      {
        orderedAbilities.Remove(ability);
        orderedHotkeys.Remove(hotkey);
        solution.AddHotkey(ability, hotkey);
      }
    }
    
    foreach (var ability in orderedAbilities)
    {
      var hotkey = orderedHotkeys.First();
      solution.AddHotkey(ability, hotkey);
      orderedHotkeys.RemoveAt(0);
    }
    
    return solution.ToString();
  }

  /// <summary>
  /// Outputs a hotkey if it has been reserved for an ability of this type.
  /// </summary>
  private bool TryGetReservedHotkey(Ability ability, [NotNullWhen(true)] out Hotkey? hotkey)
  {
    hotkey = Hotkeys.FirstOrDefault(x =>
      x.ReservedForAbilityType != AbilityType.Other && x.ReservedForAbilityType == ability.AbilityType);
    return hotkey != null;
  }
}