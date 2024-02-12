using KirillovAI_KT_1;

namespace KirillovAI_Tests;

[TestClass]
public class UserTest
{
    [TestMethod]
    public void UserValidInitialization()
    {
        PremiumUser premiumUser = new PremiumUser("Vlad", 19, 240);
        RegularUser regularUser = new RegularUser("Alexandr", 20, 70);
        
        Assert.IsTrue(premiumUser.Date != default);
        Assert.IsTrue(regularUser.Date != default);
    }
    
    [TestMethod]
    public void UserInvalidParameters()
    {
        Assert.ThrowsException<ArgumentException>(() => new PremiumUser("Vla", 19, 240));
        Assert.ThrowsException<ArgumentException>(() => new PremiumUser("Vlad", -1, 240));
        Assert.ThrowsException<ArgumentException>(() => new PremiumUser("Vlad", 19, -1));
        Assert.ThrowsException<ArgumentException>(() => new RegularUser("Vla", 19, 240));
        Assert.ThrowsException<ArgumentException>(() =>new RegularUser("Vlad", -1, 240));
        Assert.ThrowsException<ArgumentException>(() =>new RegularUser("Vlad", 19, -1));
    }
}

[TestClass]
public class UserArrayTest
{
    private IUser[] _users;
    
    [TestInitialize]
    public void UserArrayInitialize()
    {
        _users = new IUser[]
        {
            new RegularUser("Vlad", 19, 240),
            new RegularUser("Alexandr", 20, 70),
            new RegularUser("Andrey", 18, 150),
            new RegularUser("Pavel", 21, 421),
            new PremiumUser("Mu", 25, 1200),
            new PremiumUser("Michal", 23, 3623),
            new PremiumUser("Daniel", 26, 234),
            new PremiumUser("Petr", 20, 653),
            new PremiumUser("Fedor", 21, 904),
            new PremiumUser("Arsen", 17, 562)
        };
    }
    
    [TestMethod]
    public void UserLoggerLogin()
    {
        UserLogger userLogger = new UserLogger(_users);
        
        foreach (var user in _users)
        {
            userLogger.Login(user.Name);
        }
    }
    
    [TestMethod]
    public void UserInvalidLogin()
    {
        UserLogger userLogger = new UserLogger(_users);
        
        Assert.ThrowsException<ArgumentException>(() => userLogger.Login("Anonymous"));
    }
}