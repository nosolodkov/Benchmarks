using BenchmarkDotNet.Attributes;
using System.Text;

namespace Net7_Performance.Strings;

public class StringTest
{
    private readonly string[] _numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };


    [Benchmark]
    public string WithStringBuilder()
    {
        StringBuilder stringBuilder = new();
        foreach (string s in _numbers)
        {
            stringBuilder.Append(s);
            stringBuilder.Append(" ");
        }

        return stringBuilder.ToString();
    }

    [Benchmark]
    public string WithConcatenation()
    {
        string result = "";
        foreach (string s in _numbers)
        {
            result = result + s + " ";
        }

        return result;
    }

    [Benchmark]
    public string WithInterpolation()
    {
        string result = "";
        foreach (string s in _numbers)
        {
            result = $"{result}{s} ";
        }

        return result;
    }
}
