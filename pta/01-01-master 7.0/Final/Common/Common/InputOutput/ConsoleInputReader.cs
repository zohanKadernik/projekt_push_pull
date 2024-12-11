namespace Common.InputOutput;

public class ConsoleInputReader : IInputReader
{
    public string ReadLine()
    {
        return Console.ReadLine() ?? "";
    }

    public ConsoleKey ReadKey()
    {
        return Console.ReadKey().Key;
    }
}