using System;

namespace ConsoleApp3
{
    enum Number
    {
        even,
        odd
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var x = (Number)(number % 2);

            Console.WriteLine(x);
        }
    }
}
