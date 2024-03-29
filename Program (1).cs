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

            double sec = 60;
            int min = 60;
            
            /*int min1 = sec;*/ //sec to min conversion
            int hour1 = min; //minutes to hour conversion

            int hour = 24;
            int day1 = hour; // hours to day conversion

       
            int day = 24;
            int month = 31;

            int month1 = day; //day to month conversion

            {

                Console.WriteLine("Input desired conversion (s-m)(m-h)(h-d)(d-mth)");

                string sm = ("(s-m)");
                string mh = ("(m-h)");
                string hd = ("(h-d)");
                string dmth = ("(d-mth)");


                string convOpt = Console.ReadLine();
             
                if (convOpt == sm)
                {
                    Console.WriteLine("Input seconds to be converted to minutes");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput/sec;

                    Console.WriteLine(ans + " minutes");
                }

                if (convOpt == mh)
                {
                    Console.WriteLine("Input minutes to be converted to hours");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput / min;

                    Console.WriteLine(ans + " hours");

                }

                if (convOpt == hd)
                {
                    Console.WriteLine("Input hours to be converted to days");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput / hour;

                    Console.WriteLine(ans + " days");

                }

                if (convOpt == dmth)
                {
                    Console.WriteLine("Input days to be converted to months");
                    double userInput = Convert.ToInt32(Console.ReadLine());

                    double ans = userInput / month;

                    Console.WriteLine(ans + " months");
                }

                Console.WriteLine("Do you want to enter another conversion? (Y / N)");
                string y = "Y";
                string n = "N";
                Console.ReadLine();

                if (Console.ReadLine() == y)
                {
                    return;
                }
                if (Console.ReadLine() == n)
                {
                    Console.WriteLine("Thank you!");
                }







            }
            
            
            
            

        }
    }
}

