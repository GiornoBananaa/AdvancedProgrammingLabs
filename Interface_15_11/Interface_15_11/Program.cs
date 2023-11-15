namespace Interface_15_11;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  Задание 1");
        Car car = new Car(0);
        
        Console.Write("Введите количества топлива для заправки: ");
        int addedFuel = int.Parse(Console.ReadLine());

        car.Refuel(addedFuel);
        car.Drive();
        
        Console.WriteLine("  Задание 2");
        
        IProduct[] products = new IProduct[]
        {
            new FoodProduct("пельмени", 500, "Пельмени категории Б"),
            new ClothingProduct("футболка", 1500, "Обычная белая футболка"),
            new ApplianceProduct("Блендер", 3200, "Блендер, неплохо смешивает"),
        };

        foreach (var product in products)
        {
            Console.WriteLine(product.GetProductInfo());
            Console.WriteLine($"Delivery cost - {product.GetDeliveryCost(2)}");
        }
    }
}