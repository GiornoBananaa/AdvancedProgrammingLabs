namespace KirillovAI_KT_1;

public static class Program
{
    private static void Main()
    {
        UserLogger userLogger = new UserLogger(new IUser[]
        {
            new PremiumUser("Vlad",19,  240),
            new RegularUser("Alexandr",20, 70),
            new RegularUser("Andrey",18, 150),
            new PremiumUser("Pavel",21, 421),
        });
        
        userLogger.GivePromotion("Vlad","30% discount on eggs");
        userLogger.GivePromotion("Alexandr","three eggs for the price of two");
        userLogger.GivePromotion("Andrey","Eat 30 eggs in a minute and get them for free");
        userLogger.GivePromotion("Pavel","Buy 5 eggs and get chance to win 1.000.000 eggs in the egg lottery");
        
        while (true)
        {
            Console.Write("\n       LOGIN\n" +
                          "Write your username: ");
            
            string userName = Console.ReadLine() ?? throw new ArgumentNullException();
            Console.WriteLine("");
            userLogger.Login(userName);
        }
    }
}