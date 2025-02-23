namespace WoWHotkeySolver.Enums;

public enum AbilityType
{
  Other,
  PrimaryBuilder,
  SecondaryBuilder,
  Interrupt,
  Movement,
  Stun,
  ExternalDefensive,
  HealingPotion,
  Healthstone,
  PersonalDefensive,
  CombatPotion,
  OpieMenu,
  Taunt,
  Trinket,
  
  /// <summary>An ability that deals damage or heals in a radius.</summary>
  AoE,
  
  /// <summary>The same as <see cref="AoE"/>, but the ground-targeted version.</summary>
  AoETargeted,
  
  /// <summary>The main ability you use to spend your core resource.</summary>
  MainSpender,
  
  /// <summary>A primary damage cooldown with a cooldown between 1 and 1.5 minutes.</summary>
  ShortPrimaryCooldown,

  Form1,

  Form2
}