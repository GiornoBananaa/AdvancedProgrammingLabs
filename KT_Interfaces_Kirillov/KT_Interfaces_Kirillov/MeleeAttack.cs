namespace KT_Interfaces_Kirillov;

public class MeleeAttack: IAbility
{
    private readonly int _damageMultiplier;
    private readonly Logger _logger;

    public MeleeAttack(string name, int baseBaseDamage, int attackRadius, int damageMultiplier, Logger logger)
    {
        Name = name;
        BaseDamage = baseBaseDamage;
        AttackRadius = attackRadius;
        _damageMultiplier = damageMultiplier;
        _logger = logger;
    }

    public string Name { get; }

    public int BaseDamage { get; }

    public int AttackRadius { get; }

    public void Use(Hero target)
    {
        int overallDamage = BaseDamage * _damageMultiplier;
        _logger.PrintLog($"Using sword. BaseDamage: {BaseDamage}, OverallDamage: {overallDamage}, " +
                         $"Radius: {AttackRadius}, Damage multiplier: {_damageMultiplier}");
        target.GetDamage(target,BaseDamage*_damageMultiplier);
    }
}