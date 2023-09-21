namespace Kirillov_Generics_4;

internal static class Program
{
    private static readonly Random _random = new Random();

    private static void Main(string[] args)
    {
        Circle circle1 = new Circle(new Vector2(0,0), 5);
        Circle circle2 = new Circle(new Vector2(0,0), "7");
        Circle circle3 = new Circle(new Vector2(0,0), 3.2);
        Circle circle4 = new Circle(new Vector2(0,0), 2.4f);

        circle1.SetRadius(1.2f);
        circle2.SetRadius(9);
        circle3.SetRadius("1");
        circle4.SetRadius(4.2);
        
        Console.WriteLine("Задача №4");
        Console.WriteLine(circle1.Radius + " - " + circle1.Square);
        Console.WriteLine(circle2.Radius + " - " + circle2.Square);
        Console.WriteLine(circle3.Radius + " - " + circle3.Square);
        Console.WriteLine(circle4.Radius + " - " + circle4.Square);
        
        //----------------
        Console.WriteLine("Задача №4");
        
        Rectangle<string,int> rectangle1 = new Rectangle<string,int>(new Vector2(0,0),"2",4);
        Rectangle<float,double> rectangle2 = new Rectangle<float,double>(new Vector2(1.5f, 2.5f),2.5f,3.3);
        Rectangle<string,float> rectangle3 = new Rectangle<string,float>(new Vector2(-2, 3),"3",4.2f);

        Console.WriteLine($"Левая верхняя точка - {rectangle1.MinPoint}; Правая нижняя точка - {rectangle1.MaxPoint};");
        Console.WriteLine($"Левая верхняя точка - {rectangle2.MinPoint}; Правая нижняя точка - {rectangle2.MaxPoint};");
        Console.WriteLine($"Левая верхняя точка - {rectangle3.MinPoint}; Правая нижняя точка - {rectangle3.MaxPoint};");
    }
}
