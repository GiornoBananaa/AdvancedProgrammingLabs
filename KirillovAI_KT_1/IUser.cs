namespace KirillovAI_KT_1;

public interface IUser
{
    string Name { get; }
    int Age { get; }
    DateTime Date { get; }
    int Balance { get; }
    string Promotions { get; }

    void Login(int userIndex);
    void LaunchApp();
    void AddPromotion(string promotion);
}