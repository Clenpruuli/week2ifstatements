using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            Console.WriteLine("What is your favorite animal?");
            UserInput = Console.ReadLine();

            if(UserInput == "cat") 
            {
                Console.WriteLine("You are homebird");
            }
            else if (UserInput == "dog") 
            {
                Console.WriteLine("You are partygoer");
            }
            else
            {
                Console.WriteLine($"You are a {UserInput} friend.");
            }
        }
    }
}
