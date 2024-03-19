using System;

public class ConsoleLog
{
    public void Log(String level, String message)
    {
        switch (level)
        {
            case "Comment":
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Comment: {message}");
                break;
            case "Warning":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Warning: {message}");

                break;
            case "Error":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {message}");
                Environment.Exit(0);
                break;
        }
        Console.ResetColor();
    }
}

public static class Basic
{
    private static ConsoleLog log;
    static Basic()
    {
        log = new ConsoleLog();
    }
    static public ConsoleLog Instance()
    {
        return log;
    }
}

class ProgramLog
{
    static void Main(string[] args)
    {
        ConsoleLog log = Basic.Instance();

        log.Log("Comment", "This is a comment");
        log.Log("Warning", "This is a warning");
        log.Log("Error", "divide by zero");
        log.Log("Error", "exception occurred some message");
    }
}




