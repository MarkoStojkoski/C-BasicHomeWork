namespace Class3Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 7");
            Console.WriteLine("Enter number from 1 to 3");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You got a new car!");
                    break;

                case "2":
                    Console.WriteLine("You got a new plane!");
                    break;

                case "3":
                    Console.WriteLine("You got a new bike");
                    break;

                default:
                    Console.WriteLine("You need to enter number between 1 and 3");
                    break;

            }
        }
    }
}