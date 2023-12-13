namespace KT_Final;

public class World
{
    /*
    public class WorldCell
    {
        public GameObject? GameObject;
        public Vector2
    }*/
    
    public GameObject?[][] WorldMap;
    
    public World(int size)
    {
        
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

public class GameObject
{
    private World _world;
    private Vector2 _position;
    
    public Vector2 Position
    {
        get => _position;
        private set
        {
            if(_world.WorldMap[_position.X][_position.Y] != null) 
                return;
            _world.WorldMap[_position.X][_position.Y] = this;
            _position = value;
        }
    }
}