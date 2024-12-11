using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Exercise02_Method_CodeDuplicity;

namespace MyFirstProgram.Final.Tests.Exercise02_Method_CodeDuplicity;

public class Exercise02Tests : Exercise0101TestsBase<Exercise02>
{
    [Test]
    public async Task Exercise02()
    {
        Run();

        await VerifyOutput();
    }
}