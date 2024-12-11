using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Exercise10_Array;

namespace MyFirstProgram.Final.Tests.Exercise10_Array;

public class Exercise10Tests : Exercise0101TestsBase<Exercise10>
{
    [Test]
    public async Task Exercise10_WhenInputLineIsWork()
    {
        StringInputReader.AddLine("Let the force be with you");

        Run();

        await VerifyOutput();
    }
}