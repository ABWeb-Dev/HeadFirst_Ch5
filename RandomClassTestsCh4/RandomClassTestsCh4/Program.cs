using System;

namespace RandomClassTestsCh4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Added loop condition to retest conditions without having to rerun application 
            /// Testing a random object from the random class 
            /// </summary>
            while (true)
            {
                Random random = new Random();
                int randomInt = random.Next();
                Console.WriteLine(randomInt);

                int zeroToNine = random.Next(10);
                Console.WriteLine(zeroToNine);

                int dieRoll = random.Next(1, 7);
                Console.WriteLine(dieRoll);

                double randomDouble = random.NextDouble();
                Console.WriteLine(100 * randomDouble);

                Console.WriteLine((float)randomDouble * 100F);
                Console.WriteLine((decimal)randomDouble * 100M);

                int zeroOrOne = random.Next(2);
                bool coinFlip = Convert.ToBoolean(zeroOrOne);
                Console.WriteLine(coinFlip);

                Console.WriteLine("\nPress 1 to Rerun numbers, press any other key to exit: ");
                char input = Console.ReadKey(true).KeyChar;

                if (input == '1')
                {
                    continue;
                }
                else
                    return;
            }
        }
    }
}
