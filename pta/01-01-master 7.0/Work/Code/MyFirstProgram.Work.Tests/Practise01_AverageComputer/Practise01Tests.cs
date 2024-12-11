using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Practise01_AverageComputer;

namespace MyFirstProgram.Work.Tests.Practise01_AverageComputer;

public class Practise01Tests : Exercise0101TestsBase<Practise01>
{
    [Test]
    public async Task Practise01()
    {
        StringInputReader.AddLine("2 4 5 6");

        Run();

        await VerifyOutput();
    }
}