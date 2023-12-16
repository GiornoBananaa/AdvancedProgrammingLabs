namespace KT_Final;

public static class CombatUnitFabric
{
    public static GameObject CreateBasicEnemy(World world, Vector2 position)
    {
        return new Enemy(world,"BasicEnemy",position,ConsoleColor.Red,'E',6,1,2,0,1);
    }
    
    public static GameObject CreateBerserkEnemy(World world, Vector2 position)
    {
        return new Enemy(world,"BerserkEnemy",position,ConsoleColor.Red,'E',8,2,1,1,1);
    }
    
    public static GameObject CreateBasicTower(World world, Vector2 position)
    {
        return new Tower(world,"BasicTower",position,ConsoleColor.Green,'T',4,1,1,0);
    }
    
    public static GameObject CreateHighTower(World world, Vector2 position)
    {
        return new Tower(world,"HighTower",position,ConsoleColor.Green,'T',6,2,2,0);
    }
}