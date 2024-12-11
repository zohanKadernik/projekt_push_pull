using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise07_ReadNumericInput;

namespace MyFirstProgram.Work.Tests.Exercise07_ReadNumericInput;

public class Exercise07Tests : Exercise0101TestsBase<Exercise07>
{
    [Test]
    public async Task Exercise07_WhenInputLineIsWork()
    {
        StringInputReader.AddLine("work");
        StringInputReader.AddLine("3");

        Run();

        await VerifyOutput();
    }

    [Test]
    public async Task Exercise07_WhenInputLineIsOther()
    {
        StringInputReader.AddLine("foo");

        Run();

        await VerifyOutput();
    }
}