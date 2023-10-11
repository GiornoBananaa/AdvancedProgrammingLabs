namespace Kirillov_Delegates;

internal static class Program
{
    
    private static void Main(string[] args)
    {
        // Task 3
        Console.WriteLine("  Task 3");
        
        Console.WriteLine("Факториал 5: " + Calculation.FactorialDelegate.Invoke(5));
        Console.WriteLine("Сумма цифр 1211: " + Calculation.NumSumDelegate.Invoke(1211));
        Console.WriteLine("Произведение цифр 123: " + Calculation.NumMultDelegate.Invoke(123));
        Calculation.PrintSumDelegate.Invoke(412);
        Calculation.PintMultDelegate.Invoke(412);
        
        // Task 4
        Console.WriteLine("  Task 4");
        PrintSumDelegate printDelegate = Calculation.PrintSum;
        printDelegate += Calculation.PrintMult;
        printDelegate.Invoke(572);
        
        // Task 5
        Console.WriteLine("  Task 5");
        PrintSumDelegate printDelegate2 = null;
        
        while (true)
        {
            Console.WriteLine("1 - Remove NumSum\n" +
                              "2 - Add NumSum\n" +
                              "3 - Remove NumMult\n" +
                              "4 - Add NumMult\n" +
                              "5 - Invoke delegate\n" +
                              "6 - Next task");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);

            bool nextTask = false;
            switch (choice)
            {
                case 1:
                    printDelegate2 -= Calculation.PrintSum;
                    break;
                case 2:
                    printDelegate2 += Calculation.PrintSum;
                    break;
                case 3:
                    printDelegate2 -= Calculation.PrintMult;
                    break;
                case 4:
                    printDelegate2 += Calculation.PrintMult;
                    break;
                case 5:
                    Console.WriteLine("Введите число");
                    float number = -1;
                    while (true)
                    {
                        if (float.TryParse(Console.ReadLine(), out number))
                            break;
                    }
                    printDelegate2.Invoke(number);
                    break;
                case 6:
                    nextTask = true;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Команда не найдена");
                    Console.ForegroundColor = default;
                    break;
            }
            if(nextTask)
                break;
        }
        
        // Task 6
        Console.WriteLine("  Task 6");
        Console.WriteLine("Введите число");
        float num = -1;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out num))
                break;
        }
        Calculation.PrintSumMult(num).Invoke();
        
        // Task 7
        Console.WriteLine("  Task 7");
        Calculation.PrintSumDelegate.Invoke(13);
        Calculation.PintMultDelegate.Invoke(13);
    }
}