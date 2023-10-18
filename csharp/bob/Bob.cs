using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.IsQuiet())
            return "Fine. Be that way!";

        if (statement.IsAsking() && statement.IsYelling())
            return "Calm down, I know what I'm doing!";

        if (statement.IsYelling())
            return "Whoa, chill out!";

        if (statement.IsAsking())
            return "Sure.";

        return "Whatever.";
    }

    private static bool IsYelling (this string message) =>
        message.Any(char.IsLetter) && message.ToUpperInvariant() == message;

    private static bool IsAsking (this string message) =>
        message.TrimEnd().EndsWith("?");

    private static bool IsQuiet (this string message) =>
        string.IsNullOrWhiteSpace(message);
}
