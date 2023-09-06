public class IntArrayList
{
    private int[] container;
    private int size;

    public int Count => size;
    public int Capacity => container.Length;


    public IntArrayList()
    {
        container = new int[2];
        size = 0;
    }

    public IntArrayList(int capacity)
    {
        container = new int[capacity];
        size = 0;
    }

    public int this[int index]
    {
        get 
        {
            if (index >= size)
                throw new IndexOutOfRangeException();

            return container[index]; 
        }

        set
        {
            if(index >= size)
                throw new IndexOutOfRangeException();

            container[index] = value;
        }
    }

    public void PushBack(int value)
    {
        if (size >= Capacity)
        {
            Resize(Capacity * 2);
        }

        container[size] = value;
        size++;
    }

    public void PopBack(int value)
    {
        if (size == 0)
        {
            return;
        }

        size--;
    }

    public bool TryInsert(int index, int value)
    {
        if (index > size)
        {
            return false;
        }
        else if (index == size)
        {
            PushBack(value);

            return true;
        }

        container[index] = value;

        return true;
    }

    public bool TryErase(int index)
    {
        if (index >= size)
        {
            return false;
        }

        for (int i = index; i < size-1; i++)
        {
            container[i] = container[i + 1];
        }

        size--;
        return true;
    }

    public bool TryGetAt(int index, out int result)
    {
        if (index >= size)
        {
            result = 0;
            return false;
        }

        result = container[index];

        return true;
    }

    public void Clear()
    {
        size = 0;
        container = new int[2];
    }

    public bool TryForceCapacity(int newCapacity)
    {
        if (newCapacity < 0)
        {
            return false;
        }

        Resize(newCapacity);

        return true;
    }

    public int Find(int value)
    {
        for (int i = 0; i < size; i++)
        {
            if (container[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    private void Resize(int newCapacity)
    {
        int[] newContainer = new int[newCapacity];
        for (int i = 0; i < container.Length; i++)
        {
            newContainer[i] = container[i];
        }
        container = newContainer;
    }
}