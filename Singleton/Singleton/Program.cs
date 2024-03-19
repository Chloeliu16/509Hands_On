using System;

public class ProgramLog
{
    public static void Main(string[] args)
    {
        ConsoleLog log_a = ConsoleLog.GetConsoleLog();
        ConsoleLog log_b = ConsoleLog.GetConsoleLog();

        if (log_a == log_b)
        {
            Console.WriteLine("Same instance\n");
        }

        ConsoleLog log = ConsoleLog.GetConsoleLog();
        log.Log("Comment", "This is a comment");
        log.Log("Warning", "This is a warning");
        log.Log("Error", "divide by zero");
        log.Log("Error", "exception occurred some message");

        Console.ReadKey();
    }
}
public class ConsoleLog
{
    static ConsoleLog instance;

    private static object locker = new object();
    protected ConsoleLog()
    {
    }
    public static ConsoleLog GetConsoleLog()
    {
        if (instance == null)
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new ConsoleLog();
                }
            }
        }
        return instance;
    }

    public void Log(String level, String message)
    {
        switch (level)
        {
            case "Comment":
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Comment: {message}");
                Console.ResetColor();
                break;
            case "Warning":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Warning: {message}");
                Console.ResetColor();
                break;
            case "Error":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {message}");
                Console.ResetColor();
                Environment.Exit(0);
                break;
        }

    }
}

