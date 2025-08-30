using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Models;

public sealed class HotkeyAssignment
{
  public required ICharacterComponent Specialization { get; init; }
  
  public required Ability Ability { get; init; }
  
  public required Hotkey Hotkey { get; init; }

  public override string ToString()
  {
    return $"{Specialization.Name}|{Ability.Name}: {Hotkey} {Ability.Slot.ToFriendlyString()}";
  }
}