namespace KT_Interfaces_Kirillov;

public static class HeroFabric
{
    public static Hero CreateSwordsman(string name, ConsoleColor logTextColor)
    {
        Logger heroLogger = new Logger(logTextColor);
        List<IAbility> abilities = new List<IAbility>()
        {
            new MeleeAttack("Sword", 10,1,2,heroLogger)
        };
        
        return new Hero(name, abilities, heroLogger);
    }
    
    public static Hero CreateFireSwordsman(string name, ConsoleColor logTextColor)
    {
        Logger heroLogger = new Logger(logTextColor);
        List<IAbility> abilities = new List<IAbility>()
        {
            new MeleeAttack("Sword", 10,1,3,heroLogger),
            new FireBall("Fire", 30,4,5,heroLogger)
        };
        
        return new Hero(name, abilities, heroLogger);
    }
    
    public static Hero CreateFreezeSwordsman(string name, ConsoleColor logTextColor)
    {
        Logger heroLogger = new Logger(logTextColor);
        List<IAbility> abilities = new List<IAbility>()
        {
            new MeleeAttack("Sword", 10,1,4,heroLogger),
            new FreezeAttack("Freeze", 20,2,2,IceColor.Blue,heroLogger)
        };
        
        return new Hero(name, abilities, heroLogger);
    }
}