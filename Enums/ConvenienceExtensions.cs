namespace WoWHotkeySolver.Enums;

public static class ConvenienceExtensions
{
  private const int Penalty = 1000;
  
  /// <summary>
  /// Returns a <see cref="Convenience"/> which is substantially less convenient than the provided one.
  /// </summary>
  public static Convenience ApplyModifierPenalty(this Convenience convenience) => convenience + Penalty;
}