using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display title as Console Calculator
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("----------------------------------\n");

            //Prompt user to enter function
            Console.WriteLine("Please enter the key to the function you wish to perform");
            Console.WriteLine("Press 0 for History");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division\n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            //Check the action entered
            switch (action)
            {
                case 0:
                //Display History
                break;
                case 1: {
                    // Add the two numbers
                    result = Addition(input_1, input_2);
                    break;
                }
                case 2: {
                    result = Subtraction(input_1, input_2);
                    break;
                }
                case 3: {
                    result = Multiplication(input_1, input_2);
                    break;
                }
                case 4: {
                    result = Division(input_1, input_2);
                    break;
                }
                default:
                    Console.WriteLine("Wrong action!!! Try again.");
                break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.WriteLine("Press any key to close the Calculator console app....");
        }
        
        //Addition
        public static int Addition(int input_1, int input_2) {
            int result = input_1 + input_2;
            return result;
        }
        //Subtraction
        public static int Subtraction(int input_1, int input_2) {
            int result = input_1 - input_2;
            return result;
        }
        //Division
        public static int Division(int input_1, int input_2) {
            int result = input_1 / input_2;
            return result;
        }
        //Multiplication
        public static int Multiplication(int input_1, int input_2) {
            int result = input_1 * input_2;
            return result;
        }
    }
}
