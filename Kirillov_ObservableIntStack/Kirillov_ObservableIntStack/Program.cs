class Program
{
    private static event Action<int> addSubscriber;
    private static event Action<int> removeSubscriber;
   
    static void Main(string[] args)
    {
        ObservableIntStack stack = new ObservableIntStack(new int[]{1,2,3,4,5,6});

        addSubscriber += NotificationAdded;
        addSubscriber += NotificationNumberParity;
        removeSubscriber += NotificationRemoved;

        stack.SubscribeToAdding(addSubscriber);
        stack.SubscribeToRemoving(removeSubscriber);
        stack.Push(7);
        stack.Push(8);

        stack.Pop();
        stack.Pop();
    }
   
    private static void NotificationAdded(int item)
    {
        Console.WriteLine($"{item} - successfully added to stack!");
    }
   
    private static void NotificationNumberParity(int item)
    {
        Console.WriteLine($"New item {item} is {(item % 2 == 0 ? "even" : "odd")} number");
    }
   
    private static void NotificationRemoved(int item)
    {
        Console.WriteLine($"{item} - successfully removed from stack!");
    }
}