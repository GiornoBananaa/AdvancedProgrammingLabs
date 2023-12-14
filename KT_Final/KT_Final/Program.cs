using System.Runtime.CompilerServices;

namespace KT_Final;

internal static class Program
{
    public static void Main()
    {
        World world = new World(5);
        world.PrintMap();
    }
}

//TODO: enemy move
//TODO: WorldMap to own class