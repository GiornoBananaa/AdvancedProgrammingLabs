namespace KT_Final;

public class World
{
    public GameObject?[,] WorldMap;
    private WorldRenderer WorldRenderer;
    private bool _firstTick = true;
    
    public event Action OnWorldStart;
    
    public List<GameObject> GameObjects { get; private set; }

    public World(int size)
    {
        WorldMap = new GameObject?[size,size];
        WorldRenderer = new WorldRenderer(this);
        GameObjects = new List<GameObject>();
    }
    
    public void AddBasicEnemy(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateBasicEnemy(this,position);
        GameObjects.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void AddBerserkEnemy(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateBerserkEnemy(this,position);
        GameObjects.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void AddBasicTower(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateBasicTower(this,position);
        GameObjects.Add(gameObject);
        WorldMap[position.X, position.Y] = gameObject;
    }
    
    public void AddHighTower(Vector2 position)
    {
        GameObject gameObject = CombatUnitFabric.CreateHighTower(this,position);
        GameObjects.Add(gameObject);
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
        foreach (var gameObject in GameObjects)
        {
            gameObject.Update();
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