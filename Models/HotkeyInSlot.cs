using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Models;

public record HotkeyInSlot(Hotkey Hotkey, AbilitySlot Slot)
{
  public override string ToString() => $"{Hotkey.Key} ({Slot})";
}
