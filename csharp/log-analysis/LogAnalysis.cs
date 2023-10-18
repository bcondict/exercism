using System;
using System.Linq;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) => str.Split(delimiter)[1];

    public static string SubstringBetween(this string str, string delimiterStart, string delimiterEnd) => str.Split(delimiterEnd).First().Split(delimiterStart).Last();

    public static string Message(this string str) => str.Split(":")[1].Trim();

    public static string LogLevel(this string  str) => str.SubstringBetween("[", "]");
}
