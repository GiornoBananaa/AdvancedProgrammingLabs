namespace KT_Final;

public class WorldRenderer
{
    public class RenderCell
    {
        public char Symbol;
        public ConsoleColor SymbolColor;

        public RenderCell(char symbol,ConsoleColor symbolColor)
        {
            Symbol = symbol;
            SymbolColor = symbolColor;
        }
    }
    
    private World _world;
    private RenderCell[,] _symbolsRender;
    
    public WorldRenderer(World world)
    {
        _world = world;
        _symbolsRender = new RenderCell[world.WorldMap.GetLength(0),world.WorldMap.GetLength(1)];
    }

    public void RenderChar(Vector2 position,char symbol, ConsoleColor color)
    {
        _symbolsRender[position.X, position.Y] = new RenderCell(symbol,color);
    }
    
    public void RenderBackground(Vector2 position, ConsoleColor color)
    {
        _symbolsRender[position.X, position.Y].SymbolColor = color;
    }
    
    public void RenderWorld()
    {
        //Console.Clear();
        DrawMap();
        Console.Write("\n");
        PrintGameObjectsInfo();
    }
    
    private void DrawMap()
    {
        int firstDLength = _world.WorldMap.GetLength(0);
        int secondDLength = _world.WorldMap.GetLength(1);
        for(int i = 0; i < firstDLength; i++)
        {
            if(i == 0)
            {
                Console.Write(new string('-', secondDLength * 5 + 1));
                Console.Write("\n");
            }
            
            for(int j = 0; j < secondDLength; j++)
            {
                if(j == 0)
                    Console.Write("|  ");
                else
                    Console.Write("  |  ");
                
                switch (_world.WorldMap[i,j])
                {
                    case null:
                        if(_symbolsRender[i,j] == null)
                            break;
                        Console.ForegroundColor = _symbolsRender[i,j].SymbolColor;
                        Console.Write(_symbolsRender[i,j].Symbol);
                        Console.ResetColor();
                        break;
                    case not null:
                        Console.ForegroundColor = _world.WorldMap[i,j].RenderColor;
                        Console.Write(_world.WorldMap[i,j].RenderSymbol);
                        Console.ResetColor();
                        break;
                }
                if(j == secondDLength-1)
                    Console.Write("  |");
                    
            }
            Console.Write("\n");
            Console.Write(new string('-', secondDLength * 5 + 1));
            Console.Write("\n");
        }
    }
    
    private void PrintGameObjectsInfo()
    {
        foreach (var gameObject in _world.GameObjects)
        {
            if(gameObject is Tower tower)
                Console.WriteLine($"{gameObject.Name} - {tower.Hp} hp");
            else if(gameObject is Enemy enemy)
                Console.WriteLine($"{gameObject.Name} - {enemy.Hp} hp");
        }
    }
}