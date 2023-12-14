namespace KT_Final;

public class World
{
    public GameObject?[,] WorldMap;

    public List<GameObject> GameObjects { get; private set; }

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