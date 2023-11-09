namespace Kirillov_Abstraction;
// Задание 1
/*
1. Разработайте систему учета сотрудников компании. 
Создайте абстрактный класс "Сотрудник" с абстрактным методом "Рассчитать заработную плату".
Создайте производные классы "Менеджер", "Рабочий", "Администратор", 
которые реализуют этот метод с различными логиками расчета заработной платы. 
Создайте массив объектов этих классов и выведите их заработные платы.
 */

abstract class Employee
{
    protected int _daysWorked;
    protected int _hourSalary;
    
    protected Employee(int hourSalary, int daysWorked)
    {
        _hourSalary = hourSalary;
        _daysWorked = daysWorked;
    }
    
    public abstract void CalculateSalary();
}

class Worker : Employee
{
    public Worker(int hourSalary,int daysWorked) : base(hourSalary,daysWorked) { }
    
    public override void CalculateSalary()
    {
        Console.WriteLine($"Зарплата рабочего - {_daysWorked * _hourSalary * 8}");
    }
}

class Administrator : Employee
{
    public Administrator(int hourSalary,int daysWorked) : base(hourSalary,daysWorked) { }
    
    public override void CalculateSalary()
    {
        Console.WriteLine($"Зарплата администратора - {_daysWorked * _hourSalary * 6}");
    }
}

class Manager : Employee
{
    public Manager(int hourSalary,int daysWorked) : base(hourSalary,daysWorked) { }
    
    public override void CalculateSalary()
    {
        float bonus = 5000;
        Console.WriteLine($"Зарплата менеджера - {_daysWorked * _hourSalary * 7 + bonus}");
    }
}