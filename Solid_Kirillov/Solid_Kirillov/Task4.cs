namespace Solid_Kirillov;


abstract class Animal
{
    public abstract string GetSound();
}

class Cat: Animal
{
    public override string GetSound()
    {
        return "мяу";
    }
}

class Dog: Animal
{
    public override string GetSound()
    {
        return "гав";
    }
}