using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
/*
Mark Ian G. Betasa
BSCPE 1-1
*/

//create a program that converts time (mins, secs, hours, days, months)
//create conversion for each
//create a list of options
//use doubles for values
//loop for program continuity if the user desires

//values based on secsonds
double s1 = 1;
double m1 = 60;
double h1 = 3600;
double d1 = 86400;
double w1 = 604800;
double mo1 = 2592000; //30 days in a month

//values based on minutes
double s2 = 0.0166667;
double m2 = 1;
double h2 = 60;
double d2 = 1440;
double w2 = 10080;
double mo2 = 302400; //30 days in a month

//values based on hours
double s3 = 0.0166667;
double m3 = 1;
double h3 = 60;
double d3 = 1440;
double w3 = 10080;
double mo3 = 302400; //30 days in a month

while (true)
{
    int select1 = 1;
    int select2 = 2;
    int select3 = 3;
    int select4 = 4;
    int select5 = 5;
    int select6 = 6;
    int mainOption = 0;
    string invalid = "Invalid entry. Please select from options 1-4.";

    Console.WriteLine("Time Conversion\n" +
        "\nChoose option..." +
        "\n[1] second conversions" +
        "\n[2] minute conversions" +
        "\n[3] hour conversions" +
        "\n[4] day conversions\n");

    int mainopt1 = Convert.ToInt32(Console.ReadLine());

    //avoiding user invalid entry
    if (!int.TryParse(Console.ReadLine(), out mainOption) || mainOption < 1 || mainOption > 4)
    {
        Console.WriteLine(invalid);
        continue;
    }
    //for second conversions
    if (mainopt1 == select1)
    {
        Console.WriteLine("Choose option..." +
            "\n[1] seconds to minutes" +
            "\n[2] seconds to hours" +
            "\n[3] seconds to days" +
            "\n[4] seconds to weeks" +
            "\n[5] seconds to months" +
            "\n[6] return to previous selection\n");

        int subopt1 = Convert.ToInt32(Console.ReadLine());

        //nested if conditionals
        if (subopt1 == select1) { //seconds to minutes

            Console.WriteLine("Input seconds to be converted to minutes");
            double userInput = Convert.ToInt16(Console.ReadLine());

            double ans = userInput / 60;

            Console.WriteLine(ans + " minutes");
        }
        else if (subopt1 == select2) { //second to hours

            Console.WriteLine("Input seconds to be converted to hours");
            double userInput = Convert.ToInt32(Console.ReadLine());

            double ans = userInput / 3600;

            Console.WriteLine(ans + " hour/s");
        }
        else if (subopt1 == select3) { //second to days

            Console.WriteLine("Input seconds to be converted to days");
            double userInput = Convert.ToInt32(Console.ReadLine());

            double ans = userInput / 86400;

            Console.WriteLine(ans + " day/s");
        }
        else if (subopt1 == select4) { //seconds to weeks

            Console.WriteLine("Input seconds to be converted to weeks");
            double userInput = Convert.ToInt32(Console.ReadLine());

            double ans = userInput / 604800;

            Console.WriteLine(ans + " hour/s");
        }
        else if (subopt1 == select5) { //seconds to months 

            Console.WriteLine("Input seconds to be converted to months (30 days)");
            double userInput = Convert.ToInt32(Console.ReadLine());

            double ans = userInput / 2592000;

            Console.WriteLine(ans + " month/s");
        }
        else if (subopt1 == select6) { //return to revious selection
            return;

        }







    }
    else if (mainopt1 == select2)
    {
        Console.WriteLine("Choose option..." +
           "\n[1] minutes to seconds" +
           "\n[2] minutes to hours" +
           "\n[3] minutes to days" +
           "\n[4] minutes to weeks" +
           "\n[5] minutes to months\n");

    }
    else if (mainopt1 == select3)
    {
        Console.WriteLine("Choose option..." +
            "\n[1] hours to seconds" +
            "\n[2] hours to minutes" +
            "\n[3] hours to days" +
            "\n[4] hours to weeks" +
            "\n[5] hours to months\n");

    }


    else if (mainopt1 == select4)
    {
        Console.WriteLine("Choose option..." +
            "\n[1] days to seconds" +
            "\n[2] days to minutes" +
            "\n[3] days to hours" +
            "\n[4] days to weeks" +
            "\n[5] days to months");

    }
    Console.WriteLine("Select next action" +
            "\n[1] return to previous selection" +
            "\n[2] return to main selection" +
            "\n[3] proceed to exit the program");











    int opt2 = Convert.ToInt16(Console.ReadLine());
    if (select2 == opt2)
    {










    }

}
