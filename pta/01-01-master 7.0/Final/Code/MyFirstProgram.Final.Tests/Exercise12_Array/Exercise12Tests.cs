using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Exercise12_Array;

namespace MyFirstProgram.Final.Tests.Exercise12_Array;

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