using System.Reflection;

namespace Common.Reflection;

public static class MethodInfoExtensions
{
    public static async Task InvokeAsync(this MethodInfo methodInfo, object instance)
    {
        var task = (Task)methodInfo.Invoke(instance, null)!;
        await task;
    }

    public static async Task<TResult> InvokeAsync<TResult>(this MethodInfo methodInfo, object instance)
    {
        var task = (Task<TResult>)methodInfo.Invoke(instance, null)!;
        return await task;
    }
}