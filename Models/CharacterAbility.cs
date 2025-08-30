namespace WoWHotkeySolver.Models;

public record CharacterAbility
{
  public required ICharacterComponent Specialization { get; init; }

  public required Ability Ability { get; init; }
}