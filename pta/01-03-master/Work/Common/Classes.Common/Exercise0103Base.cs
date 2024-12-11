using Common;

namespace Classes.Common;

public abstract class Exercise0103Base : ExerciseBase
{
    protected void Write(string text)
    {
        OutputWriter.Write(text);
    }

    protected void WriteLine(string? text = null)
    {
        OutputWriter.WriteLine(text);
    }
}