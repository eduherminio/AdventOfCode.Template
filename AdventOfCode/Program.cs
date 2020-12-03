using AoCHelper;
using System.Linq;

if (args.Length == 0)       // dotnet run
{
    Solver.SolveLast();
}
else if (args.Length == 1 && args[0].Contains("all", System.StringComparison.CurrentCultureIgnoreCase))     // dotnet run all | dotnet run --all
{
    Solver.SolveAll();
}
else        // dotnet run 1 2 5 10
{
    var indexes = args.Select(arg => uint.TryParse(arg, out var index) ? index : uint.MaxValue);

    Solver.Solve(indexes.Where(i => i < uint.MaxValue));
}
