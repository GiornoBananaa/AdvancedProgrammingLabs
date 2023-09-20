namespace Kirillov_KT1;

public class Boat : Vehicle
{
    public Boat(float worth, float engineСapacity) : base(worth, engineСapacity)
    {
    }
    
    public override float СalculateTax()
    {
        return Worth * _engineСapacity * _taxRate;
    }
    
    public override string ToString()
    {
        return $"Лодка: Стоимость - {Worth}, налог - {СalculateTax()}, объема двигателя - {_engineСapacity} см.куб";
    }
}