namespace WoWHotkeySolver.Enums;

public static class ModifierExtensions
{
  public static string ToFriendlyString(this Modifier modifier) => modifier == Modifier.None ? string.Empty : $"{modifier} ";
}