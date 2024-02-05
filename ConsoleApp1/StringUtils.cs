namespace ConsoleApp1;

public static class StringUtils
{
    public static int GetFirstDigit(this string str)
    {
        foreach (var chr in str)
        {
            if(char.IsDigit(chr))
                return chr - 48;
        }

        throw new ArgumentException();
    }
}