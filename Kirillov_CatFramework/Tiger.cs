namespace Kirillov_CatFramework;

public class Tiger : Cat
{
    public sealed override int Fluffiness { get; protected set; }
    public double Weight { get; protected set; }
   
   
    public Tiger(int fluffiness, double weight)
    {
        bool condition1 = weight is >= 75 and <= 140;
        bool condition2 = fluffiness is >= 0 and <= 100;

        switch (condition1)
        {
            case true when !condition2:
                throw new CatException($"Unable to create a tiger with fluffiness: {fluffiness}");
            case false when condition2:
                throw new CatException($"Unable to create a tiger with weight: {weight}");
            case false when !condition2:
                throw new CatException($"Unable to create a tiger with weight: {weight}" +
                                       $"\nUnable to create a tiger with fluffiness: {fluffiness}");
        }
       
        Weight = weight;
        Fluffiness = fluffiness;
    }
   
    public override string FluffinessCheck()
    {
        return "Kycь!";
    }
   
    public override string ToString()
    {
        return $"A tiger with weight: {Weight} fluffiness: {Fluffiness}";
    }
}