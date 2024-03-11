using System.Collections;

namespace Kirillov_KT_2;

public class TestDictionaryEnumerator<T1,T2>: IEnumerator<TestKeyValuePairs<T1, T2>>
{
    private readonly List<TestKeyValuePairs<T1, T2>> _container;
    private int _currentIndex;

    public TestDictionaryEnumerator(List<TestKeyValuePairs<T1, T2>> container)
    {
        _container = container;
        _currentIndex = -1;
    }

    public TestKeyValuePairs<T1, T2> Current => _container[_currentIndex];

    object IEnumerator.Current => Current;
    
    public bool MoveNext()
    {
        if (_currentIndex >= _container.Count - 1)
            return false;
        _currentIndex++;
        return true;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
    
    public void Dispose() { }
}