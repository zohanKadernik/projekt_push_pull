using Classes.Common.Tests;
using Classes.Final.Common;
using Common.Tests;

namespace Classes.Final.Tests.Exercise01_EmptyClass_Namespace;

public class Exercise01Tests : Exercise0103TestsBase
{
    [Test]
    public void Exercise01()
    {
        typeof(ProjectAssemblyTargetType).Assembly.Create("User");
    }
}