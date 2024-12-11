using Classes.Common.Tests;
using Classes.Final.Exercise03_MethodWithResult;
using Common.Tests;
using FluentAssertions;

namespace Classes.Final.Tests.Exercise03_MethodWithResult;

public class Exercise03Tests : Exercise0103TestsBase<Reader>
{
    [Test]
    public async Task Exercise03()
    {
        StringInputReader.AddLine("42");

        Exercise.InvokePublicMethod<int>("ReadNumber").Should().Be(42);

        await VerifyOutput();
    }
}