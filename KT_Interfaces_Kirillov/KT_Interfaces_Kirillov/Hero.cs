namespace KT_Interfaces_Kirillov;

public class Hero
{
    private List<IAbility> _abilities;
    private Logger _logger;
    
    public Hero(string name, List<IAbility> abilities, Logger logger)
    {
        _abilities = abilities;
        _logger = logger;
        Name = name;
    }
    
    public string Name { get; private set; }
    
    
    public void Attack(Hero enemy)
    {
        _logger.PrintLog($"{Name} attacks {enemy.Name}");
        foreach (var ability in _abilities)
        {
            ability.Use(enemy);
        }
    }
    
    public void GetDamage(Hero enemy, int damage)
    {
        _logger.PrintLog($"{Name} received {damage} damage from {enemy.Name}");
    }
}