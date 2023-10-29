using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }
        }
    }
}
