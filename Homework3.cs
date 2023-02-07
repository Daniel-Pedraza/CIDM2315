namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Question 1-----");
            Console.WriteLine("Input an integer:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number < 2)
            {
                Console.WriteLine("N is non-prime");
                return; // to end the program

            }

            bool isPrime = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("N is prime");
            }
            else
            {
                Console.WriteLine("N is non-prime");
            }
        }
    }

