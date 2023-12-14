namespace KT_Final;

public abstract class CombatUnit<CombatEnemy>: GameObject, IKillable, ICombatCapable where CombatEnemy: IKillable
{
    protected bool IsDead;
    
    public int MaxHp { get; set; }
    public int Hp { get; set; }
    public int AttackForce { get; set; }
    public int AttackRange { get; set; }
    
    public CombatUnit(World world, Vector2 position, int maxHp, 
        int attackForce, int attackRange) : base(world, position)
    {
        MaxHp = maxHp;
        Hp = MaxHp;
        AttackForce = attackForce;
        AttackRange = attackRange;
    }
    
    public override void Update()
    {
        if (IsDead) return;
        CheckAttackRange();
    }
    
    public void Attack(IKillable target)
    {
        target.TakeDamage(AttackForce);
    }
    
    /* Массивность метода по поиску врагов в рендже обусловлена поиском ближайших врагов,
    а не тех кто оказался в правом углу ренджи, что происходило бы при обычном проходом по области. Поиск проходит по кольцам вокруг юнита, начиная с ближайшего кольца 3 на 3.*/
    protected bool CheckAttackRange()
    {
        for (int ring = 1; ring <= AttackRange; ring++)
        {
            int ringSize = 1 + ring * 2;
            int ringLength = ringSize*4-4;
            Vector2 startPosition = new Vector2(Position.X-ring,Position.Y-ring);
            Vector2 position = startPosition;
            Vector2 direction = new Vector2(0,1);
            for (int i = 0; i < ringLength; i++)
            {
                if(position.X < 0 
                   || position.Y < 0 
                   || position.X > _world.WorldMap.GetLength(0) 
                   || position.Y > _world.WorldMap.GetLength(1)) 
                    continue;
            
                GameObject? objectInCell = _world.WorldMap[position.X, position.Y];

                if (objectInCell != null && objectInCell is CombatEnemy)
                {
                    Attack((Tower)objectInCell);
                    return true;
                }
                
                position += direction;
                if (direction.X == 0 && direction.Y == 1 && position.Y == startPosition.Y+ringSize)
                {
                    direction.X = 1;
                    direction.Y = 0;
                }
                else if (direction.X == 1 && direction.Y == 0 && position.X == startPosition.X+ringSize)
                {
                    direction.X = 0;
                    direction.Y = -1;
                }
                else if (direction.X == 0 && direction.Y == -1 && position.Y == startPosition.Y)
                {
                    direction.X = -1;
                    direction.Y = 0;
                }
                else if (direction.X == -1 && direction.Y == 0 && position.X == startPosition.X)
                {
                    break;
                }
            }
        }

        return false;
    }
    
    public void Die()
    {
        _world.WorldMap[Position.X, Position.Y] = null;
        IsDead = true;
    }
}