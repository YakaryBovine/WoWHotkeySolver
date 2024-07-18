using System.Diagnostics.CodeAnalysis;
using WoWHotkeySolver.Enums;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

/// <summary>
/// A pool of abilities and hotkeys that can be allocated.
/// </summary>
public sealed class AbilityHotkeyPool
{
  public List<ComponentAbility> ComponentAbilities { get; private set; } = new();

  public List<Hotkey> Hotkeys { get; } = new();

  public void Remove(ComponentAbility ability, Hotkey hotkey)
  {
    ComponentAbilities.Remove(ability);
    Hotkeys.Remove(hotkey);
  }

  public void AddAbilities(ICharacterComponent component)
  {
    ComponentAbilities.AddRange(component.GetAbilities().Select(x => new ComponentAbility
    {
      Ability = x,
      Source = component
    }));
    ComponentAbilities = ComponentAbilities.OrderBy(x => x.Ability.Frequency).ToList();
  }
  
  /// <summary>
  /// Outputs a hotkey if it has been reserved for an ability of this type.
  /// </summary>
  public bool TryGetReservedHotkey(Ability ability, [NotNullWhen(true)] out Hotkey? hotkey)
  {
    hotkey = Hotkeys.FirstOrDefault(x =>
      x.ReservedForAbilityType != AbilityType.Other && x.ReservedForAbilityType == ability.AbilityType);
    return hotkey != null;
  }

  /// <summary>
  /// Print all hotkeys to console.
  /// </summary>
  public void WriteHotkeys()
  {
    Console.WriteLine("----Hotkeys----");
    var orderedHotkeys = Hotkeys
      .OrderBy(x => x.Convenience)
      .ThenBy(x => x.Modifier)
      .ThenBy(x => x.Key);
    foreach (var hotkey in orderedHotkeys)
    {
      Console.WriteLine(hotkey.ToString());
    }
    Console.WriteLine("");
  }
}