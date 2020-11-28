using AoCHelper;
using System.IO;

namespace AdventOfCode
{
    public class Day_01 : BaseDay
    {
        private readonly string _input;

        public Day_01()
        {
            _input = File.ReadAllText(InputFilePath);
        }

        public override string Solve_1() => $"Solution to {ClassPrefix} {CalculateIndex()}, part 1";

        public override string Solve_2() => $"Solution to {ClassPrefix} {CalculateIndex()}, part 2";
    }
}
