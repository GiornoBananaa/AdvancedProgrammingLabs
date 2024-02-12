namespace KirillovAI_KT_1;

public class UserLogger
{
    private readonly IUser[] _users;
    
    public UserLogger(IUser[] users)
    {
        _users = users;
    }

    public void GivePromotion(string name, string promotion)
    {
        foreach (var user in _users)
        {
            if (user.Name == name)
            {
                user.AddPromotion(promotion);
                return;
            }
        }
        
        throw new ArgumentException();
    }
    
    public void Login(string name)
    {
        int i = 0;
        foreach (var user in _users)
        {
            if (user.Name == name)
            {
                user.Login(i);
                user.LaunchApp();
                return;
            }
            i++;
        }
        
        throw new ArgumentException();
    }
}