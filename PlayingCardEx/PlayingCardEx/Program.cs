using System;

namespace PlayingCardEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            Card myCard = new Card((Suits) random.Next(4), (Values) random.Next(1,14));
            Console.WriteLine(myCard.Name);
        }
    }
}
