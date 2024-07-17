using System.Text;
using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Services;

public sealed class HotkeySolution
{
  private readonly Dictionary<ComponentAbility, Hotkey> _hotkeys = new();
  
  public void AddHotkey(ComponentAbility componentAbility, Hotkey hotkey)
  {
    _hotkeys.Add(componentAbility, hotkey);
  }
  
  public override string ToString()
  {
    var stringBuilder = new StringBuilder();
    foreach (var characterComponent in _hotkeys.Keys.Select(x => x.Source).Distinct())
      AppendComponent(stringBuilder, characterComponent);
    
    return stringBuilder.ToString();
  }

  /// <summary>
  /// Gets all <see cref="Hotkey"/>s assigned for a particular <see cref="ICharacterComponent"/>.
  /// </summary>
  public List<Hotkey> GetComponentHotkeys(ICharacterComponent component)
  {
    return _hotkeys
      .Where(kvp => kvp.Key.Source == component)
      .Select(x => x.Value).ToList();
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
    {
      stringBuilder.AppendLine($"{componentAbility.Ability.Name}: {hotkey.ToString()}");
    }
  }
}