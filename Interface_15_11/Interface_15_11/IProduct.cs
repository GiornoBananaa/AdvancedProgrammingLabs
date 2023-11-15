namespace Interface_15_11;

public interface IProduct
{
    public string Name { get; }
    public float Cost { get; }
    public string Description { get; }
    
    public float GetDeliveryCost(int distance);
    public string GetProductInfo()
    {
        string information = $"------Product info-------\n" +
                             $"Name: {Name}\n" +
                             $"Cost: {Cost}\n" +
                             $"      Description\n" +
                             $"{Description}\n" +
                             $"-------------------------";
        return information;
    }
}