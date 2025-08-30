namespace WoWHotkeySolver.Models;

public interface ICharacterClass
{
  public ICharacterComponent Core { get; }

  public List<ICharacterComponent> Specializations { get; }
}