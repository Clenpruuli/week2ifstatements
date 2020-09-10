using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your year of birth?");
            string UserInPut;
            UserInPut = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInPut);
            int age = 2020 - YearOfBirth;
            
            if (age < 18)
            {
                Console.WriteLine($"you are {age}, you are too young.");
            } 
            else if (age > 18)
            {
                Console.WriteLine($"you are {age},you are old enough.");
            }                
            else
            {
                Console.WriteLine($"Congratulations! you are {age}");

             
            }
              











        }
    }
}
