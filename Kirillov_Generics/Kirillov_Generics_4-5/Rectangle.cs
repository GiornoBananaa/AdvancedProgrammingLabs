namespace Kirillov_Generics_4;

public class Rectangle<TW,TH>: Figure
{
    public TW Width { get; protected set; }
    public TH Height { get; protected set; }

    public Vector2 MinPoint => new(Center.X - ConvertToFloat(Width) / 2, 
        Center.Y + ConvertToFloat(Height) / 2 );
    public Vector2 MaxPoint => new(Center.X + ConvertToFloat(Width) / 2, 
        Center.Y - ConvertToFloat(Height) / 2 );
   
    public Rectangle(Vector2 center, TW width,TH height) : base(center)
    {
        Width = width;
        Height = height;
    }

    private float ConvertToFloat(object value)
    {
        float result = value switch
        {
            float f => f,
            int i => i,
            double => (float)Convert.ToDouble(value),
            string s => float.Parse(s)
        };

        return result;
    }
}
