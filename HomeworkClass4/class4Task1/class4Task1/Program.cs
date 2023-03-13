using System.Diagnostics.CodeAnalysis;

namespace class4Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1!");
            string input1 = Console.ReadLine();
            bool input1SuccessParse = int.TryParse(input1, out int number1);
            if (!input1SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine("Enter number2!");
            string input2 = Console.ReadLine();
            bool input2SuccessParse = int.TryParse(input2, out int number2);
            if (!input2SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return; 
            }
            Console.WriteLine("Enter number3!");
            string input3 = Console.ReadLine();
            bool input3SuccessParse = int.TryParse(input3, out int number3);
            if (!input3SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return; 
            }
            Console.WriteLine("Enter number4!");
            string input4 = Console.ReadLine();
            bool input4SuccessParse = int.TryParse(input4, out int number4);
            if (!input4SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return; 
            }
            Console.WriteLine("Enter number5!");
            string input5 = Console.ReadLine();
            bool input5SuccessParse = int.TryParse(input5, out int number5);
            if (!input5SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return; 
            }
            Console.WriteLine("Enter number6!");
            string input6 = Console.ReadLine();
            bool input6SuccessParse = int.TryParse(input6, out int number6);
            if (!input6SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return; 
            }
            int[] sixNumberArray = new int[6] { number1, number2, number3, number4, number5, number6};
            int sumEvenNumber = 0;
            for (int i = 0; i < sixNumberArray.Length; i++)
                

            {
                if (sixNumberArray[i] % 2 == 0)
                {
                    sumEvenNumber += sixNumberArray[i];
                    
                }
                
            }
            Console.WriteLine($"The sum of the even numbers is {sumEvenNumber}");
        }
    }
}