namespace KirillovAI_KT_1;

public class PremiumUser: IUser
{
    public string Name { get; private set;}
    public int Age { get; private set;}
    public DateTime Date { get; private set;}
    public int Balance { get; private set;}
    public string Promotions { get; private set;}

    public PremiumUser(string name, int age, int balance)
    {
        if (name.Length <= 3 || age < 0 || balance < 0)
            throw new ArgumentException();
        Name = name;
        Age = age;
        Balance = balance;
        Date = DateTime.Now.AddDays(new Random().Next(-182,183));
        Promotions = "";
    }
    
    public void Login(int userIndex)
    {
        Console.WriteLine("Greetings my Lord!");
        if(userIndex<5 && Promotions.Length != 0)
            Console.WriteLine("  Promotions\n  ----------\n"+Promotions+"\n  ----------");
    }

    public void LaunchApp()
    {
        Console.WriteLine("App is launched");
    }

    public void AddPromotion(string promotion)
    {
        Promotions += promotion;
    }
}