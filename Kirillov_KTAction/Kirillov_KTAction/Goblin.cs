namespace Kirillov_KTAction;

class Goblin
{
    public void PrepareToAttack()
    {
        EventSystem.Subscribe("AttackWaveStart",StartAttack);
        EventSystem.Subscribe("AttackWaveEnd",StopAttack);
        EventSystem.Subscribe("DateTime",CheckDate);
    }

    private void StartAttack(DateTime time)
    {
        Console.WriteLine($"Goblin: Сейчас {time}, а значит пора атаковать!");
    }
    
    private void StopAttack(DateTime time)
    {
        Console.WriteLine("Goblin: Эти людишки сильнее чем мы думали, нам придется отступить, ну и заодно отписаться от события AttackWaveEnd");
    }
    private void CheckDate(DateTime time)
    {
        Console.WriteLine($"Goblin: Время сейчас - {time}, до обеда еще долго...");
    }
}