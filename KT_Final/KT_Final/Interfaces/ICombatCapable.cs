namespace KT_Final;

public interface ICombatCapable
{
    protected int AttackForce { get; set; }
    protected int AttackRange { get; set; }

    public void Attack(IKillable target);
}