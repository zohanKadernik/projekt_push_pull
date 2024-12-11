using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise12_Array;

namespace MyFirstProgram.Work.Tests.Exercise12_Array;

public class Exercise11Tests : Exercise0101TestsBase<Exercise12>
{
    [Test]
    public async Task Exercise12()
    {
        StringInputReader.AddLine("Let the force be with you");

        Run();

        await VerifyOutput();
    }
}