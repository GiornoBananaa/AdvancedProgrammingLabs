namespace KT_Interfaces_Kirillov;

public class FireBall: IAbility
{
    private readonly int _fireTime;
    private readonly Logger _logger;

    public FireBall(string name, int baseBaseDamage, int attackRadius, int fireTime, Logger logger)
    {
        Name = name;
        BaseDamage = baseBaseDamage;
        AttackRadius = attackRadius;
        _logger = logger;
        _fireTime = fireTime;
    }

    public string Name { get; }

    public int BaseDamage { get; }

    public int AttackRadius { get; }

    public void Use(Hero target)
    {
        _logger.PrintLog($"Using sword. Damage: {BaseDamage}, Radius: {AttackRadius}, FireTime: {_fireTime}");
        target.GetDamage(target,BaseDamage);
    }
}