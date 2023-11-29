namespace KT_Interfaces_Kirillov;

public class Logger: ILogger
{
    public Logger(ConsoleColor logTextColor)
    {
        LogTextColor = logTextColor;
    }

    public ConsoleColor LogTextColor { get; }

    public void PrintLog(string log)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = LogTextColor;
        Console.WriteLine(log);
        Console.ForegroundColor = defaultColor;
    }
}