namespace Interface_15_11;

public class ClothingProduct: IProduct
{
    private string _name;
    private float _cost;
    private string _description;

    public ClothingProduct(string name, float cost, string description)
    {
        _name = name;
        _cost = cost;
        _description = description;
    }

    public string Name => _name;
    public float Cost => _cost;
    public string Description => _description;

    public float GetDeliveryCost(int distance)
    {
        return distance*50;
    }
}