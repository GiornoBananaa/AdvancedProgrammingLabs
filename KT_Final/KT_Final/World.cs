namespace KT_Final;

public class World
{
    public GameObject?[,] WorldMap;
    private WorldRenderer WorldRenderer;
    private bool _firstTick = true;
    
    public event Action OnWorldStart;
    
    public List<GameObject> Enemies { get; private set; }
    public List<GameObject> Towers { get; private set; }

    public World(int size)
    {
        WorldMap = new GameObject?[size,size];
        WorldRenderer = new WorldRenderer(this);
        Enemies = new List<GameObject>();
        Towers = new List<GameObject>();
    }
    
    public void AddBasicEnemy(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateBasicEnemy(this,position);
        Enemies.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void AddBerserkEnemy(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateBerserkEnemy(this,position);
        Enemies.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void AddBasicTower(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateBasicTower(this,position);
        Towers.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void AddHighTower(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateHighTower(this,position);
        Towers.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void WorldTick()
    {
        if (_firstTick)
        {
            OnWorldStart.Invoke();
            _firstTick = false;
            RenderWorld();
        }
        foreach (var tower in Towers)
        {
            tower.Update();
        }
        foreach (var enemy in Enemies)
        {
            enemy.Update();
        }
        RenderWorld();
    }
    
    public void RenderChar(Vector2 position,char symbol, ConsoleColor foreignColor)
    {
        WorldRenderer.RenderChar(position, symbol, foreignColor);
    }
    
    public void RenderWorld()
    {
        WorldRenderer.RenderWorld();
    }
}