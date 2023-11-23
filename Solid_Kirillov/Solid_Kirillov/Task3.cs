namespace Solid_Kirillov;

interface IFigure
{
    public float CalculateSquare();
}

public class Rectangle: IFigure
{
    private float _side1;
    private float _side2;
    private float _side3;
    
    public Rectangle(float side1,float side2,float side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }
    
    public float CalculateSquare()
    {
        float p = _side1 + _side2 + _side3;
        return (float)Math.Cbrt(p*(p-_side1)*(p-_side2)*(p-_side3));
    }
}

public class Triangle: IFigure
{
    private float _side1;
    private float _side2;

    public Triangle(float side1,float side2)
    {
        _side1 = side1;
        _side2 = side2;
    }
    
    public float CalculateSquare()
    {
        return _side1 * _side2;
    }
}