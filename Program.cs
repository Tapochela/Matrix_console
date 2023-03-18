
using System;
using System.Security.Policy;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wake up, Neo...");
            Thread.Sleep(4000);
            Console.Clear();

            Thread.Sleep(2000);
            Console.WriteLine("The Matrix has you...");
            Thread.Sleep(3000);
            Console.Clear();

            Thread.Sleep(2000);
            Console.WriteLine("Follow the white rabbit.");
            Thread.Sleep(3000);
            Console.Clear();

            Thread.Sleep(2000);
            Console.WriteLine("Knock, knock, Neo.");
            Thread.Sleep(4000);
            Console.Clear();

            Console.ReadLine();
        }
    }
}
