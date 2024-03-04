using System.Diagnostics.CodeAnalysis;

namespace Kirillov_Generic_Covariance;

public class IncorrectOptionalAccessException : InvalidOperationException
{
}

public interface IOptional<out T, in K> where K:T
{
    public T Value { get; }
    public bool Empty { get; }
    void SetValue(K? value);
    T GetValueOrDefault();
}

public class Optional<T,K>: IOptional<T,K> where K:T
{
    private T _value;
    public T Value
    {
        get
        {
            if (Empty)
                throw new IncorrectOptionalAccessException();
            return _value;
        }
        set => _value = value;
    }

    public bool Empty { get; protected set; }

    public Optional()
    {
        Empty = true;
    }
    
    public Optional(T value)
    {
        _value=value;
    }
    
    public virtual void SetValue(K? value)
    {
        if (value == null)
            Empty = true;
        else
        {
            Empty = false;
            Value = (T)value;
        }
    }

    public virtual T GetValueOrDefault()
    {
        if (Empty)
            return default;
        return Value;
    }

    public override string ToString()
    {
        if (Empty)
            return "empty";
        
        return Empty? "empty":_value.ToString();
    }
}

public class ExtendedOptional<T, K>: Optional<T, K> where K:T
{
    public Action<T> OnOptionalFilled;
    public Action OnOptionalEmptied;
    
    public override void SetValue(K? value)
    {
        if (value == null)
        {
            Empty = true;
            OnOptionalEmptied?.Invoke();
        }
        else
        {
            Empty = false;
            Value = value;
            OnOptionalFilled?.Invoke(Value);
        }
    }
}

public static class Program
{
    public static void Main()
    {
        int optionalsCount = Convert.ToInt32(Console.ReadLine());

        Optional<int,int>[] optionals = new Optional<int,int>[optionalsCount];
        
        for (int i = 0; i < optionals.Length; i++)
        {
            Console.WriteLine($"Введите {i}-й елемент");
            int value;
            if (int.TryParse(Console.ReadLine(), out value))
            {
                optionals[i] = new Optional<int,int>(value);
            }
            else
            {
                optionals[i] = new Optional<int,int>(null);
            }
        }

        foreach (var optional in optionals)
        {
            Console.Write(optional + " ");
        }
        
        Console.Write("\n");
        ExtendedOptional<int,int> extendedOptional = new ExtendedOptional<int,int>();
        extendedOptional.OnOptionalEmptied += OnOptionalEmptiedHandler;
        extendedOptional.OnOptionalFilled += OnOptionalFilledHandler;
        extendedOptional.SetValue(42);
        extendedOptional.SetValue(null);
    }

    public static void OnOptionalFilledHandler(int value)
    {
        Console.WriteLine($"Присвоено новое значение - {value}");
    }

    public static void OnOptionalEmptiedHandler()
    {
        Console.WriteLine("Значение опусташено");
    }
}