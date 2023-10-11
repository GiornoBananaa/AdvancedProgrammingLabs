namespace Kirillov_Delegates;

public delegate float FactorialDelegate(object obj);
public delegate int NumSumDelegate (object obj);
public delegate int NumMultDelegate (object obj);
public delegate void PrintSumDelegate (object obj);
public delegate void PrintMultDelegate (object obj);
public delegate void PrintDelegate ();

static class Calculation
{ 
    public static FactorialDelegate FactorialDelegate = Factorial;
    public static NumSumDelegate NumSumDelegate = NumSum;
    public static NumMultDelegate NumMultDelegate = NumMult;
    public static PrintSumDelegate PrintSumDelegate = PrintSum;
    public static PrintMultDelegate PintMultDelegate = PrintMult;
    
    public static float Factorial(object t)
    {
        float f = ConvertFloat(t);
        
        if(f == 0)
            return 1;
        else
            return f * Factorial(f-1);
    }

    public static int NumSum(object t)
    {
        int f = (int)ConvertFloat(t);
        
        int sum = 0;
        while (f > 0)
        {
            sum += f % 10;
            f = f /10 ;
        }

        return sum;
    }
    
    public static int NumMult(object t)
    {
        int f = (int)ConvertFloat(t);
        
        int mult = 1;
        while (f > 0)
        {
            mult *= f % 10;
            f = f /10 ;
 
        }

        return mult;
    }

    public static void PrintSum(object f)
    {
        Console.WriteLine($"Сумма цифр числа {f}: " + NumSum(f));
    }
    
    public static void PrintMult(object f)
    {
        Console.WriteLine($"Произведение цифр числа {f}: " + NumMult(f));
    }
    
    public static PrintDelegate PrintSumMult(object t)
    {
        int f = (int)ConvertFloat(t);
        
        PrintDelegate printDelegate;

        if (f % 2 == 0)
            printDelegate = () => PrintSum(f);
        else
            printDelegate = () => PrintMult(f);
        
        return printDelegate;
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

    private static float ConvertFloat(object t)
    {
        float f = 0;
        if (t is float)
        {
            f = (float)t;
        }
        else if (t is int)
        {
            f = (int)t;
        }
        else if (t is double)
        {
            f = (float)Convert.ToDouble(t);
        }
        else if (t is string)
        {
            f = float.Parse((string)t);
        }

        return f;
    }
}