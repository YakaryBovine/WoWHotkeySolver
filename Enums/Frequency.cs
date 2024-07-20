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
  
  /// <summary>Used every 15 seconds or so.</summary>
  Semifrequent,
  
  /// <summary>Used every minute or so.</summary>
  Infrequent,
  
  /// <summary>Has a cooldown of 2-3 minutes.</summary>
  Rarely,
  
  /// <summary>There's usually not a good reason to use this at all.</summary>
  AlmostNever
}