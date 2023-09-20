namespace Kirillov_Generics_4;

public abstract class Figure
{
    public Vector2 Center { get; protected set; }

    public Figure(Vector2 center)
    {
        Center = center;
    }
}