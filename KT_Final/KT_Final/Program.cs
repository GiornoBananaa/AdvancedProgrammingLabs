using System.Diagnostics;

namespace KT_Final;

internal static class Program
{
    public static void Main()
    {
        World world = new World(7);
        
        world.AddBerserkEnemy(new Vector2(0,0));
        world.AddBasicTower(new Vector2(1,5));
        world.AddBasicTower(new Vector2(5,2));
        world.AddHighTower(new Vector2(6,6));

        while (true)
        {
            Thread.Sleep(1000);
            world.WorldTick();

            if (world.Towers.Count == 0)
            {
                Console.WriteLine("\nEnemies won!");
                break;
            }
            if(world.Enemies.Count == 0)
            {
                Console.WriteLine("\nTowers won!");
                break;
            }
        }
    }
}