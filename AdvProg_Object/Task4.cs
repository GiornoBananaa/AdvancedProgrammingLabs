namespace AdvProg_Object;

public class Circle
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }
   
    public override bool Equals(object? obj)
    {
        if (obj is not Circle circle)
            return false;
       
        return _radius == circle._radius && _radius == circle._radius;
    }
   
    public override int GetHashCode()
    {
        return _radius.GetHashCode();
    }
}

public class Square
{
    private readonly int _side;

    public Square(int side)
    {
        _side = side;
    }
   
    public override bool Equals(object? obj)
    {
        if (obj is not Square square)
            return false;
       
        return _side == square._side && _side == square._side;
    }
   
    public override int GetHashCode()
    {
        return _side.GetHashCode();
    }
}