namespace Kirillov_Generics_2;

internal static class Program
{
    private static readonly Random _random = new Random();

    private static void Main(string[] args)
    {
        Book<string> book1 = new Book<string>("Капитанская дочка", 435, "Пушкин", "абвгд");
        Book<int> book2 = new Book<int>("Капитанская дочка", 435, "Пушкин", 1234);
        Book<Guid> book3 = new Book<Guid>("Капитанская дочка", 435, "Пушкин", Guid.NewGuid());
        
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
    }
}