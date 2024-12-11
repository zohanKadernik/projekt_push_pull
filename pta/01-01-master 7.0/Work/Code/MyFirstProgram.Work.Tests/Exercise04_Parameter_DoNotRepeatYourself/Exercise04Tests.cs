using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise04_MethodParameter_DoNotRepeatYourself;

namespace MyFirstProgram.Work.Tests.Exercise04_MethodParameter_DoNotRepeatYourself;

public class Exercise04Tests : Exercise0101TestsBase<Exercise04>
{
    [Test]
    public async Task Exercise04()
    {
        Run();

        await VerifyOutput();
    }
}