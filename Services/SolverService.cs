using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public required ICharacterClass Class { get; init; }
  
  public required List<Hotkey> Hotkeys { get; init; }

  public void SolveAll()
  {
    var solution = new HotkeySolution();
    var abilityHotkeyPool = new AbilityHotkeyPool();
    abilityHotkeyPool.Hotkeys.AddRange(TransformAndOrderHotkeys());
    //Order the specialization with the most reserved abilities first to ensure that core abilities can't take the
    //hotkeys they need.
    var orderedSpecializations = Class.Specializations
        .OrderBy(x => x.GetAbilities().Count(ability => ability.AbilityType != AbilityType.Other))
        .ToList();
    
    Solve(solution, abilityHotkeyPool, orderedSpecializations.Last(), Class.Core);

    foreach (var specialization in orderedSpecializations.SkipLast(1))
    {
      //Put back into the pool any hotkeys that were NOT used for the core class first so they can be used for the
      //new specialization.
      var coreHotkeys = solution.GetComponentHotkeys(Class.Core);
      abilityHotkeyPool.Hotkeys.AddRange(TransformAndOrderHotkeys().Where(x => !coreHotkeys.Contains(x)));
      Solve(solution, abilityHotkeyPool, specialization);
    }
      
    Console.WriteLine(solution.ToString());
  }

  private static void Solve(HotkeySolution solution, AbilityHotkeyPool abilityHotkeyPool, params ICharacterComponent[] components)
  {
    foreach (var component in components)
      abilityHotkeyPool.AddAbilities(component);
    
    AllocateReservedHotkeys(abilityHotkeyPool, solution);
    AllocateUnreservedHotkeys(abilityHotkeyPool, solution);
  }

  private static void AllocateReservedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolution solution)
  {
    foreach (var componentAbility in abilityHotkeyPool.ComponentAbilities.ToList())
    {
      if (abilityHotkeyPool.TryGetReservedHotkey(componentAbility.Ability, out var hotkey))
      {
        abilityHotkeyPool.Remove(componentAbility, hotkey);
        solution.AddHotkey(componentAbility, hotkey);
      }
    }
  }
  
  private static void AllocateUnreservedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolution solution)
  {
    var hotkeys = abilityHotkeyPool.Hotkeys.ToList();
    var hotkeyIndex = hotkeys.Count - 1;
    foreach (var ability in abilityHotkeyPool.ComponentAbilities.ToList())
    {
      var hotkey = hotkeys[hotkeyIndex];
      solution.AddHotkey(ability, hotkey);
      abilityHotkeyPool.Remove(ability, hotkey);
      hotkeyIndex--;
    }
  }

  private IEnumerable<Hotkey> TransformAndOrderHotkeys()
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