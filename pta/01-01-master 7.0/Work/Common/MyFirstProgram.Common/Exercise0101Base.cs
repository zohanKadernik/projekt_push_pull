using Common;

namespace MyFirstProgram.Common;

public abstract class Exercise0101Base : ExerciseBase
{
    public abstract void Run();

    protected void WriteWord(int number)
    {
        WriteWord(number.ToString());
    }

    protected void WriteWord(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            throw new InvalidOperationException("Word cannot be empty string");
        }

        if (text.Contains(" "))
        {
            throw new InvalidOperationException("Text cannot contains more than one word");
        }
        OutputWriter.Write(text);
    }

    protected void WriteSpace()
    {
        OutputWriter.Write(" ");
    }

    protected void WriteNewLine()
    {
        OutputWriter.Write(Environment.NewLine);
    }

    private readonly byte[] _random = { 2, 4, 3, 1, 8, 5, 6, 9, 7, 2, 8, 4, 3, 1, 9, 7, 5, 6 };
    private int _getRandomNumberIndex = 0;
    protected int GetRandomNumber(int first, int last)
    {
        int number = _random[_getRandomNumberIndex++];
        int randomNumber = (number - 1 + first) % (last + 1);
        return randomNumber;
    }
}