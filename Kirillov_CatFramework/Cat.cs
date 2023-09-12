namespace Kirillov_CatFramework;

public abstract class Cat
{
    public abstract int Fluffiness { get; protected set; }
    public abstract string FluffinessCheck();
   
    public override string ToString()
    {
        return $"A cat with fluffiness: {Fluffiness}";
    }
}