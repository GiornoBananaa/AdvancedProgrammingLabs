using Kirillov_CatFramework;

namespace Kirillov_CatApplication;

internal static class Program
{
    private static readonly Random _random = new Random();
    
    private static void Main(string[] args)
    {
        Cat[] catsArr;
        
        uint count = GetCountFromInput();

        while (true)
        {
            try
            {
                catsArr = GenerateRandomCats(count);
            }
            catch
            {
                continue;
            }

            break;
        }
        
        DisplayCatInfo(catsArr);
    }

    private static uint GetCountFromInput()
    {
        Console.Write("Введите количество кошек: ");

        uint count;
        
        while (!uint.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("На этот раз введите значение правильно!!! - ");
        }
        
        return count;
    }
    
    private static Cat[] GenerateRandomCats(uint count)
    {
        Cat[] cats = new Cat[count];
        
        for(int i = 0; i < count;i++)
        {
            int fluffiness = _random.Next(-20, 120);
            
            switch (_random.Next(0, 2))
            {
                case 0:
                    cats[i] = new CuteCat(fluffiness);
                    break;
                case 1:
                    int weight = _random.Next(50, 160);
                    cats[i] = new Tiger(fluffiness, weight);
                    break;
            }
        }
        
        return cats;
    }

    private static void DisplayCatInfo(Cat[] catsArr)
    {
        foreach (Cat cat in catsArr)
        {
            Console.WriteLine(cat.FluffinessCheck()+" - "+ cat.ToString());
        }
    }
}