namespace Kirillov_Abstraction;

// Задание 3
/*
3. Разработайте систему учета товаров на складе. 
Создайте абстрактный класс "Товар" с абстрактным методом "Получить описание". 
Создайте производные классы "Электроника", "Одежда", "Продукты", 
которые реализуют этот метод с различными логиками получения описания товара. 
Создайте коллекцию объектов этих классов и выведите описание каждого товара.
*/

abstract class Product
{
    protected int Cost;
    protected string Name;
    
    public Product(int cost, string name)
    {
        Cost = cost;
        Name = name;
    }

    public abstract string GetDescription();
}

class Electrics : Product
{
    public Electrics(int cost, string name) : base(cost, name) { }
    
    public override string GetDescription()
    {
        return $"{Name} стоит {Cost}р.";
    }
}

class Clothes : Product
{
    private string Material;
    
    public Clothes(int cost, string name, string material) : base(cost, name)
    {
        Material = material;
    }
    
    public override string GetDescription()
    {
        return $"{Name} стоит {Cost}р. Материал изделия - {Material}";
    }
}
class Foodstuff : Product
{
    private int _calories;
    public Foodstuff(int cost, string name, int calories) : base(cost, name)
    {
        _calories = calories;
    }

    public override string GetDescription()
    {
        return $"{Name} стоит {Cost}р. Количество каллорий - {_calories}";
    }
}