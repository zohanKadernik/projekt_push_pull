using Common.Tests;

namespace Classes.Common.Tests;

public abstract class Exercise0103TestsBase : ExerciseTestsBase
{

}

public abstract class Exercise0103TestsBase<TExercise> : ExerciseTestsBase<TExercise>
    where TExercise : Exercise0103Base, new()
{
    protected Type ExerciseType => Exercise.GetType();
}