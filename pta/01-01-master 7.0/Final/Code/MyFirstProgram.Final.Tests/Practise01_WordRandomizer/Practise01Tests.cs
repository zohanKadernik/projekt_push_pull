using MyFirstProgram.Common.Tests;
using MyFirstProgram.Final.Practise01_WordRandomizer;

namespace MyFirstProgram.Final.Tests.Practise01_WordRandomizer;

public class Practise01Tests : Exercise0101TestsBase<Practise01>
{
    [Test]
    public async Task Practise01()
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