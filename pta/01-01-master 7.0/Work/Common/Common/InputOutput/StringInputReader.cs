namespace Common.InputOutput;

public class StringInputReader : IInputReader
{
    private readonly List<string> _lines = new List<string>();
    private readonly List<ConsoleKey> _keys = new List<ConsoleKey>();
    private int _lineIndex = 0;
    private int _keyIndex = 0;

    public void AddLine(string line)
    {
        _lines.Add(line);
    }

    public void AddKey(ConsoleKey key)
    {
        _keys.Add(key);
    }

    public string ReadLine()
    {
        return _lines[_lineIndex++];
    }

    public ConsoleKey ReadKey()
    {
        return _keys[_keyIndex++];
    }
}