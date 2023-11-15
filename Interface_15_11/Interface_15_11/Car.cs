namespace Interface_15_11;

public class Car : IVehiculo
{
    private int _fuelAmount;

    public Car(int fuelAmount)
    {
        _fuelAmount = fuelAmount;
    }

    public void Drive()
    {
        if(_fuelAmount>0)
            Console.WriteLine("Машина: \"врум вррумм бжжии ссщщчау вррррврррррр рррррвррр...\"");
    }

    public bool Refuel(int fuel)
    {
        _fuelAmount += fuel;
        return _fuelAmount>0;
    }
}