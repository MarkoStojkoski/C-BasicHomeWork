namespace class5Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string input = Console.ReadLine();
            string[] words;
            int longest = 0, len, max = 0;
            words = input.Split(' ');
            len = words.Length;

            for (int i = 0; i < len; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    longest = i;
                }
            }
            Console.WriteLine($"Longest word in the sentence is { words[longest]}");


           




            }
        }
    }
