namespace Kirillov_Generics_4;

public class Square<T>: Figure
{
    public T Side { get; protected set; }

    public Square(Vector2 center, T side) : base(center)
    {
        Side = side;
    }
}