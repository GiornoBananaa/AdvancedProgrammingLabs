namespace KT_Final;

public abstract class GameObject
{
    protected World _world;
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