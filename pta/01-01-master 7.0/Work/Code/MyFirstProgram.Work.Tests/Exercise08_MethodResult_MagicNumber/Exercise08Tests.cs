using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise08_MethodResult_MagicNumber;

namespace MyFirstProgram.Work.Tests.Exercise08_MethodResult_MagicNumber;

public class Exercise08Tests : Exercise0101TestsBase<Exercise08>
{
    [Test]
    public async Task Exercise08_WhenInputLineIsWork()
    {
        StringInputReader.AddLine("work");
        StringInputReader.AddLine("3");

        Run();

        await VerifyOutput();
    }

    [Test]
    public async Task Exercise08_WhenInputLineIsOther()
    {
        StringInputReader.AddLine("foo");

        Run();

        await VerifyOutput();
    }
}