using System.Globalization;

namespace class4Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number1");
            string input1 = Console.ReadLine();
            bool input1SuccessParse = int.TryParse(input1, out int number1);
            if (!input1SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter number2");
            string input2 = Console.ReadLine();
            bool input2SuccessParse = int.TryParse(input2, out int number2);
            if (!input1SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter number3");
            string input3 = Console.ReadLine();
            bool input3SuccessParse = int.TryParse(input3, out int number3);
            if (!input3SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter number4");
            string input4 = Console.ReadLine();
            bool input4SuccessParse = int.TryParse(input4, out int number4);
            if (!input4SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter number5");
            string input5 = Console.ReadLine();
            bool input5SuccessParse = int.TryParse(input5, out int number5);
            if (!input5SuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            int[] fiveNumberArray = new int[5] { number1, number2, number3, number4, number5 };
            int sum = 0;
            
            for (int i = 0; i < fiveNumberArray.Length; i++)
            {
                sum += fiveNumberArray[i];
            }
            Console.WriteLine($"The result is {sum}");
          
            





        }
    }
}