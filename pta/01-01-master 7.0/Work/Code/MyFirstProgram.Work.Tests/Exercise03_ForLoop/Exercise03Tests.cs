using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise03_ForLoop;

namespace MyFirstProgram.Work.Tests.Exercise03_ForLoop;

public class Exercise03Tests : Exercise0101TestsBase<Exercise03>
{
    [Test]
    public async Task Exercise03()
    {
        Run();

        await VerifyOutput();
    }
}