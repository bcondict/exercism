using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] message = logLine.split(':');
        Console.WriteLine(message);
        return (message);
    }

    public static string LogLevel(string logLine)
    {
        string[] logLevel = logLine.split(':');
        logLevel = logLevel.ToLower();
        logLevel = logLevel.Replace('[', '').Replace(']', '');
        return (logLevel);
    }

    public static string Reformat(string logLine)
    {
        string reformatMessage = Message(logLine);
        reformatMessage += $"{LogLevel(logLine)}";
        return (reformatMessage);
    }
}
