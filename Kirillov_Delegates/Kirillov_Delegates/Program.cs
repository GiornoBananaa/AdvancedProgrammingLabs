namespace Kirillov_Delegates;

internal static class Program
{
    private static void Main(string[] args)
    {
        Calculation.FactorialDelegate factorialDelegate = Calculation.Factorial;
        Calculation.NumSumDelegate numSumDelegate = Calculation.NumSum;
        Calculation.NumMultDelegate numMultDelegate = Calculation.NumMult;
        Calculation.PrintSumDelegate printSumDelegate = Calculation.PrintSum;
        Calculation.PrintMultDelegate printMultDelegate = Calculation.PrintMult;

        Console.WriteLine(factorialDelegate.Invoke(5));
        Console.WriteLine(numSumDelegate.Invoke(1211));
        Console.WriteLine(numMultDelegate.Invoke(123));
        printSumDelegate.Invoke(412);
        printMultDelegate.Invoke(412);

        Calculation.PrintSumDelegate printDelegate = Calculation.PrintSum;
        printDelegate += Calculation.PrintMult;
        printDelegate.Invoke(572);
    }
}