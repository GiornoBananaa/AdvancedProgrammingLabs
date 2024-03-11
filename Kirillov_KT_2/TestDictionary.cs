using System.Collections;

namespace Kirillov_KT_2;

public class TestDictionary<T1, T2>: IEnumerable<TestKeyValuePairs<T1, T2>>
{
    private List<TestKeyValuePairs<T1, T2>> _container;
    
    public TestDictionary()
    {
        _container = new List<TestKeyValuePairs<T1, T2>>();
    }
    
    public void Add(T1 key, T2 value)
    {
        foreach (var pair in _container)
        {
            if (pair.Key.Equals(key))
                throw new Exception("That key is already added");
        }
        _container.Add(new TestKeyValuePairs<T1,T2>(key,value));
    }
    
    public TestKeyValuePairs<T1,T2> Find(T1 key)
    {
        foreach (var pair in _container)
        {
            if(pair.Key.Equals(key))
                return pair;
        }
        
        throw new ElementNotFoundException();
    }
    
    public TestKeyValuePairs<T1,T2> Find(T2 value)
    {
        foreach (var pair in _container)
        {
            if(pair.Value.Equals(value))
                return pair;
        }
        
        throw new ElementNotFoundException();
    }
    
    public IEnumerator<TestKeyValuePairs<T1, T2>> GetEnumerator()
    {
        return new TestDictionaryEnumerator<T1,T2>(_container);
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}