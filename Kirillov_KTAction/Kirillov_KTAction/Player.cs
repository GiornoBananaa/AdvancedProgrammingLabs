namespace Kirillov_KTAction;

class Player
{
    public void PrepareToAttack()
    {
        EventSystem.Subscribe("AttackWaveStart",StartAttack);
        EventSystem.Subscribe("AttackWaveEnd",StopAttack);
    }

    private void StartAttack()
    {
        Console.WriteLine($"Player: Сейчас {DateTime.Now}, я готов к отражению атаки монстров!");
    }
    
    private void StopAttack()
    {
        Console.WriteLine("Player: Я успешно отбился от врагов и теперь могу вернуться домой, а также отписаться от события AttackWaveEnd");
    }
}