namespace Kirillov_CatFramework;

public class CuteCat : Cat
{
    public sealed override int Fluffiness { get; protected set; }


    public CuteCat(int fluffiness)
    {
        bool condition = fluffiness is >= 0 and <= 100;
        
        if(!condition)
            throw new CatException($"Unable to create a cute cat with fluffiness: {fluffiness}");
        
        Fluffiness = fluffiness;
    }
   
    public override string FluffinessCheck()
    {
        switch (Fluffiness)
        {
            case 0:
                return "Sphynx";
            case > 0 and <= 20:
                return "Slightly";
            case > 20 and <= 50:
                return "Medium";
            case > 50 and <= 75:
                return "Heavy";
            case > 75:
                return "OwO";
            
            default:
                return "idk";
        }
    }
   
    public override string ToString()
    {
        return $"A cute cat with fluffiness: {Fluffiness}";
    }
}