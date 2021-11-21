using System;

namespace ElephantProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { name = "Lucinda", earSize = 33 };
            Elephant lloyd = new Elephant() { name = "Llyod", earSize = 40 };

            while (true)
            {
                Console.Write("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 to assign two references to the same object\n" +
                    "5 to make the objects communicate\n");
                char input = Console.ReadKey(true).KeyChar;

                if (input == '1')
                {
                    Console.WriteLine("\nYou pressed 1\n" +
                        "Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("\nYou pressed 2\n" +
                       "Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Console.WriteLine("\nYou Pressed 3 \n" +
                        "References have been swapped");
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                } else if (input == '4')
                {
                    Console.WriteLine("\nYou Pressed 4 \n");
                    lloyd = lucinda;
                    lloyd.earSize = 4321;
                    lloyd.WhoAmI();
                } else if ( input == '5')
                {
                    Console.WriteLine("\nYou Pressed 5 \n");
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd");
                }
                else return;
                Console.WriteLine();


            }
        }
    }
}
