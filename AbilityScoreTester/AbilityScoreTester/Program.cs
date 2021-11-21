using System;

namespace AbilityScoreTester
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.Divideby = ReadDouble(calculator.Divideby, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quite, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;

            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]:");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("   Using value " + value);
                return value;
            } else
            {
                Console.WriteLine("   Using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        static double ReadDouble(double lastValueUsed, string prompt)
        {
            Console.Write(prompt + " [" + lastValueUsed + "]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine("    Using value " + value);
                return value;
            } else
            {
                Console.WriteLine("    Using default value " + lastValueUsed);
                return lastValueUsed;
            }
        }
    }
}
