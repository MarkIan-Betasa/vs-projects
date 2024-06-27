using System;
namespace SimpleCalculator
{
    internal class Program
    {
        class UI
        {
            // storing the operation desired
            public int Operation()
            {
                int operation = 0;
                Console.WriteLine("Select 1 to ADD, 2 to SUBTRACT, 3 to MULTIPLY, 4 to DIVIDE");
                bool validOperation = int.TryParse(Console.ReadLine(), out operation);
                if (!validOperation || operation < 1 || operation > 4)
                {
                    Console.WriteLine("Invalid input for operation. PLease try again.");
                    return Operation(); //recursion
                }
                return operation;

            }

            // storing the numbers for computation
            public (int, int) Numbers()
            {
                int num1, num2;

                Console.Write("Enter first number: ");

                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Entered values are invalid. Please try again.");
                    return Numbers(); //recursion
                }

                Console.Write("Enter second number: "); ;

                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Entered values are invalid. Please try again.");
                    return Numbers(); //recursion
                }
                return (num1, num2);
            }
        }

        class Validation
        {
            public static bool Conditions(int operation, int num1, int num2)
            {
                if ((operation == 2 || operation == 4) && (num1 < num2))
                {
                    Console.WriteLine("Computation error! The first number in this operation should be greater than the second.");
                    return false;
                }

                if (operation == 4 && num2 == 0)
                {
                    Console.WriteLine("Computation error! The second number in this operation should not be zero.");
                    return false;
                }
                return true;
            }
        }

        class Computation
        {
            public static string Compute(int operation, int num1, int num2)
            {
                int result;
                string print = "";

                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        print = $"The sum of {num1} and {num2} is: {result}";
                        break;

                    case 2:
                        result = num1 - num2;
                        print = $"The difference of {num1} and {num2} is: {result}";
                        break;

                    case 3:
                        result = num1 * num2;
                        print = $"The product of {num1} and {num2} is: {result}";
                        break;

                    case 4:
                        double result1 = (double)num1 / num2;
                        print = $"The sum of {num1} and {num2} is: {result1}";
                        break;

                    default:
                        print = "Invalid input";
                        break;
                }
                return print;
            }
        }
   
        // this was pushed to git hub via terminal
        class Execute
        {
            static void Main(string[] args)
            {
                UI ui = new UI();
                Validation validation = new Validation();
                Computation computation = new Computation();

                int operation, num1, num2;
                operation = ui.Operation();
                (num1, num2) = ui.Numbers();

                while (!Validation.Conditions(operation, num1, num2))
                {
                    (num1, num2) = ui.Numbers();
                }

                string result = Computation.Compute(operation, num1, num2);
                Console.WriteLine(result);


                //UI prompts for operation
                //calculate inputed values
                //validate so that num1 is not less than num 2 in substraction and division 
                //validate so that num2 is not = 0 in division 


            }
        }
    }
}