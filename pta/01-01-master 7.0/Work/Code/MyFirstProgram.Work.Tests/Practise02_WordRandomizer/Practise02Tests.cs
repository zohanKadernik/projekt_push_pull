using MyFirstProgram.Common.Tests;
using MyFirstProgram.Work.Practise02_WordRandomizer;

namespace MyFirstProgram.Work.Tests.Practise02_WordRandomizer;

public class Practise02Tests : Exercise0101TestsBase<Practise02>
{
    [Test]
    public async Task Practise02()
    {
        StringInputReader.AddLine("one,two,three,four");
        for (int i = 0; i < 10; i++)
        {
            StringInputReader.AddLine(Environment.NewLine);
        }

        Run();

        await VerifyOutput();
    }
}