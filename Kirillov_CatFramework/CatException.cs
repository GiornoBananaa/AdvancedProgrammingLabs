namespace Kirillov_CatFramework;

public class CatException : ArgumentException
{
    public CatException(string message) : base(message)
    {
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = prevColor;
    }
}