namespace Kirillov_Generics_4;

public class Rectangle<TW,TH>: Figure
{
    public TW Width { get; protected set; }
    public TH Height { get; protected set; }
   
   
    public Rectangle(Vector2 center, TW width,TH height) : base(center)
    {
        Width = width;
        Height = height;
    }
}