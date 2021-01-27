using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 100");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine($"You have entered {value}. This is the current integer value in the loop: {i + 1}");
            }
            Console.ReadKey(true);
        }
    }
}
