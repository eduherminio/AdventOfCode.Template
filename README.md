# AdventOfCode.Template

![CI](https://github.com/eduherminio/AdventOfCode.Template/workflows/CI/badge.svg)

Advent of Code template based on [AoCHelper](https://github.com/eduherminio/AoCHelper) project.

It allows you to focus on solving AoC puzzles while providing you with some performance stats.  

Problem example:

```csharp
using AoCHelper;
using System.IO;

namespace AdventOfCode
{
    public class Day_01 : BaseDay
    {
        public override string Solve_1() => $"Solution 1";

        public override string Solve_2() => $"Solution 2";
    }
}
```

Output example:

![image](https://user-images.githubusercontent.com/11148519/100517610-0987a880-318c-11eb-897d-6278a440fd44.png)

## Basic usage

- Create one class per advent day, following `DayXX` or `Day_XX` naming convention and implementing `AoCHelper.BaseDay`.
- Place input files under `Inputs/` dir, following `XX.txt` convention.
- Read the input content from `InputFilePath` and solve the puzzle by implementing `Solve_1()` and `Solve_2()`!

By default, all your problems will be solved when running the project. You can change that by behavior by replacing `Solver.SolveAll();` in `Program.cs` with:

-`Solver.SolveLast();` → solves only the last day.

-`Solver.Solve<Day_XX>();` → solves only day `XX`.

-`Solver.Solve(typeof(Day_XX), typeof(Day_YY));` → solves only days `XX` and `YY`.

-`Solver.Solve(new []{ typeof(Day_XX), typeof(Day_YY) });` → same as above.

## Advance usage

Check [AoCHelper README file](https://github.com/eduherminio/AoCHelper#advanced-usage) for detailed information about how to override the default file naming and location conventions of your problem classes and input files.
