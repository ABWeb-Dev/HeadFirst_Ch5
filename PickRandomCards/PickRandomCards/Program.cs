using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberofCards))
            {
               string[] cardsPicked = CardPicker.PickSomeCards(numberofCards);
                foreach(string card in cardsPicked)
                {
                    Console.WriteLine(card);
                }
            } else
            {
                Console.WriteLine("Please enter a valid, positive, integer.");
            }
        }
    }
}
