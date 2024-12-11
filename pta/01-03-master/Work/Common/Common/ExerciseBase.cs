using Common.InputOutput;

namespace Common;

public abstract class ExerciseBase
{
    protected IInputReader InputReader = default!;
    protected IOutputWriter OutputWriter = default!;

    public void SetInputReader(IInputReader inputReader)
    {
        InputReader = inputReader;
    }

    public void SetOutputWriter(IOutputWriter inputWriter)
    {
        OutputWriter = inputWriter;
    }

    protected string ReadStringInput()
    {
        return ReadInput(GetStringInputColor(), input => input);
    }

    private static ConsoleColor GetStringInputColor()
    {
        return ConsoleColor.Green;
    }

    private T ReadInput<T>(ConsoleColor color, Func<string, T> getValue)
    {
        try
        {
            Console.ForegroundColor = color;
            OutputWriter.SignalEndLine();
            return getValue(InputReader.ReadLine());
        }
        finally
        {
            Console.ResetColor();
        }
    }

    protected int ReadIntInput()
    {
        return ReadInput(GetNumberInputColor(), int.Parse);
    }

    protected sbyte ReadSignedByteInput()
    {
        return ReadInput(GetNumberInputColor(), sbyte.Parse);
    }

    protected long ReadLongInput()
    {
        return ReadInput(GetNumberInputColor(), long.Parse);
    }

    protected ConsoleKey ReadKey()
    {
        return InputReader.ReadKey();
    }


    private static ConsoleColor GetNumberInputColor()
    {
        return ConsoleColor.DarkYellow;
    }
}