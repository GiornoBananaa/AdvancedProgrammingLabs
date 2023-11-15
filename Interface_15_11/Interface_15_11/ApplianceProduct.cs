namespace Interface_15_11;

public class ApplianceProduct: IProduct
{
    private string _name;
    private float _cost;
    private string _description;

    public ApplianceProduct(string name, float cost, string description)
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
        return _cost * (_cost > 2000 ? 0.05f:0.10f);
    }
}