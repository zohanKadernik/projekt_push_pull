using Classes.Common.Tests;
using Classes.Work.Exercise05_AsyncMethodWithResult;
using Common.Tests;
using FluentAssertions;

namespace Classes.Work.Tests.Exercise05_AsyncMethodWithResult;

public class Exercise05Tests : Exercise0103TestsBase<ReaderAsync>
{
    [Test]
    public async Task Exercise05()
    {
        (await Exercise.InvokePublicMethodAsync<string>("ReadFileContentAsync"))
            .Should().Be("""
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