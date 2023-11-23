class Circle
{
    public float Radius { get; private set; }
    
    public Circle(float radius)
    {
        Radius = radius;
    }
}

class CircleCalculation
{
    private Circle _circle;
    
    public CircleCalculation(Circle circle)
    {
        _circle = circle;
    }
    
    public float GetSquare()
    {
        return _circle.Radius * _circle.Radius * 3.14f;
    }
    
    public float GetСircumference()
    {
        return _circle.Radius * 6.28f;
    }
}