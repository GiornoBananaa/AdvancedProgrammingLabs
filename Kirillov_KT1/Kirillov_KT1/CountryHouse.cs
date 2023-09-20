namespace Kirillov_KT1;

public class CountryHouse  : Immovable
{
    public CountryHouse(float worth, float square) : base(worth, square)
    {
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
    
    public override string ToString()
    {
        return $"Дача: Стоимость - {Worth}, налог - {СalculateTax()}, площадь  - {_square} кв.м";
    }
}