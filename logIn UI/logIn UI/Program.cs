using System.ComponentModel.Design;

namespace logIn_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a login ui 
            //Enter username and password (respectively)
            //Have three attempts before failed attempt
            //print invalid username if wrong username
            //print invalid password in wrong password
            //loop the process thrice before ending program

            string correctUser = "Admin";
            string correctPass = "Admin1234!";
            string username = "Enter username: ";
            string password = "Enter password: ";
            int i = 0;
            int max = 3;

            while (i < max)
            {
                Console.Write(username);
                    string userName = Console.ReadLine();

                Console.Write(password);
                    string userPass = Console.ReadLine();

                if (correctUser == userName && correctPass == userPass) {
                    Console.WriteLine("\nLogin successful!");
                    break;
                }

                else if (correctUser != userName && correctPass != userPass) {
                    Console.WriteLine("\nInvalid credentials. Please try again!\n"); i++;
                }

                else if (correctUser != userName) {
                    Console.WriteLine("\nInvalid username. PLease try again!\n"); i++;
                }

                else if (correctPass != userPass) {
                    Console.WriteLine("\nInvalid password. Please try again!\n"); i++;
                }
            
            if (max - i == 1) {
                    Console.WriteLine("You have (1) attempt remaining.\n");
                }

            else if (i == max) {
                Console.WriteLine("Maximum attempts reached!");
                }

            }
        }
    }
}
