using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public required List<Ability> Abilities { get; init; }
  
  public required List<Hotkey> Hotkeys { get; init; }

  public string Solve()
  {
    var transformedHotkeys = TransformAndOrderHotkeys();
    
    if (Abilities.Count > transformedHotkeys.Count)
      return $"There aren't enough hotkeys ({transformedHotkeys.Count}) to cast that many abilities ({Abilities.Count}).";

    var solution = new HotkeySolution();
    var abilityHotkeyPool = new AbilityHotkeyPool
    {
      Abilities = Abilities.OrderBy(x => x.Frequency).ToList(),
      Hotkeys = transformedHotkeys
    };

    AllocateReservedHotkeys(abilityHotkeyPool, solution);
    AllocateUnreservedHotkeys(abilityHotkeyPool, solution);
    
    return solution.ToString();
  }

  private static void AllocateReservedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolution solution)
  {
    foreach (var ability in abilityHotkeyPool.Abilities.ToList())
    {
      if (abilityHotkeyPool.TryGetReservedHotkey(ability, out var hotkey))
      {
        abilityHotkeyPool.Remove(ability, hotkey);
        solution.AddHotkey(ability, hotkey);
      }
    }
  }
  
  private static void AllocateUnreservedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolution solution)
  {
    var hotkeys = abilityHotkeyPool.Hotkeys.ToList();
    var hotkeyIndex = hotkeys.Count - 1;
    foreach (var ability in abilityHotkeyPool.Abilities.ToList())
    {
      var hotkey = hotkeys[hotkeyIndex];
      solution.AddHotkey(ability, hotkey);
      abilityHotkeyPool.Remove(ability, hotkey);
      hotkeyIndex--;
    }
  }

  private List<Hotkey> TransformAndOrderHotkeys()
  {
    var hotkeys = Hotkeys.ToList();
    hotkeys.AddRange(Hotkeys.Where(x => x.AllowShiftModifier && x.Modifier == Modifier.None).Select(h => new Hotkey
    {
      Key = $"{h.Key}",
      Convenience = h.Convenience + 100,
      AllowShiftModifier = false,
      Modifier = Modifier.Shift,
      ReservedForAbilityType = AbilityType.Other
    }));
    return hotkeys.OrderByDescending(x => x.Convenience).ToList();
  }
}