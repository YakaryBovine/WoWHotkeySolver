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
    foreach (var (ability, hotkey) in _abilityHotkeys)
    {
      stringBuilder.AppendLine($"{ability.Name}: {hotkey.Key}");
    }
    return stringBuilder.ToString();
  }
}