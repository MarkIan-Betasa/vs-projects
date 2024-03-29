namespace OOP_assign_2
{
        internal class Program
        {
            static void Main(string[] args)
            {
                //create increment (100)
                //modulus 15 == "Hello Goodbye"
                //modulus 3 == "Hello"
                //modulus 5 == "Goodbye"

                Console.WriteLine("Increment (1-100)\n");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("Hello Goodbye");
                        continue;
                    }
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Hello");
                        continue;
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Goodbye");
                        continue;
                    }
                else
                {
                    Console.WriteLine(i);
                    }
                }
            }
        }
    }

