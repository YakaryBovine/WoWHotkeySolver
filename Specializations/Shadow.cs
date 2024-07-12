using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Enums;

namespace WoWHotkeySolver.Specializations;

public static class Shadow
{
  public static List<Ability> GetAbilities()
  {
    var abilities = new List<Ability>
    {
      new()
      {
        Name = "Mindgames",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Devouring Plague",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Dispersion",
        Frequency = Frequency.Sometimes,
        AbilityType = AbilityType.PersonalDefensive
      },
      new()
      {
        Name = "Mind Flay/Flash Heal",
        Frequency = Frequency.Constant
      },
      new()
      {
        Name = "Vampiric Touch/Power Word: Shield",
        Frequency = Frequency.Frequent
      },
      new()
      {
        Name = "Void Eruption/Void Bolt",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Void Torrent",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Shadow Word: Death",
        Frequency = Frequency.Sometimes
      },
      new()
      {
        Name = "Shadowfiend",
        Frequency = Frequency.Rarely
      },
      new()
      {
        Name = "Shadow Crash",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.AoE
      },
      new()
      {
        Name = "Silence/Purify Disease",
        Frequency = Frequency.Frequent,
        AbilityType = AbilityType.Interrupt
      }
    };
    abilities.AddRange(Priest.GetAbilities());
    return abilities;
  }
}