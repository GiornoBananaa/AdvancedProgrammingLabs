namespace KT_Final;

public class Enemy : CombatUnit<Tower>
{
    public Enemy(World world, Vector2 position, int maxHp, int attackForce, int attackRange) : base(world, position, maxHp, attackForce, attackRange) { }
    
    public override void Update()
    {
        if (IsDead) return;
        if (!CheckAttackRange())
            Move();
    }

    protected void Move()
    {
        
    }

    private void BuildPath()
    {
        foreach (var VARIABLE in GameObjects)
        {
            
        }
    }
}