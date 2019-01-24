using System;

namespace IterativeDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi! Please enter an integer between 1 and 100.  ");
            
            //Start of try statement
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if (value_of_input >= 1 && value_of_input <= 100)
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times!");

                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". " +
                            "This is the current integer value in the loop: " + i.ToString());
                    }

                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }//end of for loop, end of if statement

                //If the intger is over 100
                else
                {
                    Console.WriteLine("Error! Please enter a valid number between 1-100.");
                    Console.WriteLine("Please press any key to exit and try again.");
                    Console.ReadKey(true);
                }//end of else statement
            } //End of try

            catch
            {
                Console.WriteLine("Error! Please enter a valid number between 1-100.");
                Console.WriteLine("Please press any key to exit and try again.");
                Console.ReadKey(true);
            }//End of catch
        }
    }
}

