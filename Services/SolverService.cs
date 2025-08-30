using WoWHotkeySolver.Collections;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class SolverService
{
  public static void Solve(ICharacterClass characterClass, HotkeyPool hotkeys)
  {
    var hotkeyAssignments = new List<HotkeyAssignment>();
    var allAbilities = GetAllAbilities(characterClass);
    SolveReservedAbilities(allAbilities, hotkeys, hotkeyAssignments);
    SolveRemainingAbilities(allAbilities, hotkeys, hotkeyAssignments);

    var sortedAssignments = hotkeyAssignments.OrderBy(x => x.Specialization.Name).ThenBy(x => x.Ability.Frequency);
    foreach (var sortedAssignment in sortedAssignments)
    {
      Console.WriteLine(sortedAssignment);
    }
  }

  private static void SolveReservedAbilities(List<CharacterAbility> allAbilities, HotkeyPool hotkeys, List<HotkeyAssignment> assignments)
  {
    var typedAbilities = allAbilities
      .Where(x => x.Ability.Type != AbilityType.Other)
      .Where(x => !IsAbilityAssigned(assignments, x.Ability))
      .OrderBy(x => x.Ability.Frequency);

    foreach (var ability in typedAbilities)
    {
      var reservedHotkeys = hotkeys.GetReservedHotkey(ability.Ability.Type).Where(x =>
        !IsHotkeyAssigned(assignments, x, ability.Ability.Slot, ability.Specialization));

      foreach (var reservedHotkey in reservedHotkeys)
        if (TryAssignHotkeyToClass(allAbilities, ability.Ability, reservedHotkey, assignments))
          break;
    }
  }
  
  private static void SolveRemainingAbilities(List<CharacterAbility> allAbilities, HotkeyPool hotkeys, List<HotkeyAssignment> assignments)
  {
    var unassignedAbilities = allAbilities
      .Where(x => x.Ability.Type == AbilityType.Other)
      .Where(x => !IsAbilityAssigned(assignments, x.Ability))
      .OrderBy(x => x.Ability.Frequency);

    foreach (var ability in unassignedAbilities)
    {
      var availableHotkeys = hotkeys.Hotkeys.Where(x =>
        !IsHotkeyAssigned(assignments, x, ability.Ability.Slot, ability.Specialization));

      foreach (var reservedHotkey in availableHotkeys)
        if (TryAssignHotkeyToClass(allAbilities, ability.Ability, reservedHotkey, assignments))
          break;
    }
  }
  
  /// <summary>
  /// Assign a hotkey to an ability for an entire class.
  /// <remarks>The hotkey will always be assigned for the specialization specified in the provided <see cref="CharacterAbility"/>.
  /// If any other specs in the class have an ability with the same priority and type, it will be assigned for them too.</remarks>
  /// </summary>
  private static bool TryAssignHotkeyToClass(List<CharacterAbility> allAbilities, Ability abilityToAssign, Hotkey hotkeyToAssign, List<HotkeyAssignment> assignments)
  {
    var matchingCharacterAbilities = allAbilities.Where(x => x.Ability == abilityToAssign);
    var assignmentsMade = 0;
    foreach (var matchingAbility in matchingCharacterAbilities)
    {
      if (IsHotkeyAssigned(assignments, hotkeyToAssign, matchingAbility.Ability.Slot, matchingAbility.Specialization))
        continue;

      if (IsAbilityAssigned(assignments, abilityToAssign, matchingAbility.Specialization))
        continue;

      assignments.Add(new HotkeyAssignment
      {
        Specialization = matchingAbility.Specialization,
        Ability = abilityToAssign,
        Hotkey = hotkeyToAssign
      });
      assignmentsMade += 1;
    }

    return assignmentsMade != 0;
  }
  
  /// <summary>
  /// Returns all abilities held by a class.
  /// </summary>
  private static List<CharacterAbility> GetAllAbilities(ICharacterClass characterClass)
  {
    var allAbilities = new List<CharacterAbility>();
    
    foreach (var specialization in characterClass.Specializations)
    {
      allAbilities.AddRange(specialization.GetAbilities().Select(x => new CharacterAbility
      {
        Ability = x,
        Specialization = specialization
      }));
      allAbilities.AddRange(characterClass.Core.GetAbilities().Select(x => new CharacterAbility
      {
        Ability = x,
        Specialization = specialization
      }));
    }
    
    return allAbilities;
  }
  
  private static bool IsHotkeyAssigned(List<HotkeyAssignment> assignments, Hotkey hotkey, AbilitySlot slot, ICharacterComponent spec)
  {
    return assignments.Any(x => x.Hotkey == hotkey && x.Specialization == spec && DoesAbilityOccupySlot(x.Ability, slot));

    bool DoesAbilityOccupySlot(Ability ability, AbilitySlot candidateSlot)
    {
      if (candidateSlot == AbilitySlot.All)
        return true;

      if (ability.Slot == AbilitySlot.All)
        return true;

      return ability.Slot == candidateSlot;
    }
  }

  private static bool IsAbilityAssigned(List<HotkeyAssignment> assignments, Ability ability)
  {
    return assignments.Any(x => x.Ability == ability);
  }
  
  private static bool IsAbilityAssigned(List<HotkeyAssignment> assignments, Ability ability, ICharacterComponent spec)
  {
    return assignments.Any(x => x.Ability == ability && x.Specialization == spec);
  }
}