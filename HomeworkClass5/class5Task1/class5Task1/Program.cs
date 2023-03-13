namespace class5Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or sentence");
            string input = Console.ReadLine();

            if (input.Length < 5)
            {
                Console.WriteLine("Please enter larger word");
                return;
            }
            
            Console.WriteLine(input.Substring(input.Length - 5));
        }
    }
}