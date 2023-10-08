using BenchmarkDotNet.Running;
using Net7_Performance.Enums;
using Net7_Performance.Strings;

BenchmarkRunner.Run<StringTest>();
BenchmarkRunner.Run<EnumTest>();

Console.WriteLine("Benchmark competed!");
