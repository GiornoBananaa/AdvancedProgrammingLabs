namespace KT_Final;

public class Enemy : CombatUnit<Tower>
{
    private Queue<Vector2> _pathWaypoints;
    private Vector2 _pathDirection;
    private int _speed;

    public Enemy(World world, string name,Vector2 position,ConsoleColor renderColor, char renderSymbol, int maxHp, int attackForce, int attackRange, int healPercent ,int speed) 
        : base(world, name,position,renderColor,renderSymbol, maxHp, attackForce, attackRange, healPercent)
    {
        _speed = speed;
        _world.OnWorldStart += BuildPath;
        _pathWaypoints = new Queue<Vector2>();
    }

    public override void Update()
    {
        if (IsDead) return;
        if (!CheckAttackRange())
            Move();
    }
    
    protected override void ChangePosition(Vector2 position)
    {
        _world.RenderChar(Position,'-',ConsoleColor.DarkRed);
        base.ChangePosition(position);
    }
    
    private void Move()
    {
        if (_pathWaypoints.Count == 0) return;
        
        if (_pathDirection == new Vector2(0,0))
        {
            _pathWaypoints.Dequeue();
            Console.WriteLine(_pathWaypoints.Count + " " + _pathWaypoints.Peek());
            if(_pathWaypoints.Count == 0)
                return;
            _pathDirection = _pathWaypoints.Peek() - Position;
        }
        
        Vector2 step = _pathDirection.GetNormalized(_speed);
        if (Vector2.Distance(Position, Position + step) > Vector2.Distance(Position, _pathWaypoints.Peek()))
        {
            Console.WriteLine(_pathWaypoints.Count);
            Position = _pathWaypoints.Peek();
            _pathDirection = new Vector2(0, 0);
        }
        else
        {
            Position += step;
            _pathDirection -= step;
        }
    }

    private void BuildPath()
    {
        List<Vector2> towerPositions = new List<Vector2>();
        foreach (var gameObject in _world.GameObjects)
        {
            if(gameObject is not Tower) continue;
            towerPositions.Add(gameObject.Position);
        }
        
        if(towerPositions.Count == 0) return;
        Vector2 bufPosition = Position;
        for (int i = 0; i < towerPositions.Count; i++)
        {
            Vector2 nearestPosition = towerPositions.First();
            
            foreach (var towerPosition in towerPositions)
            {
                Console.WriteLine(Vector2.Distance(bufPosition, towerPosition)+$" {bufPosition} {towerPosition} | "+ Vector2.Distance(bufPosition, nearestPosition)+$" {bufPosition} {nearestPosition}");
                if (Vector2.Distance(bufPosition, towerPosition) < Vector2.Distance(bufPosition, nearestPosition))
                {
                    Console.WriteLine("2");
                    nearestPosition = towerPosition;
                }
            }
            _pathWaypoints.Enqueue(nearestPosition);
            towerPositions.Remove(nearestPosition);
            bufPosition = nearestPosition;
        }
        
        _pathDirection = _pathWaypoints.Peek() - Position;
        
        _world.OnWorldStart -= BuildPath;
    }
}