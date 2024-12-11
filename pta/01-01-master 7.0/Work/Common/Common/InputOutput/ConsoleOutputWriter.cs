namespace Common.InputOutput;

public class ConsoleOutputWriter : IOutputWriter
{
    public void Write<T>(T value)
    {
        Console.Write(value);
    }

    public void WriteLine<T>(T? value = default)
    {
        Console.WriteLine(value);
    }

    public void SignalEndLine()
    {

    }
}