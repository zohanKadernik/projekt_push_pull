using Classes.Common.Tests;
using Classes.Work.Practise01_CarDatabase_File_WhileLoop;
using Common.Tests;

namespace Classes.Work.Tests.Practise01_CarDatabase_File_WhileLoop;

public class Practise01Tests : Exercise0103TestsBase<CarDatabase>
{
    [SetUp]
    public void ClearDatabase()
    {
        if (File.Exists("car-database"))
        {
            File.Delete("car-database");
        }
    }

    [Test]
    public async Task Practise01_Step1()
    {
        StringInputReader.AddLine("Ferrari 550");
        StringInputReader.AddLine("");

        await Exercise.InvokePublicMethodAsync("RunAsync");

        await VerifyOutput();
    }

    [Test]
    public async Task Practise01_Step2()
    {
        StringInputReader.AddLine("Porsche 911");
        StringInputReader.AddLine("McLaren P1");
        StringInputReader.AddLine("");

        await Exercise.InvokePublicMethodAsync("RunAsync");

        await VerifyOutput();
    }

    [Test]
    public async Task Practise01_Step3()
    {
        StringInputReader.AddLine("Ferrari 550");
        StringInputReader.AddLine("");

        await Exercise.InvokePublicMethodAsync("RunAsync");

        StringInputReader.AddLine("Porsche 911");
        StringInputReader.AddLine("McLaren P1");
        StringInputReader.AddLine("");

        await Exercise.InvokePublicMethodAsync("RunAsync");

        StringInputReader.AddLine("");

        await Exercise.InvokePublicMethodAsync("RunAsync");

        await VerifyOutput();
    }
}