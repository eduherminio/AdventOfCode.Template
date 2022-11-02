# AdventOfCode.Template

![CI](https://github.com/eduherminio/AdventOfCode.Template/workflows/CI/badge.svg)

Advent of Code template based on [AoCHelper](https://github.com/eduherminio/AoCHelper) project.

It allows you to focus on solving AoC puzzles while providing you with some performance stats.

Problem example:

```csharp
using AoCHelper;
using System.Threading.Tasks;

namespace AdventOfCode;

public class Day_01 : BaseDay
{
    public override ValueTask<string> Solve_1() => new("Solution 1");

    public override ValueTask<string> Solve_2() => new("Solution 2");
}

```

Output example:

![aochelper](https://user-images.githubusercontent.com/11148519/142051856-16d9d5bf-885c-44cd-94ae-6f678bcbc04f.gif)

## Basic usage

- Create one class per advent day, following `DayXX` or `Day_XX` naming convention and implementing `AoCHelper.BaseDay`.
- Place input files under `Inputs/` dir, following `XX.txt` convention.
- Read the input content from `InputFilePath` and solve the puzzle by implementing `Solve_1()` and `Solve_2()`!

**By default, only your last problem will be solved when running the project**. You can change that by behavior by modifying `Program.cs`.

Invoking **different methods**:

- `Solver.SolveAll();` → solves all the days.

- `Solver.SolveLast();` → solves only the last day.

- `Solver.Solve<Day_XX>();` → solves only day `XX`.

- `Solver.Solve(new uint[] { XX, YY });` → solves only days `XX` and `YY`.

- `Solver.Solve(new [] { typeof(Day_XX), typeof(Day_YY) });` → same as above.

Providing a **custom `Action<SolverConfiguration>`** to any of those methods ([availabe options described here](https://github.com/eduherminio/AoCHelper#customization)):

- `Solver.SolveLast(opt => opt.ClearConsole = false);` → solves only the last day providing a custom configuration.

-
    ```csharp
    Solver.SolveAll(opt =>
    {
        opt.ShowConstructorElapsedTime = true;
        opt.ShowTotalElapsedTimePerDay = true;
        opt.ElapsedTimeFormatSpecifier = "F3";
    });
    ```
    solves all the days providing a custom configuration.

## Advanced usage

Check [AoCHelper README file](https://github.com/eduherminio/AoCHelper#advanced-usage) for detailed information about how to override the default file naming and location conventions of your problem classes and input files.
