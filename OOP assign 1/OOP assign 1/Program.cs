using System.Net.Security;

namespace OOP_assign_1
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

            // *remove "invelid username" at the end of failed attempt
            // *restart to "Enter username" after invalid usename
            // *restart to "Enter password" after invalid password

            int i = 0;
            int maxI = 3;
            string username = "Admin";
            username = Console.ReadLine();
            string password = "Admin1234!";
            password = Console.ReadLine();

            while (i < maxI)
            {
                Console.Write("Enter your username: ");


                if (username == "Admin")
                {
                    i = 1;

                    Console.Write("Enter your password: ");

                    if (password == "Admin1234!")
                    {
                        Console.WriteLine("Login successful!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password. Please try again\n");
                        i++;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid username. Please try again.\n");
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
