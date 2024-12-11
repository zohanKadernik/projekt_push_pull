using Classes.Common.Tests;
using Classes.Work.Exercise04_AsyncMethodWithoutResult;
using Common.Tests;
using FluentAssertions;

namespace Classes.Work.Tests.Exercise04_AsyncMethodWithoutResult;

public class Exercise04Tests : Exercise0103TestsBase<WriterAsync>
{
    [Test]
    public async Task Exercise04()
    {
        await Exercise.InvokePublicMethodAsync("WriteFileContentAsync");

        StringOutputWriter.GetText().Should().Be("""
                                                 It is a dark time for the Rebellion.
                                                 Although the Death Star has been destroyed,
                                                 Imperial troops have driven the Rebel forces from their hidden base
                                                 and pursued them across the galaxy.

                                                 Evading the dreaded Imperial Starfleet,
                                                 a group of freedom fighters led by Luke Skywalker
                                                 has established a new secret base
                                                 on the remote ice world of Hoth...
                                                 
                                                 """);
    }
}