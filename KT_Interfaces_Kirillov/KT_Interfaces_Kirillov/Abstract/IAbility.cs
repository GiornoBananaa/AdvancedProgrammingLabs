namespace KT_Interfaces_Kirillov;

public interface IAbility
{
    protected string Name { get;}
    protected int BaseDamage { get;}
    protected int AttackRadius { get;}
    public void Use(Hero target);
}