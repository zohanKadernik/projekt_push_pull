using Classes.Common.Tests;
using Classes.Work.Exercise02_MethodWithoutResult;
using Common.Tests;

namespace Classes.Work.Tests.Exercise02_MethodWithoutResult;

public class Exercise02Tests : Exercise0103TestsBase<Writer>
{
    [Test]
    public async Task Exercise02()
    {
        Exercise.InvokePublicMethod("WriteHelloWorld");

        await VerifyOutput();
    }
}