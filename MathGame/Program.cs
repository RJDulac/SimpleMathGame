
using System;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q q = new Q(Q.random.Next(2) == 1);

            while(true)
            {
                Console.WriteLine($"{q.N1} {q.Op} {q.N2} = ");
                if(!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                if(q.Check(i))
                {
                    Console.WriteLine("Right!");
                    q = new Q(Q.random.Next(2) == 1);
                }
                else Console.WriteLine("Wrong Try again!");
            }
        }
    }
}
