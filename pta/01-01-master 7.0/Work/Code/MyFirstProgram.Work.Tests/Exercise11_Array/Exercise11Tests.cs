using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise11_Array;

namespace MyFirstProgram.Work.Tests.Exercise11_Array;

public class Exercise11Tests : Exercise0101TestsBase<Exercise11>
{
    [Test]
    public async Task Exercise11()
    {
        Run();

        await VerifyOutput();
    }
}