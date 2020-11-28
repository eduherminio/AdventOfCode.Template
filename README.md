# AdventOfCode.Template

Advent of Code template based on [AoCHelper](https://github.com/eduherminio/AoCHelper) project.

## Basic usage

- Create one class per advent day, following `DayXX` or `Day_XX` naming convention and implementing `AoCHelper.BaseDay`.
- Place input files under `Inputs/` dir, following `XX.txt` convention.

By default, all your problems will be solved when running the project. You can change that by behavior by replacing `Solver.SolveAll();` in `Program.cs` with:

-`Solver.Solve<Day_XX>();` → solves only day `XX`.

-`Solver.Solve(typeof(Day_XX), typeof(Day_YY));` → solves only days `XX` and `YY`.

-`Solver.Solve(new []{ typeof(Day_XX), typeof(Day_YY) });` → same as above.

## Advance usage

Check [AoCHelper README file](https://github.com/eduherminio/AoCHelper#advanced-usage) for detailed information about how to override the default file naming and location conventions of your problem classes and input files.
