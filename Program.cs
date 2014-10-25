using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biased_coin_flip
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 1, tails = 1;
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                //if (random.Next(2) == 0)
                if (random.Next(1, heads + tails) < heads)
                    tails++;
                else
                    heads++;
            }

            Console.WriteLine("heads = {0}\ntails = {1}", heads-1, tails-1);
            Console.ReadKey();
        }
    }
}
