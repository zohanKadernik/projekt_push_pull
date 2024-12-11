using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Common.Tests;

public static class VerifyExtensions
{
    private static bool IsDiffDisabled()
    {
        return Environment.GetEnvironmentVariable("IsDiffDisabled") != null;
    }

    public static async Task Verify(this string text, [CallerFilePath] string sourceFile = "")
    {
        var settings = new VerifySettings();
        if (IsDiffDisabled())
        {
            settings.DisableDiff();
        }
        else
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (AppDomain.CurrentDomain.FriendlyName == "ReSharperTestRunner")
                {
                    string? riderFilePath = Environment.GetEnvironmentVariable("DiffEngine_Rider");
                    if (riderFilePath == null || !File.Exists(riderFilePath))
                    {
                        riderFilePath = GetRiderFilePath();
                    }

                    if (riderFilePath != null)
                    {
                        Environment.SetEnvironmentVariable("DiffEngine_Rider", riderFilePath);
                        Environment.SetEnvironmentVariable("DiffEngine_ToolOrder", "Rider");
                    }
                }
                else if (AppDomain.CurrentDomain.FriendlyName == "testhost")
                {
                    Environment.SetEnvironmentVariable("DiffEngine_ToolOrder", "VisualStudio");
                }
            }

        }
        await Verifier.Verify(text, settings, sourceFile: sourceFile);
    }

    private static string? GetRiderFilePath()
    {
        string[] possibleSearchDirectoryPaths = {
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "JetBrains"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "JetBrains"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JetBrains"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JetBrains")
        };

        foreach (var possibleSearchDirectoryPath in possibleSearchDirectoryPaths)
        {
            try
            {
                var riderFilePath = GetRiderFilePath(possibleSearchDirectoryPath).SingleOrDefault();
                if (riderFilePath != null)
                {
                    return riderFilePath;
                }
            }
            catch
            {
                //
            }
        }

        return null;
    }

    private static string[] GetRiderFilePath(string directoryFilePath)
    {
        return Directory.GetFiles(directoryFilePath, "rider64.exe", SearchOption.AllDirectories);
    }
}