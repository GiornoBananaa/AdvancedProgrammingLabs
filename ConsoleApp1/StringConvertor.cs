namespace ConsoleApp1;

public class StringConvertor
{
    public int ConvertToInt(string str)
    {
        int result = 0;

        for(int i = str.Length-1; i>=0;i--)
        {
            int digit = str[i] - 48;
            if (digit is > 9 or < 0)
                throw new ArgumentException();
            result += digit*(int)MathF.Pow(10,str.Length-i)/10;
        }
        
        return result;
    }
}