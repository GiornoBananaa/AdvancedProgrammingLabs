namespace ConsoleApp1;

public class Calculator
{
    public int Factorial(int a)
    {
        if (a<0) throw new ArgumentException();
        int result = 1;

        for (int i = 1; i <= a; i++)
        {
            result *= i;
        }

        return result;
    }
}