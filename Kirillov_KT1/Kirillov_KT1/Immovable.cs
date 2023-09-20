namespace Kirillov_KT1;

public abstract class Immovable : Property
{
    protected float _taxRate = 0.001f;
    
    protected float _square;
    
    public Immovable(float worth, float square) : base(worth)
    {
        _square = square;
    }

    public override float СalculateTax()
    {
        return Worth * _taxRate;
    }
        
    public float GetPerMetreCost()
    {
        return Worth /_square;
    }
    
    public override string ToString()
    {
        return $"Недвижимость: Стоимость - {Worth}, налог - {СalculateTax()}, площадь  - {_square} кв.м";
    }
}