namespace KT_Final;

public class World
{
    /*
    public class WorldCell
    {
        public GameObject? GameObject;
        public Vector2
    }*/
    
    public GameObject?[,] WorldMap;
    
    public World(int size)
    {
        WorldMap = new GameObject?[size,size];
    }
    
    public void AddEnemy()
    {
        
    }
    
    public void AddTower()
    {
        
    }
    
    public void CheckObjectsUpdates()
    {
        
    }

    public void WorldTick()
    {
        
    }
}

public struct Vector2
{
    public int X;
    public int Y;
    
    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public abstract class GameObject
{
    private World _world;
    private Vector2 _position;
    
    public GameObject(World world, Vector2 position)
    {
        _world = world;
        _position = position;
    }
    
    public Vector2 Position
    {
        get => _position;
        private set
        {
            if(_world.WorldMap[value.X,value.Y] != null) 
                return;
            _world.WorldMap[value.X,value.Y] = this;
            _world.WorldMap[_position.X,_position.Y] = null;
            _position = value;
        }
    }
}

public interface IKillable
{
    public int HpPercentage => Hp * 100 / MaxHp;
    protected int MaxHp { get; set; }
    protected int Hp { get; set; }
    
    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;
        
        Hp -= damage;
        if (Hp <= 0)
        {
            Hp = 0;
            Die();
        }
    }
    
    public void Heal(int hp)
    {
        if (hp <= 0) return;
        
        Hp += hp;
        if (Hp > MaxHp)
            Hp = MaxHp;
    }
    
    protected void Die();
}

public interface ICombatCapable
{
    protected int AttackForce { get; set; }
    protected int AttackRange { get; set; }

    public void Attack(IKillable target);
}