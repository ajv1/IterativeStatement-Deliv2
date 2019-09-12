/*
 Author: Adam Viera
 Date: 9/12/2019
 Comments: This C# Console application code demonstrates the use of 
           iterative statements after getting input from users
*/


using System;

namespace IterativeStatement_Deliv2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);

                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine("You have entered: " + i + ". This is the current integer value in the loop: " + i.ToString());
                }
                Console.WriteLine("Press any key to exit the program ...");
                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true);
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);

            } // end of catch
        }
    }
}
