namespace KT_Final;

public struct Vector2
{
    public int X;
    public int Y;
    
    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static float Distance(Vector2 vector1, Vector2 vector2)
    {
        return MathF.Sqrt(MathF.Pow(vector1.X-vector2.X,2) + MathF.Pow(vector1.Y-vector2.Y,2));
    }
    
    public static Vector2 operator +(Vector2 vector1, Vector2 vector2) {
        return new Vector2 
        {
            X = vector1.X + vector2.Y,
            Y = vector1.X + vector2.Y,
        };
    }
}