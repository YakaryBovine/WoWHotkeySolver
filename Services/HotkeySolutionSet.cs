using System.Diagnostics.CodeAnalysis;
using System.Text;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class HotkeySolutionSet
{
  private readonly Dictionary<ComponentAbility, Hotkey> _hotkeys = new();

  public void Allocate(ComponentAbility componentAbility, Hotkey hotkey)
  {
    _hotkeys.Add(componentAbility, hotkey);
  }

  /// <summary>
  ///   Gets the hotkey solution for the specified ability, regardless of which <see cref="ICharacterComponent" />
  ///   it was assigned to.
  /// </summary>
  public bool TryGetAllocation(Ability ability,
    [NotNullWhen(true)] out (ComponentAbility ComponentAbility, Hotkey Hotkey)? solution)
  {
    var solutionKvp = _hotkeys.FirstOrDefault(x => x.Key.Ability.Equals(ability));
    solution = null;
    if (solutionKvp.Key == null)
      return false;

    solution = (solutionKvp.Key, solutionKvp.Value);
    return true;
  }

  /// <summary>
  ///   Gets all <see cref="Hotkey" />s assigned for a particular <see cref="ICharacterComponent" />.
  /// </summary>
  public List<Hotkey> GetComponentHotkeys(ICharacterComponent component)
  {
    return _hotkeys
      .Where(kvp => kvp.Key.Source == component)
      .Select(x => x.Value).ToList();
  }

  public override string ToString()
  {
    var stringBuilder = new StringBuilder();
    foreach (var characterComponent in _hotkeys.Keys.Select(x => x.Source).Distinct())
      AppendComponent(stringBuilder, characterComponent);

    return stringBuilder.ToString();
  }
  
  private void AppendComponent(StringBuilder stringBuilder, ICharacterComponent component)
  {
    stringBuilder.AppendLine($"----{component.Name}----");
    var sortedAbilityHotkeys = _hotkeys
      .Where(x => x.Key.Source == component)
      .OrderBy(x => x.Value.Modifier)
      .ThenBy(x => x.Value.Convenience)
      .ThenBy(x => x.Value.Key);
    foreach (var (componentAbility, hotkey) in sortedAbilityHotkeys)
      stringBuilder.AppendLine($"{componentAbility.Ability.Name}: {hotkey.ToString()}");
  }
}