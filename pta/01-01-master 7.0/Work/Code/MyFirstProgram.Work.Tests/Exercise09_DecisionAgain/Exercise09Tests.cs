using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise09_DecisionAgain;

namespace MyFirstProgram.Work.Tests.Exercise09_DecisionAgain;

public class Exercise09Tests : Exercise0101TestsBase<Exercise09>
{
    [Test]
    public async Task Exercise09_WhenInputLineIsWork()
    {
        StringInputReader.AddLine("work");
        StringInputReader.AddLine("3");

        Run();

        await VerifyOutput();
    }

    [Test]
    public async Task Exercise09_WhenInputLineIsOther()
    {
        StringInputReader.AddLine("foo");

        Run();

        await VerifyOutput();
    }
}