using System.Diagnostics.CodeAnalysis;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
            //This here is the assignment in its basic form. Will create branches to expand on this.
        {
            var favNumber = 8;

            Console.WriteLine("Let's play a game. Try and guess my favorite number.");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("Dude! thats it!");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Nope! Thats too high.");
            }
            else
            {
                Console.WriteLine("Nope! Too low");
            }

            
            

            

  
            


            



        }
    }
}
