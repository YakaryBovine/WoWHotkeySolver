using WoWHotkeySolver;
using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Services;

var solverService = new SolverService
{
  Class = new Druid(),
  Hotkeys = HotkeyProvider.GetAllHotkeys()
};

solverService.SolveAll();