using System;
public interface IAnimal
{   
    void speak();
}
public class Dog : IAnimal
{
    public void speak()
    {
        Console.WriteLine("woof");
    }
}
public class Cat : IAnimal
{
    public void speak()
    {
        Console.WriteLine("meow");
    }
}

public enum Animals
{
    Dog,
    Cat
}
public static class AnimalsFactory
{
    public static IAnimal Create(Animals a)
    {
        if (a == Animals.Dog)
        {
            return new Dog();
        }
        else if (a == Animals.Cat)
        {
            return new Cat();
        }
        else
        {
            throw new Exception("Animals not found");
        }
    }
}
public class Program
{
        public static void Main()
        {
            var mydog = AnimalsFactory.Create(Animals.Dog);
            var mycat = AnimalsFactory.Create(Animals.Cat);
            mydog.speak();
            mycat.speak();
        }
    }
