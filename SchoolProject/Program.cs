using System;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionCalculator additionCalculator = new();
            const int ADDITION = 1;
            const int SUBTRACTION = 2;
            const int MULT = 3;
            int playerAns = 0;



            Console.WriteLine("Pre-school caculator.");
            Console.WriteLine("Please enter a number corresponding to the category");
            Console.WriteLine("1. Addition \n" +
                "2.Subtraction \n" +
                "3.Multiplication");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Addition selected.");
                string problem = additionCalculator.Generate();
                
                while (playerAns != additionCalculator.Answer)
                {
                    Console.WriteLine(problem);
                    playerAns = Convert.ToInt32(Console.ReadLine());
                    if(playerAns != additionCalculator.Answer)
                    {
                        Console.WriteLine("Wrong answer, try again.");
                    }
                    
                }

                Console.WriteLine($"Correct, the answer is indeed {additionCalculator.Answer} \n" +
                    $"Would you like to solve another problem, or quit the game?");

                   
            }
            if(choice == 2)
            {
                Console.WriteLine("Subtraction selected.");
                
            }
            if(choice == 3)
            {
                Console.WriteLine("Multiplication selected.");
                
            }
            Console.ReadLine();
        }
    }
}
