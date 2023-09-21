namespace Kirillov_KT1;

public abstract class Immovable : Property
{
    protected float _taxRate = 0.001f;
    
    protected float _square;
    
    public Immovable(float worth, float square) : base(worth)
    {
        _square = square;
        switch (square)
        {
            case < 100:
                _taxRate = 0.002f;
                break;
            case >= 100 and < 300:
                _taxRate = 0.0029f;
                break;
            case >= 300:
                _taxRate = 0.004f;
                break;
        }
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
