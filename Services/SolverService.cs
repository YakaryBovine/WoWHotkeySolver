using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public required ICharacterClass Class { get; init; }
  
  public required List<Hotkey> Hotkeys { get; init; }

  public void SolveAll()
  {
    var solution = new HotkeySolutionSet();
    var abilityHotkeyPool = new AbilityHotkeyPool();
    abilityHotkeyPool.Hotkeys.AddRange(TransformAndOrderHotkeys());
    //Order the specialization with the most reserved abilities first to ensure that core abilities can't take the
    //hotkeys they need.
    var orderedSpecializations = Class.Specializations
        .OrderBy(x => x.GetAbilities().Count(ability => ability.AbilityType != AbilityType.Other))
        .ToList();
    
    Solve(solution, abilityHotkeyPool, Class.Core, orderedSpecializations.Last());

    foreach (var specialization in orderedSpecializations.SkipLast(1))
    {
      //Put back into the pool any hotkeys that were NOT used for the core class first so they can be used for the
      //new specialization.
      var coreHotkeys = solution.GetComponentHotkeys(Class.Core);
      abilityHotkeyPool.Hotkeys.Clear();
      abilityHotkeyPool.Hotkeys.AddRange(TransformAndOrderHotkeys().Where(x => !coreHotkeys.Contains(x)));
      Solve(solution, abilityHotkeyPool, specialization);
    }
      
    Console.WriteLine(solution.ToString());
  }

  private static void Solve(HotkeySolutionSet solutionSet, AbilityHotkeyPool abilityHotkeyPool, params ICharacterComponent[] components)
  {
    foreach (var component in components)
      abilityHotkeyPool.AddAbilities(component);
    
    AllocateAlreadySolvedHotkeys(abilityHotkeyPool, solutionSet);
    AllocateReservedHotkeys(abilityHotkeyPool, solutionSet);
    AllocateUnreservedHotkeys(abilityHotkeyPool, solutionSet);
  }

  /// <summary>
  /// Allocate any hotkeys that have already been solved for another specialization, but which are not core abilities.
  /// <para>Hotkey solutions can only be reused if both specializations have the same ability with the same frequency.</para>
  /// </summary>
  private static void AllocateAlreadySolvedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolutionSet solutionSet)
  {
    foreach (var componentAbility in abilityHotkeyPool.ComponentAbilities.ToList())
      if (solutionSet.TryGetAllocation(componentAbility.Ability, out var solution)) 
        AllocateHotkey(solutionSet, abilityHotkeyPool, componentAbility, solution.Value.Hotkey);
  }
  
  private static void AllocateReservedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolutionSet solutionSet)
  {
    foreach (var componentAbility in abilityHotkeyPool.ComponentAbilities.ToList())
      if (abilityHotkeyPool.TryGetReservedHotkey(componentAbility.Ability, out var hotkey)) 
        AllocateHotkey(solutionSet, abilityHotkeyPool, componentAbility, hotkey.Value);
  }
  
  private static void AllocateUnreservedHotkeys(AbilityHotkeyPool abilityHotkeyPool, HotkeySolutionSet solutionSet)
  {
    var hotkeys = abilityHotkeyPool.Hotkeys.ToList();
    var hotkeyIndex = hotkeys.Count - 1;
    foreach (var ability in abilityHotkeyPool.ComponentAbilities.ToList())
    {
      var hotkey = hotkeys[hotkeyIndex];
      AllocateHotkey(solutionSet, abilityHotkeyPool, ability, hotkey);
      hotkeyIndex--;
    }
  }
  
  private static void AllocateHotkey(HotkeySolutionSet solutionSet, AbilityHotkeyPool abilityHotkeyPool,
    ComponentAbility componentAbility,  Hotkey hotkey)
  {
    abilityHotkeyPool.Remove(componentAbility, hotkey);
    solutionSet.Allocate(componentAbility, hotkey);
  }

  private IEnumerable<Hotkey> TransformAndOrderHotkeys()
  {
    var hotkeys = Hotkeys.ToList();
    hotkeys.AddRange(Hotkeys.Where(x => x.AllowShiftModifier && x.Modifier == Modifier.None).Select(h => new Hotkey
    {
      Key = $"{h.Key}",
      Convenience = h.Convenience.ApplyModifierPenalty(),
      AllowShiftModifier = false,
      Modifier = Modifier.Shift,
      ReservedForAbilityType = AbilityType.Other
    }));
    return hotkeys.OrderByDescending(x => x.Convenience).ToList();
  }
}