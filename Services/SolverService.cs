using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public required ICharacterClass Class { get; init; }
  
  public required List<Hotkey> Hotkeys { get; init; }

  public void SolveAll()
  {
    foreach (var specialization in Class.Specializations)
    {
      Solve(Class.Core, specialization);
    }
  }

  private void Solve(ICharacterComponent core, ICharacterComponent specialization)
  {
    var transformedHotkeys = TransformAndOrderHotkeys();

    var abilities = specialization.GetAbilities();
    abilities.AddRange(core.GetAbilities());
    if (specialization.GetAbilities().Count > transformedHotkeys.Count)
    {
      throw new InvalidOperationException($"There aren't enough hotkeys ({transformedHotkeys.Count}) to cast that many abilities ({abilities.Count}).");
    }

    var solution = new HotkeySolution();
    var abilityHotkeyPool = new AbilityHotkeyPool
    {
      Abilities = abilities.OrderBy(x => x.Frequency).ToList(),
      Hotkeys = transformedHotkeys
    };

    AllocateReservedHotkeys(abilityHotkeyPool, solution);
    AllocateUnreservedHotkeys(abilityHotkeyPool, solution);

    Console.WriteLine(solution.ToString());
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