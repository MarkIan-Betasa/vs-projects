namespace time_conversion__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts the following: seconds to minutes,
            //minutes to hours, hours to days, days to months.
            //user should have UI converter
            //write formula for conversion

            while (true)
            {
                Console.WriteLine("\nTime converter" +
                    "\nPlease input desired conversion:\n" +
                    "\n[1] seconds to minutes" +
                    "\n[2] minutes to hours" +
                    "\n[3] hours to days" +
                    "\n[4] days to months" +
                    "\n[5] exit program\n");


                int convOpt = Convert.ToInt32(Console.ReadLine());
                double userInput;
                double ans = 0;
                bool validEntry;


                switch (convOpt)
                {
                    case 1:
                        Console.WriteLine("\nInput seconds to be converted to minutes: ");
                        validEntry = double.TryParse(Console.ReadLine(), out userInput);
                        if (validEntry)
                        {
                            ans = userInput / 60;
                            Console.WriteLine("The answer is " + ans + " minute/s");
                        }
                        else if (!validEntry)
                        {
                            Console.WriteLine("\nPlease enter a valid option.");
                            continue;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nInput minutes to be converted to hours: ");
                        validEntry = double.TryParse(Console.ReadLine(), out userInput);
                        if (validEntry)
                            if (validEntry)
                            {
                                ans = userInput / 60;
                                Console.WriteLine("The answer is " + ans + " hour/s");
                            }
                            else if (!validEntry)
                            {
                                Console.WriteLine("\nPlease enter a valid option.");
                                continue;
                            }
                        break;

                    case 3:
                        Console.WriteLine("\nInput hours to be converted to days: ");
                        validEntry = double.TryParse(Console.ReadLine(), out userInput);
                        if (validEntry)
                            if (validEntry)
                            {
                                ans = userInput / 24;
                                Console.WriteLine("The answer is " + ans + " day/s");
                            }
                            else if (!validEntry)
                            {
                                Console.WriteLine("\nPlease enter a valid option.");
                                continue;
                            }
                        break;

                    case 4:
                        Console.WriteLine("\nInput days to be converted to months (30 days): ");
                        validEntry = double.TryParse(Console.ReadLine(), out userInput);
                        if (validEntry)
                            if (validEntry)
                            {
                                ans = userInput / 30;
                                Console.WriteLine("The answer is " + ans + " month/s");
                            }
                            else if (!validEntry)
                            {
                                Console.WriteLine("\nPlease enter a valid option.");
                                continue;
                            }
                        break;

                    case 5:
                        Console.WriteLine("\nExiting the program...");
                        return;

                    default:
                        Console.WriteLine("\nInvalid input. Please try again.");
                        break;

                }
            }
        }
    }
}
