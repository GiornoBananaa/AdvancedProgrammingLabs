namespace Kirillov_Generics_4;

public class Circle: Figure
{
    public float Radius { get; private set; }

    public float Square => Radius*Radius*(float)Math.PI;

    public Circle(Vector2 center, object radius) : base(center)
    {
        SetRadius(radius);
    }

    public float SetRadius(object value)
    {
        if (value is float)
        {
            Radius = (float)value;
        }
        else if (value is int)
        {
            Radius = (int)value;
        }
        else if (value is double)
        {
            Radius = (float)Convert.ToDouble(value);
        }
        else if (value is string)
        {
            Radius = float.Parse((string)value);
        }

        return Radius;
    }
}