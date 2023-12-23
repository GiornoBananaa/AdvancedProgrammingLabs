namespace KT_Final;

public class Tower : CombatUnit<Enemy>
{
    public Tower(World world, string name,Vector2 position, ConsoleColor renderColor, char renderSymbol,int maxHp, int attackForce, int attackRange, int healPercent) 
        : base(world, name, position,renderColor,renderSymbol, maxHp, attackForce, attackRange, healPercent) { }
    
    public override void Die()
    {
        base.Die();
        _world.Enemies.Remove(this);
    }
}