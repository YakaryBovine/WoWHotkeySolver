namespace WoWHotkeySolver.Models;

public interface ICharacterComponent
{
  public string Name { get; }
  
  public List<Ability> GetAbilities();
}