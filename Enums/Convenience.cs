namespace WoWHotkeySolver.Enums;

/// <summary>
/// How easy it is to press a button.
/// </summary>
public enum Convenience
{
  /// <summary>Reserved for abilities that are spammed constantly.</summary>
  Staple,

  /// <summary>Just an absolute pleasure to press.</summary>
  Incredible,

  Good,

  Average,

  Bad,

  Atrocious = 10000
}