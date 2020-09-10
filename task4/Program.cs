using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What`s your numer?");
            string Userinput = Console.ReadLine();
            int Number = Int32.Parse(Userinput);

            if(Number > 0)
            {
                Console.WriteLine("The number is positive");
            } else if (Number < 0)
            {
                Console.WriteLine("The number is negative");
            } else
            {
                Console.WriteLine("The number is 0.");
            }

        }

}
}




