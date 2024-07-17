namespace WoWHotkeySolver.Models;

public interface ICharacterClass
{
  public string Name { get; }
  
  public ICharacterComponent Core { get; }

  public List<ICharacterComponent> Specializations { get; }
}