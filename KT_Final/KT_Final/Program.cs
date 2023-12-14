namespace KT_Final;

class Program
{
    public static void Main()
    {
        World world = new World(5);
        world.PrintMap();
    }
}

public class World
{
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

    public void PrintMap()
    {
        int firstDLength = WorldMap.GetLength(0);
        int secondDLength = WorldMap.GetLength(1);
        for(int i = 0; i < firstDLength; i++)
        {
            if(i == 0)
            {
                Console.Write(new string('-', secondDLength * 6 + 1));
                Console.Write("\n");
            }
            
            for(int j = 0; j < secondDLength; j++)
            {
                if(j == 0)
                    Console.Write("|  ");
                else
                    Console.Write("  |  ");
                
                switch (WorldMap[i,j])
                {
                    case null:
                        Console.Write(" ");
                        break;
                }
                if(j == secondDLength-1)
                    Console.Write("  |");
                    
            }
            Console.Write("\n");
            Console.Write(new string('-', secondDLength * 6 + 1));
            Console.Write("\n");
        }
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

    public abstract void Update();
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