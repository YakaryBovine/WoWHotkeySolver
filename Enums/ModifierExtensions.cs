namespace WoWHotkeySolver.Enums;

public static class ModifierExtensions
{
  public static string ToFriendlyString(this Modifier modifier)
  {
    if (modifier == Modifier.None)
      return string.Empty;

    return modifier.ToString();
  }
}