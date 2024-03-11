namespace Kirillov_KT_2;

public class TestKeyValuePairs<T1, T2>
{
    public T1 Key { get; }
    public T2 Value { get; }
    
    public TestKeyValuePairs(T1 key, T2 value)
    {
        Key = key;
        Value = value;
    }
}