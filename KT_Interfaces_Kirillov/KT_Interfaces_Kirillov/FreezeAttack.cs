namespace KT_Interfaces_Kirillov;

public class FreezeAttack: IAbility
{
    private int _reloadTime;
    private IceColor _iceColor;
    private Logger _logger;

    public FreezeAttack(string name, int baseBaseDamage, int attackRadius,  int reloadTime, IceColor iceColor,Logger logger)
    {
        Name = name;
        BaseDamage = baseBaseDamage;
        AttackRadius = attackRadius;
        _logger = logger;
        _reloadTime = reloadTime;
        _iceColor = iceColor;
    }

    public string Name { get; }

    public int BaseDamage { get; }

    public int AttackRadius { get; }

    public void Use(Hero target)
    {
        _logger.PrintLog($"Using sword. BaseDamage: {BaseDamage}," +
                         $"Radius: {AttackRadius}, ReloadTime: {_reloadTime}, IceColor: {_iceColor.ToString()}");
        target.GetDamage(target,BaseDamage);
    }
}