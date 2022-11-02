using System;
using DaysOfCSharp.Calc;

namespace DaysOfCSharp
{
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public int Calc(int x, int y)
        {
            int number = x + y;
            return number;
        }

        public void Greeting()
        {
            Console.WriteLine("My name is " + Name + " and my age is " + Age);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person= new Person();

            person.Name = "Benndip";
            person.Age = 25;
            person.HasPet = true;

            person.Greeting();

            int value = Calculator.Add(2, 3);

            Console.WriteLine(value);
        }
    }
}
