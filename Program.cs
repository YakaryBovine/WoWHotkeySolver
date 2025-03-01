﻿using WoWHotkeySolver;
using WoWHotkeySolver.CharacterClasses;
using WoWHotkeySolver.Collections;
using WoWHotkeySolver.Services;

var solverService = new SolverService
{
  Class = new Druid(),
  Hotkeys = new HotkeyPool(HotkeyProvider.GetAllHotkeys())
};

solverService.SolveAll();