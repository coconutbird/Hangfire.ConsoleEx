using Hangfire.Console.Serialization;

namespace Hangfire.Console.Storage;

internal static class ConsoleIdExtensions
{
    public static string GetSetKey(this ConsoleId consoleId)
    {
        return $"console:{consoleId}";
    }

    public static string GetHashKey(this ConsoleId consoleId)
    {
        return $"console:refs:{consoleId}";
    }

    public static string GetOldConsoleKey(this ConsoleId consoleId)
    {
        return consoleId.ToString();
    }
}