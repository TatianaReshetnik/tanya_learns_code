// See https://aka.ms/new-console-template for more information
using System;

namespace MyHomeTasks
{
    internal abstract class HomeTasks
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
        }
    }
}