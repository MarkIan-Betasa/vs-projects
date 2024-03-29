using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Assign_3
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
                Console.WriteLine("Time converter" +
                    "Please input desired conversion" +
                    "\n[1] seconds to minutes" +
                    "\n[2] minutes to hours" +
                    "\n[3] hours to days" +
                    "\n[4] days to months" +
                    "\n[5] exit program\n");

                int sm = 1;
                int mh = 2;
                int hd = 3;
                int dmth = 4;
                int cancel = 5;
               


                int convOpt = Convert.ToInt16(Console.ReadLine());

                if (convOpt == sm)
                {
                    Console.WriteLine("Input seconds to be converted to minutes");
                    string userInput = Console.ReadLine();
                    if (double.TryParse(Console.ReadLine(), out double userInput)) { 
                    
                    
                    }

                    double ans = userInput / 60;

                    Console.WriteLine(ans + " minute/s");
                }

                if (convOpt == mh)
                {
                    Console.WriteLine("Input minutes to be converted to hours");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput / 60;

                    Console.WriteLine(ans + " hour/s");

                }

                if (convOpt == hd)
                {
                    Console.WriteLine("Input hours to be converted to days");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput / 24;

                    Console.WriteLine(ans + " day/s");

                }

                if (convOpt == dmth)
                {
                    Console.WriteLine("Input days to be converted to months (30 days)");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput / 30;

                    Console.WriteLine(ans + " month/s");
                }

                if (convOpt == cancel)
                {
                    break;
                }
                else {
                    continue;
                }

                Console.WriteLine("Do you want to enter another conversion? (Y / N)");
                string userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")
                {
                    return;
                }
                else {
                    continue;
                }
                if (userInput == "N" || userInput == "n")
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
                else if (userInput != "N" || userInput != "n") {
                    Console.WriteLine("Invalid entry. Please try again.");
                
                }


            }

        }
    }
}

