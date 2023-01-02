using BenchmarkDotNet.Attributes;

namespace ReplaceZeros
{
    [MemoryDiagnoser]
    public class MyBenchmarks
    {
        private const string shortInput = "1234500362000440";
        private const string longInput = "1234500362000440123450036200044012345003620004401234500362000440";

        [Benchmark]
        [Arguments(shortInput)]
        [Arguments(longInput)]
        public string replaceZerosBenchmark1(string value)
        {
            ReplaceZero replaceZero = new ReplaceZero();
            return replaceZero.replaceZeros_1(value);
        }

        [Benchmark]
        [Arguments(shortInput)]
        [Arguments(longInput)]
        public string replaceZerosBenchmark2(string value)
        {
            ReplaceZero replaceZero = new ReplaceZero();
            return replaceZero.replaceZeros_2(value);
        }
    }
}
