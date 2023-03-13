namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average number!");

            Console.WriteLine("Enter the first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the third number");
            string input3 = Console.ReadLine();
            Console.WriteLine("Enter the fourth number");
            string input4 = Console.ReadLine();

            bool input1Success = double.TryParse(input1, out double number1);
            if (!input1Success)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            bool input2Success = double.TryParse(input2, out double number2);
            if (!input2Success)
            {
                Console.WriteLine("Wrong input");
                return; 
            }

            bool input3Success = double.TryParse(input3, out double number3);
            if (!input3Success)
            {
                Console.WriteLine("Wrong input");
                return; 
            }

            bool input4Success = double.TryParse(input4, out double number4);
            if (!input4Success)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            double output = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The average of {number1}, {number2}, {number3} and {number4} is {output}");
        }
    }
}