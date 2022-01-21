using System;

namespace SwordDamageCLIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            SwordDamage damage = new SwordDamage();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit:");
                char input = Console.ReadKey(false).KeyChar;

                if (input != '0' && input != '1' && input != '2' && input != '3')
                {
                    return;
                }

                for (int i = 0; i < 3; i++)
                {
                    damage.Roll += random.Next(1, 7);
                }

                damage.SetMagic(input == '1' || input == '3');
                damage.SetFlaming(input == '2' || input == '3');

                Console.WriteLine("\nRolled " + damage.Roll + " for " + damage.Damage + " HP.\n");
                damage.Roll = 0;
            }
        }
    }
}
