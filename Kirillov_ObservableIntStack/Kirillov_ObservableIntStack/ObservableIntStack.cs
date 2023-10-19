public class ObservableIntStack
{
    public event Action<int> OnItemAdded;
    public event Action<int> OnItemRemoved;
    private Stack<int> _stack;
   
    public ObservableIntStack(IEnumerable<int> numbers)
    {
        _stack = new Stack<int>();
        foreach (var i in numbers)
        {
            _stack.Push(i);
        }
    }
   
    public int Count => _stack.Count;
   
    public void SubscribeToAdding(Action<int> subscriber)
    {
        if (subscriber == null)
            throw new ArgumentNullException();

        OnItemAdded += subscriber;
    }
   
    public void SubscribeToRemoving(Action<int> subscriber)
    {
        if (subscriber == null)
            throw new ArgumentNullException();

        OnItemRemoved += subscriber;
    }
   
    public void UnsubscribeFromAdding(Action<int> subscriber)
    {
        if (subscriber == null)
            throw new ArgumentNullException();

        OnItemAdded -= subscriber;
    }
   
    public void UnsubscribeFromRemoving(Action<int> subscriber)
    {
        if (subscriber == null)
            throw new ArgumentNullException();

        OnItemRemoved -= subscriber;
    }

    public void Push(int item)
    {
        _stack.Push(item);
        OnItemAdded(item);
    }
    public int Pop()
    {
        int item = _stack.Pop();
        OnItemRemoved(item);
        return item;
    }

    public int Peek() => _stack.Peek();

}