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

    var specializationSolutions = new List<HotkeyAssignments>();
    specializationSolutions.Add(Solve(Hotkeys, specializationSolutions, orderedSpecializations.Last(),
      Class.Core));

    foreach (var specialization in orderedSpecializations.SkipLast(1))
      specializationSolutions.Add(Solve(Hotkeys, specializationSolutions, specialization, Class.Core));

    foreach (var solution in specializationSolutions)
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
    AllocateChildHotkeys(assignedHotkeys, abilityPool);
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
          if (assignments.TryAssign(ability, assignment))
            break;
  }
  
  private static void AllocateReservedHotkeys(HotkeyAssignments hotkeyAssignments, AbilityPool abilityPool,
    HotkeyPool hotkeyPool)
  {
    foreach (var ability in abilityPool.Abilities)
      foreach (var reservedHotkey in hotkeyPool.GetReservedHotkey(ability.Type))
        if (hotkeyAssignments.TryAssign(ability, new HotkeyInSlot(reservedHotkey, ability.Slot)))
          break;
  }
  
  private static void AllocateChildHotkeys(HotkeyAssignments assignedHotkeys, AbilityPool abilityPool)
  {
    foreach (var parent in abilityPool.Abilities)
    {
      if (parent.Child == null)
        continue;

      if (!assignedHotkeys.TryGetAssignment(parent, out var parentHotkeyAndSlot))
        continue;

      var parentHotkey = parentHotkeyAndSlot.Hotkey;
      var parentSlot = parentHotkeyAndSlot.Slot;
      assignedHotkeys.TryAssign(parent.Child, new HotkeyInSlot(parentHotkey with
      {
        Modifier = Modifier.Shift,
        Convenience = parentHotkey.Convenience.ApplyModifierPenalty(),
        AllowShiftModifier = false,
        ReservedForAbilityType = AbilityType.Other
      }, parentSlot));
    }
  }
  
  private static void AllocateUnreservedHotkeys(HotkeyAssignments assignments, AbilityPool abilityPool, HotkeyPool hotkeyPool)
  {
    foreach (var ability in abilityPool.Abilities.OrderBy(x => x.Frequency))
    {
      foreach (var hotkey in hotkeyPool.Hotkeys)
        if (assignments.TryAssign(ability, new HotkeyInSlot(hotkey, ability.Slot)))
          break;
    }
  }
}