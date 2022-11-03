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
            Console.WriteLine("What is your name");

            string input = Console.ReadLine();

            int number = Int32.Parse(input);

            Console.WriteLine(number + 20);
        }
    }
}
