namespace Interface_15_11;

public class FoodProduct: IProduct
{
    private string _name;
    private float _cost;
    private string _description;

    public FoodProduct(string name, float cost, string description)
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
        return _cost>900 ? 0 : distance*30;
    }
}