namespace KT_Interfaces_Kirillov;

internal class Program
{
    static void Main(string[] args)
    {
        Hero swordsMan = HeroFabric.CreateSwordsman("SwordsHero", ConsoleColor.Green);
        Hero fireSwordsMan = HeroFabric.CreateFireSwordsman("SwordsFireHero", ConsoleColor.Red);
        Hero freezeSwordsMan = HeroFabric.CreateFreezeSwordsman("SwordsFreezeHero", ConsoleColor.Blue);
        
        swordsMan.Attack(fireSwordsMan);
        fireSwordsMan.Attack(freezeSwordsMan);
        freezeSwordsMan.Attack(swordsMan);
    }
}