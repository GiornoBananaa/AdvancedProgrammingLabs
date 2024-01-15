namespace AdvProg_Object;

public static class Program
{
    public static void Main()
    {
        // Задание 1
        Console.WriteLine("\n---Задание 1---");
        Console.WriteLine("Alex == Alex - " +
            Equals(new Task1("Alex", 14), new Task1("Alex", 13)));
        
        // Задание 2
        Console.WriteLine("\n---Задание 2---");
        TaskTracker taskTracker = new TaskTracker();
        taskTracker.AddTask(new Task("Покушать", DateTime.Now.Add(TimeSpan.FromHours(2))));
        taskTracker.AddTask(new Task("Полежать", DateTime.Now.Add(TimeSpan.FromHours(1))));
        taskTracker.AddTask(new Task("Поспать", DateTime.Now.Add(TimeSpan.FromHours(4))));
        taskTracker.DoneTask("Полежать");
        taskTracker.ChangeTaskExecutionDate("Поспать",DateTime.Now.Add(TimeSpan.FromHours(5)));
        taskTracker.ViewTaskList();
        
        // Задание 3
        Console.WriteLine("\n---Задание 3---");
        string name = "Sasha";
        string cloneName = "Sasha";
        
        Console.WriteLine("Sasha == Sasha - " +
                          Equals(name,cloneName));
        
        // Задание 4
        Console.WriteLine("\n---Задание 4---");
        Circle circle1 = new Circle(4);
        Circle circle2 = new Circle(4);
        Square square1 = new Square(4);
        Square square2 = new Square(5);
       
        Console.WriteLine("Circle1 == Circle2 - " +
                          Equals(circle1,circle2));
        Console.WriteLine("Square1 == Square2 - " +
                          Equals(square1,square2));
        
        // Задание 5
        Console.WriteLine("\n---Задание 5---");
        VoteTable voteTable = new VoteTable();
        voteTable.AddCandidate("Alexei", 1000);
        voteTable.AddCandidate("Timur", 800);
        voteTable.AddCandidate("Pavel", 900);
        voteTable.AddCandidate("Dima", 250);
        voteTable.ViewVotes();
    }
}