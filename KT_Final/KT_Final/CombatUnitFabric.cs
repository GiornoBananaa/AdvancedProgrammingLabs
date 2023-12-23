namespace KT_Final;

public static class CombatUnitFabric
{
    public static Enemy CreateBasicEnemy(World world, Vector2 position)
    {
        return new Enemy(world,"BasicEnemy",position,ConsoleColor.Red,'E',6,1,2,0,1);
    }
    
    public static Enemy CreateBerserkEnemy(World world, Vector2 position)
    {
        return new Enemy(world,"BerserkEnemy",position,ConsoleColor.Red,'E',8,2,1,1,1);
    }
    
    public static Tower CreateBasicTower(World world, Vector2 position)
    {
        return new Tower(world,"BasicTower",position,ConsoleColor.Green,'T',4,1,1,0);
    }
    
    public static Tower CreateHighTower(World world, Vector2 position)
    {
        return new Tower(world,"HighTower",position,ConsoleColor.Green,'T',6,2,2,0);
    }
}