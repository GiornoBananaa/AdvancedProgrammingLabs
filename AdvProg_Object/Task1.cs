namespace AdvProg_Object;

public class Task1
{
    private readonly string _name;
    private readonly int _age;

    public Task1(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Task1 student)
            return false;
       
        return _name == student._name;
    }

    public override int GetHashCode()
    {
        return _name.GetHashCode();
    }
}