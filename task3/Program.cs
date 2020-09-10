using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first number?");
            string Userinput = Console.ReadLine();
            int Num1 = Int32.Parse(Userinput);
            Console.WriteLine("What is your second number");
            Userinput = Console.ReadLine();
            int Num2 = Int32.Parse(Userinput);

            if (Num1 == Num2)
            {
                Console.WriteLine("the numbers you provided are equal");
            }
            else
            {
                Console.WriteLine("the numbers you provided are NOT equal");
            }
        }
    }
}