using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise05_ForLoopAgain;

namespace MyFirstProgram.Work.Tests.Exercise05_ForLoopAgain;

public class Exercise05Tests : Exercise0101TestsBase<Exercise05>
{
    [Test]
    public async Task Exercise05()
    {
        Run();

        await VerifyOutput();
    }
}