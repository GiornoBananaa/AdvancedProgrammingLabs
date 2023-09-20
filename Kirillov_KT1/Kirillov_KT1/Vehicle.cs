namespace Kirillov_KT1;

public abstract class Vehicle : Property
{
    protected float _taxRate = 0.0033f;

    protected float _engineСapacity;
    
    public Vehicle(float worth, float engineСapacity) : base(worth)
    {
        _engineСapacity = engineСapacity;
    }

    public override float СalculateTax()
    {
        return Worth * _taxRate;
    }

    public override string ToString()
    {
        return $"Транспорт: Стоимость - {Worth}, налог - {СalculateTax()}, объема двигателя - {_engineСapacity} см.куб";
    }
}