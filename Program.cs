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
            /*
             * Detta program fungerar som en vanlig slantslingning,
             * förutom att sidan som har hamnat uppåt flest gånger har
             * en mindre chans att hamna uppåt nästa gång än den andra sidan,
             * vilket beror på skillnaden mellan sidornas "poäng"
             */
            int heads = 1, tails = 1;
            Random random = new Random();
            ConsoleKeyInfo cki;

            while(true)
            {
                heads = 1;
                tails = 1;

                for (int i = 0; i < 100; i++)
                {
                    //if (random.Next(2) == 0) //utan balansering
                    if (random.Next(1, heads + tails) < heads) //med balansering
                        tails++;
                    else
                        heads++;
                }

                Console.WriteLine("heads = {0}\ntails = {1}", heads-1, tails-1);
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Spacebar)
                    Console.Clear();
                else
                    break;
            }
        }
    }
}
