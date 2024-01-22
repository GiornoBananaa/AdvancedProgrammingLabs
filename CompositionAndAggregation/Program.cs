namespace CompositionAndAggregation;

public static class Program
{
    public static void Main()
    {
        // Задание 1
        Console.WriteLine("\n---Задание 1---");
        string str = "АааАа";
        Console.WriteLine($"Количество строчных букв в строке \"{str}\" = {str.LowerCount()}\n");
        
        // Задание 3
        Console.WriteLine("\n---Задание 3---");
        List<int> list = new List<int>
        {
            8,3,9,1,6,4,3,5,6
        };
        list.WriteList();
        list.GetSortedOdds().WriteList();
    }
}