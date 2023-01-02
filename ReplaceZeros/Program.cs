using BenchmarkDotNet.Running;
using ReplaceZeros;
using System.Text;

//ReplaceZero replaceZero = new ReplaceZero();

//var result = replaceZero.replaceZeros_2("1234500362000440");
//var result = replaceZeros("123450036200044");
//var result = replaceZeros("000000000000");
//var result = replaceZeros("123456789");

//Console.WriteLine(result);



var summary = BenchmarkRunner.Run<MyBenchmarks>();

Console.ReadKey();