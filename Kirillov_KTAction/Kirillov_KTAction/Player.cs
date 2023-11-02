namespace Kirillov_KTAction;

class Player
{
    public void PrepareToAttack()
    {
        EventSystem.Subscribe("AttackWaveStart",StartAttack);
        EventSystem.Subscribe("AttackWaveEnd",StopAttack);
        EventSystem.Subscribe("DateTime",CheckDate);
    }

    private void StartAttack(DateTime time)
    {
        Console.WriteLine($"Player: Сейчас {time}, я готов к отражению атаки монстров!");
    }
    
    private void StopAttack(DateTime time)
    {
        Console.WriteLine("Player: Я успешно отбился от врагов и теперь могу вернуться домой, а также отписаться от события AttackWaveEnd");
    }
    
    private void CheckDate(DateTime time)
    {
        Console.WriteLine($"Player: Текущее время - {time}");
    }
}