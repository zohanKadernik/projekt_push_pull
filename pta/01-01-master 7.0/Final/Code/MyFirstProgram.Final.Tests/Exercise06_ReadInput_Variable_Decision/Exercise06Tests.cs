using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Exercise06_ReadInput_Variable_Decision;

namespace MyFirstProgram.Final.Tests.Exercise06_ReadInput_Variable_Decision;

public class Exercise06Tests : Exercise0101TestsBase<Exercise06>
{
    [Test]
    public async Task Exercise06_WhenInputLineIsWork()
    {
        StringInputReader.AddLine("work");

        Run();

        await VerifyOutput();
    }

    [Test]
    public async Task Exercise06_WhenInputLineIsOther()
    {
        StringInputReader.AddLine("foo");

        Run();

        await VerifyOutput();
    }
}