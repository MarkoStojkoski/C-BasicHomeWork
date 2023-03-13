namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap numbers");

            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();

            bool input1Success= int.TryParse(input1, out int number1);
            if (!input1Success)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            bool input2Success = int.TryParse(input2, out int number2);
            if (!input2Success)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            int number1AfterSwaping = number2;
            Console.WriteLine($"After swaping first number is {number1AfterSwaping}");
            int number2AfterSwaping = number1;
            Console.WriteLine($"After swaping second number is {number2AfterSwaping}");




        }
    }
}