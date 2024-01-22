namespace CompositionAndAggregation;

public static class StringExtension
{
    public static int LowerCount(this string str)
    {
        int count = 0;
        foreach (var t in str)
        {
            if (char.IsLower(t))
                count++;
        }
        return count;
    }
}