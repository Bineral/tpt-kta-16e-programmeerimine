namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Animal> { new Dog(), new Cat(), new Duck() };

            foreach (var animal in list)
            {
                Console.WriteLine(animal.MakeSound());
            }

            Console.ReadKey();
        }
    }

    public class Duck : Animal
    {
        public string MakeSound()
        {
            return "Quack!";
        }
    }

    public class Cat : Animal
    {
        public string MakeSound()
        {
            return "Mjaow!";
        }
    }

    public class Dog : Animal
    {
        public string MakeSound()
        {
            return "Wooof!";
        }
    }

    public interface Animal
    {
        string MakeSound();
    }

}


