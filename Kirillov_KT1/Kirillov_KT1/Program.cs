namespace Kirillov_KT1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Property[] properties = {
            new Appartment(8000000,120),
            new Appartment(15000000,243),
            new Appartment(12000000, 194),
            new Car(1300000, 1100),
            new Car(4500000, 2050),
            new Car(6900000, 2900),
            new Boat(400000, 2666),
            new Boat(200000, 1200 ),
            new CountryHouse(5000000, 350),
            new CountryHouse(2600000, 1230)
        };

        foreach (Property property in properties)
        {
            Console.WriteLine(property);
        }
    }
}