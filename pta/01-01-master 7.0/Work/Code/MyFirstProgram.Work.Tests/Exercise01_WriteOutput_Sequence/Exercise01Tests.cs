using DiffEngine;
using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Exercise01_WriteOutput_Sequence;

namespace MyFirstProgram.Work.Tests.Exercise01_WriteOutput_Sequence;

public class Exercise01Tests : Exercise0101TestsBase<Exercise01>
{
    [Test]
    public async Task Exercise01()
    {
        Run();

        await VerifyOutput();
    }
}