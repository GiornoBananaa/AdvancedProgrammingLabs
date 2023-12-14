namespace KT_Final;

public interface IKillable
{
    public int HpPercentage => Hp * 100 / MaxHp;
    protected int MaxHp { get; set; }
    protected int Hp { get; set; }
    
    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;
        
        Hp -= damage;
        if (Hp <= 0)
        {
            Hp = 0;
            Die();
        }
    }
    
    public void Heal(int hp)
    {
        if (hp <= 0) return;
        
        Hp += hp;
        if (Hp > MaxHp)
            Hp = MaxHp;
    }
    
    protected void Die();
}