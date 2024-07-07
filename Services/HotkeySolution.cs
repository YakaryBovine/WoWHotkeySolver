using System.Text;

namespace WoWHotkeySolver.Services;

public sealed class HotkeySolution
{
  private readonly Dictionary<Ability, Hotkey> _abilityHotkeys = new();

  public void AddHotkey(Ability ability, Hotkey hotkey)
  {
    _abilityHotkeys.Add(ability, hotkey);
  }
  
  public override string ToString()
  {
    var stringBuilder = new StringBuilder();
    var sortedAbilityHotkeys = _abilityHotkeys.OrderBy(x => x.Key.Frequency);
    foreach (var (ability, hotkey) in sortedAbilityHotkeys)
    {
      stringBuilder.AppendLine($"{ability.Name}: {hotkey.ToString()}");
    }
    return stringBuilder.ToString();
  }
}