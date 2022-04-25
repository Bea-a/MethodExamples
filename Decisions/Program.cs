using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bea's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {   
                message = ("Sorry you didn't win anything this time");
            }
            else if(userValue == "3")
            {
                message = ("You won a pet of your choice!");
            }
            else
            {
                message = "Sorry, we didnt't understand.";
                message += "You Lose";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
