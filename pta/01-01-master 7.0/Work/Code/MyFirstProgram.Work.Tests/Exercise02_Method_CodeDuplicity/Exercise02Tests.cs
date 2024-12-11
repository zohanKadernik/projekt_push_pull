using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise02_Method_CodeDuplicity;

namespace MyFirstProgram.Work.Tests.Exercise02_Method_CodeDuplicity;

public class Exercise02Tests : Exercise0101TestsBase<Exercise02>
{
    [Test]
    public async Task Exercise02()
    {
        Run();

        await VerifyOutput();
    }
}