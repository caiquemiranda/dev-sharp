using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Miranda";
            Greet(name);
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
