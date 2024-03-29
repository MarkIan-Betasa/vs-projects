using System;
using System.ComponentModel.Design;

namespace Betasa_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //login interface
            //attempt input
            //readline username
            //input starting attempt
            //limit increment to three attempts
            //if correct procceed to password readline else repeat until accomplished
            //enter password, if true end program, else repeat

            int i = 0;
            int maxI = 3;

            while (i < maxI)
            {
                Console.Write("Enter your username: ");
                string username = "Admin";
                username = Console.ReadLine();
                    
                    if (username == "Admin")
                    {
                    i = 1;

                    Console.Write("Enter your password: ");
                        string password = "Admin1234!";
                        password = Console.ReadLine();
                    
                        if (password == "Admin1234!")
                        {
                            Console.WriteLine("Login successful!");
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Invalid password. Please try again");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid username. Please try again.");
                        i++;
                    }

                    if (i == maxI)
                    {
                        Console.WriteLine("Maximum attempt reached!");
                    }                    
            }
        }
    }
}
