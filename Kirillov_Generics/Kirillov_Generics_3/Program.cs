using Kirillov_Generics_2;

namespace Kirillov_Generics_3;

internal static class Program
{
    private static readonly Random _random = new Random();

    private static void Main(string[] args)
    {
        Node<int> node1 = new Node<int>(2006);
        Node<Book<int>> node2 = new Node<Book<int>>(
            new Book<int>("Капитанская дочка", 435, "Пушкин", 1234));
        
        node1.Reset();
        node2.Reset();
        
        Console.WriteLine(node1.Value);
        Console.WriteLine(node2.Value);
    }
}