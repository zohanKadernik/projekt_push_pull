using System.Reflection;
using Common.Reflection;
using FluentAssertions;
using FluentAssertions.Types;

namespace Common.Tests;

public static class TypeAssertionsExtensions
{
    public static MethodInfo ContainsPrivateMethod(this TypeAssertions typeAssertions, string name)
    {
        var methodInfo = typeAssertions.Subject.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance)!;
        methodInfo.Should().NotBeNull(name);
        return methodInfo;
    }

    public static MethodInfo ContainsPublicMethod(this TypeAssertions typeAssertions, string name)
    {
        var methodInfo = typeAssertions.Subject.GetMethod(name)!;
        methodInfo.Should().NotBeNull(name);
        return methodInfo;
    }

    public static void InvokePublicMethod(this object instance, string methodName, params object?[] parameters)
    {
        var methodInfo = instance.GetType().Should().ContainsPublicMethod(methodName);

        methodInfo.Invoke(instance, parameters);
    }

    public static object Create(this Assembly assembly, string className, params object?[] parameters)
    {
        var type = assembly.GetTypes().SingleOrDefault(t => t.Name == className)!;
        var instance = Activator.CreateInstance(type, parameters)!;
        return instance;
    }

    public static TResult? InvokePublicMethod<TResult>(this object instance, string methodName, params object?[] parameters)
    {
        var methodInfo = instance.GetType().Should().ContainsPublicMethod(methodName);

        return (TResult?)methodInfo.Invoke(instance, parameters);
    }

    public static async Task InvokePublicMethodAsync(this object instance, string methodName)
    {
        var methodInfo = instance.GetType().Should().ContainsPublicMethod(methodName);

        await methodInfo.InvokeAsync(instance);
    }

    public static async Task<TResult> InvokePublicMethodAsync<TResult>(this object instance, string methodName)
    {
        var methodInfo = instance.GetType().Should().ContainsPublicMethod(methodName);

        return await methodInfo.InvokeAsync<TResult>(instance);
    }

    public static void InvokePrivateMethod(this object instance, string methodName)
    {
        var methodInfo = instance.GetType().Should().ContainsPrivateMethod(methodName);

        methodInfo.Invoke(instance, null);
    }
}