using System;
using System.Collections.Generic;
using System.Text;

namespace HiLoApp
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(MAXIMUM);
        private static int pot = 10;

        public static int GetPot() { return pot;}
        public static void Guess(bool higher)
        {
            int NextNumber = random.Next(MAXIMUM);

            if (higher && NextNumber >= currentNumber || !higher && NextNumber <= currentNumber)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            } else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }

            currentNumber = NextNumber;
            Console.WriteLine($"The current number is: {currentNumber}");   

        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;

           string  message =  (half >= currentNumber) ? $"The number is at least {half}" : $"The number is at most {half}";
            Console.WriteLine(message);
        }
    }
}


