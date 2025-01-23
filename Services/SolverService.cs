using WoWHotkeySolver.Collections;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public required ICharacterClass Class { get; init; }
  
  public required HotkeyPool Hotkeys { get; init; }

  public void SolveAll()
  {
    //Order the specialization with the most reserved abilities first to ensure that core abilities can't take the
    //hotkeys they need.
    var orderedSpecializations = Class.Specializations
        .OrderBy(x => x.GetAbilities().Count(ability => ability.Type != AbilityType.Other))
        .ToList();

    var specializatiionSolutions = new List<HotkeyAssignments>();
    specializatiionSolutions.Add(Solve(Hotkeys, specializatiionSolutions, orderedSpecializations.Last(),
      Class.Core));

    foreach (var specialization in orderedSpecializations.SkipLast(1))
      specializatiionSolutions.Add(Solve(Hotkeys, specializatiionSolutions, specialization, Class.Core));

    foreach (var solution in specializatiionSolutions)
      Console.WriteLine(solution.ToString());
  }

  /// <summary>
  /// Provides hotkey assignments for all abilities the provided character has.
  /// </summary>
  /// <param name="hotkeyPool">The hotkeys available to the player.</param>
  /// <param name="previousSolutions">Solutions made for previous specializations, which may be reused for this one.</param>
  /// <param name="characterComponents">Any number of components which together form a character.</param>
  /// <returns>A set of hotkeys assigned to abilities.</returns>
  private static HotkeyAssignments Solve(HotkeyPool hotkeyPool, List<HotkeyAssignments> previousSolutions, params ICharacterComponent[] characterComponents)
  {
    var assignedHotkeys = new HotkeyAssignments
    {
      Title = characterComponents.First().Name
    };
    var abilityPool = new AbilityPool(characterComponents);
    
    AllocateAlreadySolvedHotkeys(assignedHotkeys, abilityPool, previousSolutions);
    AllocateReservedHotkeys(assignedHotkeys, abilityPool, hotkeyPool);
    AllocateUnreservedHotkeys(assignedHotkeys, abilityPool, hotkeyPool);

    return assignedHotkeys;
  }

  /// <summary>
  /// Allocate any hotkeys that have already been solved for another component.
  /// <remarks>Abilities are only assigned to the same hotkey if they share the same name AND frequency.</remarks>
  /// </summary>
  private static void AllocateAlreadySolvedHotkeys(HotkeyAssignments assignments, AbilityPool abilityPool,
    List<HotkeyAssignments> previousSolutions)
  {
    foreach (var ability in abilityPool.Abilities)
      foreach (var previousSolution in previousSolutions)
        if (previousSolution.TryGetAssignment(ability, out var assignment))
          if (assignments.TryAssign(ability, assignment.Value))
            break;
  }
  
  private static void AllocateReservedHotkeys(HotkeyAssignments hotkeyAssignments, AbilityPool abilityPool,
    HotkeyPool hotkeyPool)
  {
    foreach (var ability in abilityPool.Abilities)
      foreach (var reservedHotkey in hotkeyPool.GetReservedHotkey(ability.Type))
        if (hotkeyAssignments.TryAssign(ability, reservedHotkey))
          break;
  }
  
  private static void AllocateUnreservedHotkeys(HotkeyAssignments assignments, AbilityPool abilityPool, HotkeyPool hotkeyPool)
  {
    foreach (var ability in abilityPool.Abilities)
      foreach (var hotkey in hotkeyPool.Hotkeys)
        if (assignments.TryAssign(ability, hotkey))
          break;
  }
}