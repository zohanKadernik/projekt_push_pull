using Common.Tests;

namespace MyFirstProgram.Common.Tests;

public abstract class Exercise0101TestsBase<TExercise> : ExerciseTestsBase<TExercise>
    where TExercise : Exercise0101Base, new()
{
    protected void Run()
    {
        Exercise.Run();
    }
}