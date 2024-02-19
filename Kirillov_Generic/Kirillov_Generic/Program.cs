using System.Collections;

namespace Kirillov_Generic;

interface IDeque<T>: IList<T>
{
    public void AddFirst(T item);
    public bool RemoveFirst();
}

public class Deque<T> : IDeque<T>
{
    private class Node
    {
        public T Value;
        public Node? Previous;
        public Node? Next;
        public Node(T value, Node previous, Node next)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }
    }

    public class DequeEnumerator: IEnumerator<T>
    {
        private Node _currentNode;
        private Deque<T> _deque;

        public DequeEnumerator(Deque<T> deque)
        {
            _deque = deque;
            _currentNode = _deque._firstNode;
        }
        
        public bool MoveNext()
        {
            _currentNode = _currentNode.Next;
            return _currentNode == null;
        }

        public void Reset()
        {
            _currentNode = _deque._firstNode;
        }

        public T Current { get; }

        object IEnumerator.Current => Current;

        public void Dispose() { }
    }
    
    public int Count { get; private set; }
    public bool IsReadOnly => false;
    private Node? _firstNode;
    private Node? _lastNode;
    
    public T this[int index] 
    {
        get
        {
            if (Count >= index || Count < 0)
                throw new IndexOutOfRangeException();
            
            return GetNode(index).Value;
        }
        set
        {
            if (Count >= index || Count < 0)
                throw new IndexOutOfRangeException();
            GetNode(index).Value = value;
        }
    }

    public void Add(T item)
    {
        Node newNode = new Node(item, _lastNode, null);
        _lastNode.Next = newNode;
        _lastNode = newNode;
        if (Count == 0)
            _firstNode = newNode;
        Count++;
    }

    public void AddFirst(T item)
    {
        Node newNode = new Node(item, null, _firstNode);
        _firstNode.Previous = newNode;
        _firstNode = newNode;
        if (Count == 0)
            _lastNode = newNode;
        Count++;
    }
    
    public void Insert(int index, T item)
    {
        if (Count > index || Count < 0)
            throw new IndexOutOfRangeException();
        if(index == 0)
        {
            AddFirst(item);
            return;
        }
        if(index == Count)
        {
            Add(item);
            return;
        }
        Node current = GetNode(index);
        Node newNode = new Node(item, current.Previous!, current);
        newNode.Previous.Next = newNode;
        newNode.Next.Previous = newNode;
        Count++;
    }
    
    public bool Remove(T item)
    {
        Node node;
        
        try
        {
            node = GetNode(item);
        }
        catch
        {
            return false;
        }
        
        Remove(node);
        return true;
    }
    
    public bool RemoveFirst()
    {
        if (_firstNode == null)
            return false;
        if (Count == 1)
            _lastNode = null;
        Remove(_firstNode);
        return true;
    }
    
    public bool RemoveLast()
    {
        if (_lastNode == null)
            return false;
        if (Count == 1)
            _firstNode = null;
        Remove(_lastNode);
        return true;
    }

    public void RemoveAt(int index)
    {
        Remove(GetNode(index));
    }

    public void Clear()
    {
        _firstNode = null;
        _lastNode = null;
        Count--;
    }

    public bool Contains(T item)
    {
        try
        {
            GetNode(item);
        }
        catch
        {
            return false;
        }

        return true;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        Node current = _firstNode;
        int i = arrayIndex;
        while (current != null && arrayIndex<array.Length)
        {
            array[i] = current.Value;
            current = current.Next;
            i++;
        }
    }
    
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return new DequeEnumerator(this);
    }

    public IEnumerator GetEnumerator()
    {
        return new DequeEnumerator(this);
    }
    
    public int IndexOf(T item)
    {
        Node current = _firstNode;
        for (int i = 0; i < Count; i++)
        {
            if (current.Value.Equals(item))
                return i;
            current = current.Next;
        }

        return -1;
    }

    private void Remove(Node node)
    {
        if(node.Next!=null)
            node.Next.Previous = node.Previous;
        if(node.Previous!=null)
            node.Previous.Next = node.Next;
        
        if (node == _firstNode)
        {
            _firstNode = _firstNode.Next;
        }
        if (node == _lastNode)
        {
            _lastNode = _lastNode.Previous;
        }

        Count--;
    }
    
    private Node GetNode(int index)
    {
        Node current = _firstNode;
        for (int i = 0; i <= index; i++)
        {
            current = current.Next;
        }

        return current;
    }
    
    private Node GetNode(T item)
    {
        Node current = _firstNode;
        for (int i = 0; i < Count; i++)
        {
            if (current.Value.Equals(item))
                return current;
            current = current.Next;
        }

        throw new ArgumentException();
    }
}