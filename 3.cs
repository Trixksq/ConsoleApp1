abstract class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Тварина видає звук");
    }

    public abstract void Move();
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Кішка мяукає");
    }

    public override void Move()
    {
        Console.WriteLine("Кішка біжить");
    }
}
class Program
{
    static void Main()
    {
        Animal myCat = new Cat();
        myCat.Speak();
        myCat.Move();
    }
}