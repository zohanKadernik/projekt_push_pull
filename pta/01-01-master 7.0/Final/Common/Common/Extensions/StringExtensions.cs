namespace Common.Extensions;

public static class StringExtensions
{
    public static string Substring(this string value, string start, string end)
    {
        int startIndex = value.IndexOf(start, StringComparison.Ordinal);
        value = value.Substring(startIndex + start.Length);
        int endIndex = value.IndexOf(end, StringComparison.Ordinal);
        return value.Substring(0, endIndex);
    }
}