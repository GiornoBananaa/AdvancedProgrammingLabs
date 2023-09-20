namespace Kirillov_KT1;

public abstract class Property
{
    public float Worth { get; private set; }

    protected Property(float worth)
    {
        Worth = worth;
    }

    public abstract float СalculateTax();
}