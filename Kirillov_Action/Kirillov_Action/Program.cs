using System;


namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter(5);
       
        Console.WriteLine("--  OnValueChange check  --");
        counter.Increase();
        counter.Decrease();
        Console.WriteLine("-- OnValueOverflow check --");
        for (int i = 0; i < 6; i++)
        {
            counter.Increase();
        }
    }
}

internal class Counter
{
    private Action OnValueChange = null!;
    private Action OnValueOverflow = null!;
   
    private int _value;
    private int _maxValue;

    public int Value
    {
        get => _value;
        private set
        {
            if (value > _maxValue)
            {
                OnValueOverflow.Invoke();
                return;
            }
            if (value < 0)
            {
                throw new Exception("Value is negative");
            }

            _value = value;
            OnValueChange.Invoke();
        }
    }

    public Counter(int maxValue)
    {
        _maxValue = maxValue;
        OnValueChange += ValueChangeMessage;
        OnValueChange += PrimeValueCheck;
        OnValueOverflow += SetToDeafult;
        OnValueOverflow += ValueOverflowMessage;
    }
   
    public void Increase() => Value++;
    public void Decrease() => Value--;

    private void SetToDeafult()
    {
        _value = 0;
    }
   
    private void ValueChangeMessage()
    {
        Console.WriteLine($"Value has changed to {_value}!");
    }
   
    private void ValueOverflowMessage()
    {
        Console.WriteLine($"Value is overflowed and changed to {_value}!");
    }
   
    private void PrimeValueCheck()
    {
        Console.WriteLine(CheckIfPrime() ?
            "Value is prime number" : "Value is not prime number");
    }
   
    private bool CheckIfPrime()
    {
        if (_value <= 1) return false;
        if (_value == 2) return true;
        if (_value % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(_value));
         
        for (int i = 3; i <= boundary; i += 2)
            if (_value % i == 0)
                return false;
   
        return true;        
    }
}