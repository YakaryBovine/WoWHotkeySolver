using WoWHotkeySolver;
using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Collections;
using WoWHotkeySolver.Services;

SolverService.Solve(new Monk(), new HotkeyPool(HotkeyProvider.GetAllHotkeys()));