using System;

namespace GuyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Create a new Guy object in a variable called joe
            /// </summary> 
            /// <Field name = "Name" type = "string" value = "Joe">Set joe object instance variable name to Joe</Field>
            /// <Field name = "Cash" type = "int" value = "50">Set joe object's instance variable cash to 50</Field>
            /// 
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };

            /// <summary>
            /// Create a new Guy object in a variable called bob
            /// </summary> 
            /// <Field name = "Name" type = "string" value = "Bob">Set bob object instance variable name to Joe</Field>
            /// <Field name = "Cash" type = "int" value = "50">Set bob object's instance variable cash to 50</Field>
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            /// <summary>
            /// Continue to run application until user enters exit conditions (a newline character) 
            /// </summary>
            while (true)
            {
                /// <summary>
                /// Call WriteMyInfo methods for each Guy object
                /// </summary>

                joe.WriteMyInfo();
                bob.WriteMyInfo();

                /// <summary>
                /// Prompt user for input. Store input into string variable called "howMuch"
                /// if the value entered is an empty string, return false and terminate program.
                /// If a value otherthan a newline character, run it through int.TryParse.
                /// </summary>
                /// <variable string = "howMuch">Variable contains userr input</variable>
                /// <return boolean = "false"></return>

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int money))
                {
                    Console.Write("Who should give the cash?: ");
                    String whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                       int give = joe.GiveCash(money);
                       bob.ReceiveCash(give);

                    }
                    else if (whichGuy == "Bob")
                    {
                        int give = bob.GiveCash(money);
                        joe.ReceiveCash(give);
                    }

                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob' ");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit");
                }

            }
        }
    }
}
