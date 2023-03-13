namespace Class4Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            bool inputSuccessParse = int.TryParse(input, out int numberInput);
            if(!inputSuccessParse)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for (int i = 1; i <= numberInput; i++)
            {
                if (i %3 ==0)
                {
                    continue;
                }
                 else if (i %7 ==0) {
                    continue;
                }
                if (i == 100)
                {
                    Console.WriteLine("The limit is reached ");
                    break;
                }
                
                Console.WriteLine(i);
                
            }
            
        }
    }
}