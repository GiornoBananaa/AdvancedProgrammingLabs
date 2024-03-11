namespace Kirillov_KT_2;

public static class Program
{
    public static void Main()
    {
        TestDictionary<int, string> dictionary = new TestDictionary<int, string>();
        dictionary.Add(1,"Alex");
        dictionary.Add(3,"Joe");
        dictionary.Add(2,"Philip");
        dictionary.Add(6,"Leon");

        foreach (var pair in dictionary)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        
        Console.WriteLine();
        Console.WriteLine("Joe's id = " + dictionary.Find("Joe").Key);
        Console.WriteLine("3'rd value = " + dictionary.Find(3).Value);
        Console.WriteLine(dictionary.Find("Unknown"));
    }
}