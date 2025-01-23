using WoWHotkeySolver.Models;

namespace WoWHotkeySolver.Collections;

/// <summary>
/// An ordered list of abilities that can be allocated.
/// </summary>
public sealed class AbilityPool
{
  public List<Ability> Abilities { get; } = new();

  public AbilityPool(IEnumerable<ICharacterComponent> components)
  {
    foreach (var component in components) 
      Abilities.AddRange(component.GetAbilities());
    
    Abilities = Abilities.OrderBy(x => x.Frequency).ToList();
  }
}