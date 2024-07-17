namespace WoWHotkeySolver.Models;

/// <summary>
/// An <see cref="Ability"/> attached to a particular <see cref="ICharacterComponent"/>.
/// </summary>
public sealed class ComponentAbility
{
  public required Ability Ability { get; init; }
  
  public required ICharacterComponent Source { get; init; }

  public override string ToString() => $"{Source.Name}: {Ability.Name}";
}