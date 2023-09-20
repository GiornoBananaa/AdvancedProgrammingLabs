namespace Kirillov_KT1;

public class Car : Vehicle
{
    public Car(float worth, float engineСapacity) : base(worth, engineСapacity)
    {
    }
    
    public override string ToString()
    {
        return $"Машина: Стоимость - {Worth}, налог - {СalculateTax()}, объема двигателя - {_engineСapacity} см.куб";
    }
}