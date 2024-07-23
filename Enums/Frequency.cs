namespace WoWHotkeySolver.Enums;

/// <summary>
/// How often a button has to be pressed.
/// </summary>
public enum Frequency
{
  /// <summary>Low-cooldown, spammable filler.</summary>
  Constant,
      
  /// <summary>Used every 3-4 casts or so.</summary>
  Frequent,
  
  /// <summary>Has a cooldown of 20 seconds or less.</summary>
  Semifrequent,
  
  /// <summary>Has a cooldown between 21 seconds and a minute.</summary>
  Infrequent,
  
  /// <summary>Has a cooldown greater than a minute.</summary>
  Rarely,
  
  /// <summary>There's usually not a good reason to use this at all.</summary>
  AlmostNever
}