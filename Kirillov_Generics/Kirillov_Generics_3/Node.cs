namespace Kirillov_Generics_3;

public class Node<T>
{
    public T Value { get; private set; }

    public Node(T value)
    {
        Value = value;
    }

    public T Reset()
    {
        Value = default(T);
        return Value;
    }
}