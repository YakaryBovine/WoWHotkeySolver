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
    var abilityHotkeyPool = new AbilityHotkeyPool
    {
      Abilities = Abilities.OrderBy(x => x.Frequency).ToList(),
      Hotkeys = Hotkeys.OrderBy(x => x.Convenience).ToList()
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
    foreach (var ability in abilityHotkeyPool.Abilities.ToList())
    {
      var hotkey = hotkeys.First();
      solution.AddHotkey(ability, hotkey);
      abilityHotkeyPool.Remove(ability, hotkey);
    }
  }
}