namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator");

            Console.WriteLine("Enter the first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string input2 = Console.ReadLine();
            Console.WriteLine("Choose operation between +,-,*,/");
            string operation = Console.ReadLine();

            bool input1Success = int.TryParse(input1, out int number1);
            if (!input1Success)
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            bool input2Success = int.TryParse(input2, out int number2);
            if (!input2Success)
            {
                Console.WriteLine("Wrong input!");
                return;
            }
            int result;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "*": 
                    result = number1 * number2;
                    Console.WriteLine($" The result is {result}");
                    break;
                case "/":
                    result = number1 / number2;
                    Console.WriteLine($"The result is {result}");
                    break;
                default:
                    Console.WriteLine("Enter a valid operation");
                    break;

            }

        }
    }
}