using System.ComponentModel.Design;

namespace class3Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise3");
         
            Console.WriteLine("Enter the first number");     
            string input1 = Console.ReadLine();
            int firstNumber;
            bool firstNumberSuccess = int.TryParse(input1, out firstNumber);
            if(!firstNumberSuccess)
            {
                Console.WriteLine("Wrong input");
                return;
                  
            }
            Console.WriteLine("Enter the second number");
            string input2 = Console.ReadLine();
            int secondNumber;
            bool secondNumberSuccess = int.TryParse(input2, out secondNumber);
            if (!secondNumberSuccess)
            {
                Console.WriteLine("Wrong input");
                return;

            }

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Numbers are equal");
                
                
            } else if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is larger than {secondNumber}");
               

            } else if ( secondNumber > firstNumber)
            {
                Console.WriteLine($"{secondNumber} is larger than {firstNumber}");
                

            };

            if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
            {
                Console.WriteLine("Both numbers are even");  
            };
            
            if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
            {
                Console.WriteLine("Both numbers are odd");
            };

            if(firstNumber % 2 == 0 && secondNumber % 2 != 0)
            {
                Console.WriteLine($"{firstNumber} is even and {secondNumber} is odd");
            };

            if  (secondNumber % 2 == 0 && firstNumber % 2 != 0)
            {
                Console.WriteLine($"{secondNumber} is even and {firstNumber} is odd");
            };


            
               
            
           

           
        }
    }
}