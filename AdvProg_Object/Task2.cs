using System.Collections;

namespace AdvProg_Object;

public class Task
{
    public string Name;
    public  DateTime ExecutionDate;
    public bool IsDone;
   
    public Task(string name, DateTime executionDate)
    {
        Name = name;
        ExecutionDate = executionDate;
    }

    public void DoneTask()
    {
        IsDone = true;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Task book)
            return false;
       
        return Name == book.Name && ExecutionDate == book.ExecutionDate;
    }
   
    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Name} | {ExecutionDate} | {(IsDone?"Done":"InProcess")}";
    }
}

public class TaskTracker
{
    private readonly Hashtable _tasks;
   
    public TaskTracker()
    {
        _tasks = new Hashtable();
    }

    public void AddTask(Task task)
    {
        _tasks.Add(task.GetHashCode(),task);
    }
   
    public void DoneTask(string taskName)
    {
        int key = taskName.GetHashCode();
        if (_tasks[key] == null || _tasks[key] is not Task)
            return;
        ((Task)_tasks[key]!).DoneTask();
    }
   
    public void ChangeTaskExecutionDate(string taskName, DateTime date)
    {
        int key = taskName.GetHashCode();
        if (_tasks[key] == null || _tasks[key] is not Task)
            return;
        ((Task)_tasks[key]!).ExecutionDate = date;
    }
   
    public void ViewTaskList()
    {
        foreach (Task task in _tasks.Values)
        {
            Console.WriteLine(task);
        }
    }
}