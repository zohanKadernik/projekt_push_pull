using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Exercise04_MethodParameter_DoNotRepeatYourself;

namespace MyFirstProgram.Final.Tests.Exercise04_MethodParameter_DoNotRepeatYourself;

public class Exercise04Tests : Exercise0101TestsBase<Exercise04>
{
    [Test]
    public async Task Exercise04()
    {
        Run();

        await VerifyOutput();
    }
}