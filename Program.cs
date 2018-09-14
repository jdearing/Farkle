using System;
using System.Collections.Generic;

namespace Farkle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Die> dice = new List<Die>();
            for (int i = 0; i < 6; i++)
            {
                dice.Add(new Die(random.Next(0, int.MaxValue)));
            }

            foreach (var die in dice)
            {
                Console.WriteLine($"{die.Role()}");
            }
        }
    }
}
