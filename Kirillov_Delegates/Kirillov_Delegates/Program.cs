namespace Kirillov_Delegates;

internal static class Program
{
    private static void Main(string[] args)
    {
        
    }
}

static class Calculation
{
    public static int Factorial(int f)
    {
        if(f == 0)
            return 1;
        else
            return f * Factorial(f-1);
    }

    public static int NumSum(int f)
    {
        int sum = 0;
        while (f > 0)
        {
            sum += f % 10;
            f = f /10 ;
 
        }

        return sum;
    }
    
    public static int NumMult(int f)
    {
        int sum = 0;
        while (f > 0)
        {
            sum *= f % 10;
            f = f /10 ;
 
        }

        return sum;
    }

    public static void PrintSum(int f)
    {
        NumSum(f);
    }
    
    public static void PrintMult(int f)
    {
        NumMult(f);
    }

    public static bool RemoveOdd(int f, out int deletedCount,out int result)
    {
        string fstr = f.ToString();
        deletedCount = fstr.Length;
        fstr = fstr.Replace("0", string.Empty)
            .Replace("2", string.Empty)
            .Replace("4", string.Empty)
            .Replace("6", string.Empty)
            .Replace("8", string.Empty);

        result = fstr.Length > 0 ? int.Parse(fstr) : 0;
        deletedCount -= fstr.Length;
        return deletedCount > 0;
    }
}