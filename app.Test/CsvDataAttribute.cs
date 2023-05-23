using System.Reflection;
using Xunit.Sdk;

namespace app.Test;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class CsvDataAttribute : DataAttribute
{
    private readonly string _filePath;
    private readonly bool _hasHeaderRow;

    public CsvDataAttribute(string filePath, bool hasHeaderRow = false)
    {
        _filePath = filePath;
        _hasHeaderRow = hasHeaderRow;   
    }

    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        var csvData = File.ReadAllLines(_filePath);
        var lines = _hasHeaderRow ? csvData.Skip(1) : csvData;
        foreach (var line in lines)
        {
            var values = line.Split(',');

            yield return values;
        }
    }
}
