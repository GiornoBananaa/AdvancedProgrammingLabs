namespace KT_Final;

public class Tower : CombatUnit<Enemy>
{
    public Tower(World world, Vector2 position, int maxHp, int attackForce, int attackRange) : base(world, position, maxHp, attackForce, attackRange) { }
}