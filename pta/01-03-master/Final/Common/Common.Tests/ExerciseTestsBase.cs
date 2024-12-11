using System.Reflection;
using System.Runtime.CompilerServices;
using Common.InputOutput;

namespace Common.Tests;

public abstract class ExerciseTestsBase
{

}

public abstract class ExerciseTestsBase<TExercise> : ExerciseTestsBase
    where TExercise : ExerciseBase, new()
{
    protected StringOutputWriter StringOutputWriter = default!;
    protected StringInputReader StringInputReader = default!;
    protected TExercise Exercise = default!;

    protected Type ExerciseType => Exercise.GetType();
    protected Assembly ExerciseAssembly => Exercise.GetType().Assembly;

    [SetUp]
    public void SetUp()
    {
        StringOutputWriter = new StringOutputWriter();
        StringInputReader = new StringInputReader();
        Exercise = new TExercise();
        Exercise.SetInputReader(StringInputReader);
        Exercise.SetOutputWriter(StringOutputWriter);
    }

    protected async Task VerifyOutput([CallerFilePath] string sourceFile = "")
    {
        await StringOutputWriter.GetText().Verify(sourceFile);
    }
}