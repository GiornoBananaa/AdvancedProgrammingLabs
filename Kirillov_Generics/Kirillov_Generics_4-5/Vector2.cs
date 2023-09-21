namespace Kirillov_Generics_4;

public struct Vector2
{
    public float X;
    public float Y;

    public Vector2(float x,float y)
    {
        X = x;
        Y = y;
    }
    
    public override string ToString()
    {
        return $"({X.ToString(CultureInfo.InvariantCulture)},{Y.ToString(CultureInfo.InvariantCulture)})";
    }
}
