namespace class5Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence!");
            string input =  Console.ReadLine() ;
            string[] words = input.Split() ;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{words[i]};");
            }
            
        }
    }
}