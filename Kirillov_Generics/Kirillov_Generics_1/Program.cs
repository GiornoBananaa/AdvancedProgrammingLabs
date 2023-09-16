
namespace Kirillov_Generics;

internal static class Program
{
    private static readonly Random _random = new Random();
    
    private static void Main(string[] args)
    {
        float sum = GetListSum(GenerateList(10));
        
        Console.WriteLine("Сумма - " + sum);
    }

    private static List<object> GenerateList(int count)
    {
        List<object> list = new List<object>();
        
        for(int i = 0; i < count; i++)
        {
            switch (_random.Next(0,2))
            {
                case 0:
                    list.Add(_random.Next(0,10));
                    break;
                case 1 :
                    list.Add((float)(_random.NextDouble() * (10 - 1) + 1));
                    break;
            }
        }
        
        return list;
    }
    
    private static float GetListSum(List<object> list)
    {
        float sum = 0;

        for(int i = 0; i < list.Count; i++)
        {
            if(list[i] is int)
                sum += (int)list[i];
            else if(list[i] is float)
                sum += (float)list[i];
        }
        
        return sum;
    }
}