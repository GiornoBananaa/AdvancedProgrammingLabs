namespace KT_Final;

public abstract class GameObject
{
    public string Name { get; protected set; }
    public ConsoleColor RenderColor { get; protected set; }
    public char RenderSymbol { get; protected set; }
    protected World _world;
    private Vector2 _position;
    
    public GameObject(World world, string name, Vector2 position,ConsoleColor renderColor, char renderSymbol)
    {
        _world = world;
        Name = name;
        _position = position;
        RenderColor = renderColor;
        RenderSymbol = renderSymbol;
    }
    
    public Vector2 Position
    {
        get => _position;
        protected set => ChangePosition(value);
    }

    protected virtual void ChangePosition(Vector2 newPosition)
    {
        if(_world.WorldMap[newPosition.X,newPosition.Y] != null) 
            return;
        _world.WorldMap[newPosition.X,newPosition.Y] = this;
        _world.WorldMap[_position.X,_position.Y] = null;
        _position = newPosition;
    }
    
    public abstract void Update();
}