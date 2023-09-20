namespace Kirillov_KT1;

public class Appartment  : Immovable
{
    public Appartment(float worth, float square) : base(worth, square)
    {
    }
    
    public override string ToString()
    {
        return $"Апартаменты: Стоимость - {Worth}, налог - {СalculateTax()}, площадь  - {_square} кв.м";
    }
}