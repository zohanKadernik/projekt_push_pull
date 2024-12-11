using System.Text;

namespace Common.InputOutput;

public class StringOutputWriter : IOutputWriter
{
    private readonly StringBuilder _stringBuilder = new StringBuilder();

    public void Write(string text)
    {
        _stringBuilder.Append(text);
    }

    public void WriteLine(string? text = null)
    {
        _stringBuilder.AppendLine(text);
    }

    public void Write<T>(T value)
    {
        _stringBuilder.Append(value);
    }

    public void WriteLine<T>(T? value = default)
    {
        _stringBuilder.AppendLine(value?.ToString());
    }

    public void SignalEndLine()
    {
        _stringBuilder.AppendLine();
    }

    public string GetText()
    {
        return _stringBuilder.ToString();
    }

    public void Clear()
    {
        _stringBuilder.Clear();
    }
}