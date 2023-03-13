using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace class5Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a multiple digits number!");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Wrong input");
                return;
            }
           

             static int SumOfDigits (int number)
            {
                int sum = 0;
                while (number!=0)
                {
                    sum += number%10;
                    number /=10;
                }
                return sum;
   
            }
          Console.WriteLine($"The sum of the digits is {SumOfDigits(number)}");
            
           



        }
    }
}

          

            
    

