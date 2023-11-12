namespace Kirillov_Abstraction;


internal class Program
{
    static void Main(string[] args)
    {
        Employee[] employees =
        {
            new Worker(500,22),
            new Administrator(800,15),
            new Manager(1500,20),
            new Worker(467,23),
            new Administrator(760,21),
        };
        foreach (var employee in employees)
        {
            employee.CalculateSalary();
        }
        
        Book[] books =
        {
            new FictionBook(500,"Пушкин A.C."),
            new ScientificBook(320,"Стивен Хокинг", "история вселенной"),
            new ScientificBook(320,"Чарльз Уилан", "статистика"),
            new FictionBook(670,"Булгаков М.A.")
        };
        foreach (var book in books)
        {
            Console.WriteLine(book.GetInformation());
        }
        
        Product[] products =
        {
            new Electrics(320,"наушники"),
            new Foodstuff(539,"курица", 320),
            new Clothes(2500,"футболка","хлопок"),
            new Foodstuff(539,"пельмени", 1900),
        };
        foreach (var product in products)
        {
            Console.WriteLine(product.GetDescription());
        }
        
    }
}



