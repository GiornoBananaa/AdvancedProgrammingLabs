
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
        
        EventSystem.Clear();
    }
}