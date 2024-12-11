using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Exercise11_Array;

namespace MyFirstProgram.Final.Tests.Exercise11_Array;

public class Exercise11Tests : Exercise0101TestsBase<Exercise11>
{
    [Test]
    public async Task Exercise11()
    {
        Run();

        await VerifyOutput();
    }
}