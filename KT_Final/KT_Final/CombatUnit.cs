using System.Diagnostics;

namespace KT_Final;

public abstract class CombatUnit<CombatEnemy>: GameObject, IKillable, ICombatCapable where CombatEnemy: IKillable
{
    protected bool IsDead;
    protected int HealPercent;
    protected ConsoleColor Color;
    
    public int MaxHp { get; set; }
    public int Hp { get; set; }
    public int AttackForce { get; set; }
    public int AttackRange { get; set; }
    
    public CombatUnit(World world, string name,Vector2 position,ConsoleColor renderColor, char renderSymbol, int maxHp, 
        int attackForce, int attackRange,int healPercent) : base(world, name, position,renderColor,renderSymbol)
    {
        MaxHp = maxHp;
        Hp = MaxHp;
        AttackForce = attackForce;
        AttackRange = attackRange;
        HealPercent = healPercent;
    }
    
    public override void Update()
    {
        if (IsDead) return;
        CheckAttackRange();
    }
    
    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;
        
        Hp -= damage;
        if (Hp <= 0)
        {
            Hp = 0;
            Die();
        }
        Heal(HealPercent/100 * MaxHp);
    }
    
    public void Heal(int hp)
    {
        if (hp <= 0) return;
        
        Hp += hp;
        if (Hp > MaxHp)
            Hp = MaxHp;
    }
    
    public void Attack(IKillable target)
    {
        target.TakeDamage(AttackForce);
    }
    
    //Поиск проходит по кольцам вокруг юнита, начиная с ближайшего кольца 3 на 3.
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
                if (position.X >= 0
                    && position.Y >= 0
                    && position.X < _world.WorldMap.GetLength(0)
                    && position.Y < _world.WorldMap.GetLength(1))
                {
                    GameObject? objectInCell = _world.WorldMap[position.X, position.Y];
                    if (objectInCell != null && objectInCell is CombatEnemy combatEnemy)
                    {
                        Attack(combatEnemy);
                        return true;
                    }
                }
                
                position += direction;
                if (direction.X == 0 && direction.Y == 1 && position.Y == startPosition.Y+ringSize-1)
                {
                    direction.X = 1;
                    direction.Y = 0;
                }
                else if (direction.X == 1 && direction.Y == 0 && position.X == startPosition.X+ringSize-1)
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
    
    public virtual void Die()
    {
        _world.WorldMap[Position.X, Position.Y] = null;
        IsDead = true;
    }
}