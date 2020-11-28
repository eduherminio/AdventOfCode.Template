using AoCHelper;
using System.IO;

namespace AdventOfCode
{
    public class Day_26 : BaseDay
    {
        private readonly string _input;

        public Day_26()
        {
            _input = File.ReadAllText(InputFilePath);
        }

        public override string Solve_1() => _input.Length.ToString();

        public override string Solve_2() => throw new System.NotImplementedException();
    }
}
