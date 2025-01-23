namespace WoWHotkeySolver.Enums;

public static class AbilitySlotExtensions
{
  public static string ToFriendlyString(this AbilitySlot modifier)
  {
    return modifier switch
    {
      AbilitySlot.All => "",
      AbilitySlot.Hostile => "(Hostile)",
      AbilitySlot.Friendly => "(Friendly)",
      AbilitySlot.Dead => "(Dead)",
      _ => throw new ArgumentOutOfRangeException(nameof(modifier), modifier, null)
    };
  }
}