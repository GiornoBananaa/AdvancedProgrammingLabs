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
    }
}



