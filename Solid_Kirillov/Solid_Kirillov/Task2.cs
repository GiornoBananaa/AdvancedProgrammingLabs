namespace Solid_Kirillov;

abstract class Employee
{
    public abstract float HourSalary { get; protected set; }
    public abstract float Hours { get; protected set; }

    protected abstract float CalculateSalary();
    protected abstract void PrintReport();
}

class Worker: Employee
{
    public override float HourSalary { get; protected set; }
    public override float Hours { get; protected set; }

    protected override float CalculateSalary()
    {
        return HourSalary * Hours;
    }

    protected override void PrintReport()
    { 
        Console.WriteLine($"Почасовая зарплата - {HourSalary} в час\n" +
                          $"Количество проработанных часов - {Hours}\n" +
                          $"Зарплата раоботника - {CalculateSalary()}");
    }
} 