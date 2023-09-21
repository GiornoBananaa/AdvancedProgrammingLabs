namespace Kirillov_KT1;

public class CountryHouse  : Immovable
{
    public CountryHouse(float worth, float square) : base(worth, square)
    {
    }
    
    public override string ToString()
    {
        return $"Дача: Стоимость - {Worth}, налог - {СalculateTax()}, площадь  - {_square} кв.м";
    }
}
