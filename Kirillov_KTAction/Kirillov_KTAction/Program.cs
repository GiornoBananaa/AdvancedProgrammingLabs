using System;
using System.Reflection.Metadata.Ecma335;


namespace Kirillov_KTAction;

internal class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Goblin goblin = new Goblin();
        
        EventSystem.CreateEvent("AttackWaveStart");
        EventSystem.CreateEvent("AttackWaveEnd");
        
        player.PrepareToAttack();
        goblin.PrepareToAttack();
        
        EventSystem.RaiseEvent("AttackWaveStart");
        EventSystem.RaiseEvent("AttackWaveEnd");
    }
}

class Goblin
{
    public void PrepareToAttack()
    {
        EventSystem.Subscribe("AttackWaveStart",StartAttack);
        EventSystem.Subscribe("AttackWaveEnd",StopAttack);
    }

    private void StartAttack()
    {
        Console.WriteLine($"Goblin: Сейчас {DateTime.Now}, а значит пора атаковать!");
    }
    
    private void StopAttack()
    {
        Console.WriteLine("Goblin: Эти людишки сильнее чем мы думали, нам придется отступить, ну и заодно отписаться от события AttackWaveEnd");
    }
}