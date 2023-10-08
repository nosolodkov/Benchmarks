using BenchmarkDotNet.Attributes;
using Microsoft.VisualBasic;

namespace Net7_Performance.Enums;

public class EnumTest
{
    private readonly DayOfWeek _dayOfWeek = DayOfWeek.Sunday;


    [Benchmark]
    public bool IsDefined() => Enum.IsDefined(_dayOfWeek);

    [Benchmark]
    public string? GetName() => Enum.GetName(_dayOfWeek);

    [Benchmark]
    public string[] GetNames() => Enum.GetNames<DayOfWeek>();

    [Benchmark]
    public DayOfWeek[] GetValues() => Enum.GetValues<DayOfWeek>();

    [Benchmark]
    public string EnumToString() => _dayOfWeek.ToString();

    [Benchmark]
    public bool TryParse() => Enum.TryParse<FirstDayOfWeek>("Sunday", out _);
}
