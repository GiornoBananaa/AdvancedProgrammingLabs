public static class Program
{
    public static void Main()
    {
       
    }
    
    // Task 2
    
    public delegate void ValueDelegate<TValue>(TValue value);
    
    public static void ListMethodInvoke<TValue>(List<TValue> list, ValueDelegate<TValue> del)
    {
        foreach (var value in list)
        {
            del(value);
        }
    }
    
    // Task 3
    
    public static List<TResult> ListMethodInvoke<TValue, TResult>(List<TValue> list, Func<TValue, TResult> func)
    {
        List<TResult> results = new List<TResult>();
        
        foreach (var value in list)
        {
            results.Add(func(value));
        }
        
        return results;
    }
    
    // Task 4
    
    public static void FilterList<TValue>(List<TValue> list, Predicate<TValue> filter)
    {
        for (int i = 0; i < list.Count; i++)
        {
            TValue value = list[i];
            if (!filter(value))
            {
                list.Remove(value);
            }
        }
    }
    
    // Task 5
    
    public static List<TValue> MergeLists<TValue>(List<TValue> list1, List<TValue> list2, Func<List<TValue>,List<TValue>,List<TValue>> merge)
    {
        return merge(list1, list2);
    }
    
    // Task 6

    public static void SortList<TValue>(List<TValue> list, Comparison<TValue> compare)
    {
        SortList(list,compare,0,list.Count);
    }

    private static void SortList<TValue>(List<TValue> list,Comparison<TValue> compare,int leftIndex, int rightIndex)
    {
        int i = leftIndex;
        int j = rightIndex;
        var pivot = list[leftIndex];
        
        while (i <= j)
        {
            while (compare(list[i],pivot) < 0)
            {
                i++;
            }
        
            while (compare(list[j],pivot) > 0)
            {
                j--;
            }
            
            if (i <= j)
            {
                (list[i], list[j]) = (list[j], list[i]);
                i++;
                j--;
            }
        }
    
        if (leftIndex < j)
            SortList(list,compare, leftIndex, j);
        if (i < rightIndex)
            SortList(list,compare, i, rightIndex);
    }
    
    // Task 7
    
    public static void ListMethodInvoke<TValue>(TValue[] array, Action<TValue> action)
    {
        foreach (var value in array)
        {
            action(value);
        }
    }
}