namespace Kirillov_KTAction;

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