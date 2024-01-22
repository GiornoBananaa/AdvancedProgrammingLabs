namespace CompositionAndAggregation;

public static class IntListExtension
{
    public static List<int> GetSortedOdds(this List<int> list)
    {
        List<int> sortedList = list;
        sortedList.Sort();
        sortedList.RemoveAll((i) => i % 2 == 0);
        return sortedList;
    }
    
    public static void WriteList<T>(this List<T> list)
    {
        list.ForEach((i) => Console.Write($"{i} "));
        Console.WriteLine();
    }
}